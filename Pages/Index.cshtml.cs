using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Utilities;
using DotNetWeek5App.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotNetWeek5App.Pages
{
    public class IndexModel : PageModel
    {
        private static List<ClassInformationTable> _classList = new();

        [BindProperty]
        public ClassInformationTable NewClass { get; set; } = new();

        public List<ClassInformationTable> PagedList { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string? Filter { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Page { get; set; } = 1;

        public int TotalPages { get; set; }

        private const int PageSize = 10;

// NOTE:
// During implementation, I encountered a major issue where the pagination was not working correctly.
// Even though the ?Page=X query string appeared in the URL, the Page value was always stuck at 1,
// and the data on screen never changed. I tried using asp-route, BindProperty(SupportsGet = true),
// and even customized routing, but nothing worked.
// Finally, I resolved the issue by manually extracting query parameters from Request.Query
// inside the OnGet() method. This workaround bypasses Razor Pages binding problems,
// and allowed proper pagination with filtering to function as expected.

// I got help from various sources that I can't remember but specially GPT.
     
        public void OnGet()
        {
            // Oturum yoksa otomatik olarak giriş sayfasına yönlendirmek için
            var username = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(username))
            {
                Response.Redirect("/Login");
                return;
            }

            if (HttpContext.Session.GetString("username") != Request.Cookies["username"] ||
            HttpContext.Session.GetString("token") != Request.Cookies["token"] ||
            HttpContext.Session.GetString("session_id") != Request.Cookies["session_id"])
        {
            TempData["Error"] = "Unauthorized access.";
            Response.Redirect("/Login");
        }

            if (Request.Query.ContainsKey("Page") && int.TryParse(Request.Query["Page"], out var parsedPage))
            {
                Page = parsedPage;
            }

            if (Request.Query.ContainsKey("Filter"))
                Filter = Request.Query["Filter"];

            var trimmedFilter = Filter?.Trim(); // NULL CHECK burada yapılır

            if (!_classList.Any())
            {
                for (int i = 1; i <= 100; i++)
                {
                    _classList.Add(new ClassInformationTable
                    {
                        Id = i,
                        ClassName = $"Class {i}",
                        StudentCount = 10 + (i % 30),
                        Description = $"This is class {i}"
                    });
                }
            }

            var query = _classList.AsQueryable();

            if (!string.IsNullOrWhiteSpace(trimmedFilter))
            {
                query = query.Where(x => x.ClassName.Trim().Equals(trimmedFilter, System.StringComparison.OrdinalIgnoreCase));
            }

            int totalItems = query.Count();
            TotalPages = (int)System.Math.Ceiling(totalItems / (double)PageSize);
            if (TotalPages == 0) TotalPages = 1;

            if (Page < 1) Page = 1;
            if (Page > TotalPages) Page = TotalPages;

            PagedList = query
                .Skip((Page - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }

        public IActionResult OnPostAdd()
        {
            NewClass.Id = _classList.Any() ? _classList.Max(x => x.Id) + 1 : 1;
            _classList.Add(NewClass);
            return RedirectToPage("./Index", new { Page = 1, Filter });
        }

        public IActionResult OnPostDelete(int id)
        {
            var item = _classList.FirstOrDefault(x => x.Id == id);
            if (item != null) _classList.Remove(item);
            return RedirectToPage("./Index", new { Page, Filter });
        }

        public IActionResult OnPostEdit(int id)
        {
            var item = _classList.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                NewClass = new ClassInformationTable
                {
                    Id = item.Id,
                    ClassName = item.ClassName,
                    StudentCount = item.StudentCount,
                    Description = item.Description
                };
            }

            OnGet();
            return Page();
        }

        public IActionResult OnPostUpdate()
        {
            var item = _classList.FirstOrDefault(x => x.Id == NewClass.Id);
            if (item != null)
            {
                item.ClassName = NewClass.ClassName;
                item.StudentCount = NewClass.StudentCount;
                item.Description = NewClass.Description;
            }
            return RedirectToPage("./Index", new { Page, Filter });
        }

        [BindProperty]
        public List<string> SelectedColumns { get; set; } = new List<string>();

        public IActionResult OnPostExportUnfiltered()
        {
            var json = Utils.Instance.ExportToJson(_classList, SelectedColumns);
            System.IO.File.WriteAllText("wwwroot/unfiltered_export.json", json);
            return File(System.IO.File.ReadAllBytes("wwwroot/unfiltered_export.json"), "application/json", "unfiltered_export.json");
        }

        public IActionResult OnPostExportFiltered()
        {
            string postedFilter = Request.Form["Filter"];
            string trimmedFilter = postedFilter?.Trim();

            var filtered = string.IsNullOrEmpty(trimmedFilter)
                ? _classList
                : _classList.Where(x => x.ClassName.Trim().Equals(trimmedFilter, StringComparison.OrdinalIgnoreCase)).ToList();

            var json = Utils.Instance.ExportToJson(filtered, SelectedColumns);
            System.IO.File.WriteAllText("wwwroot/filtered_export.json", json);
            return File(System.IO.File.ReadAllBytes("wwwroot/filtered_export.json"), "application/json", "filtered_export.json");
        }
    }
}
