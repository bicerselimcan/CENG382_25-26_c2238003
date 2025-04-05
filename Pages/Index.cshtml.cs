using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            // Razor Pages bug çözümü: query string'i elle oku
            if (Request.Query.ContainsKey("Page"))
            {
                int.TryParse(Request.Query["Page"], out int p);
                Page = p;
            }
            if (Request.Query.ContainsKey("Filter"))
            {
                Filter = Request.Query["Filter"];
            }

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

            if (!string.IsNullOrWhiteSpace(Filter))
            {
                query = query.Where(x => x.ClassName.Contains(Filter, System.StringComparison.OrdinalIgnoreCase));
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
    }
}
