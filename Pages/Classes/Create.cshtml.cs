using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models;
using DotNetWeek5App.Models.Data;

namespace DotNetWeek5App.Pages.Classes
{
    public class CreateModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public CreateModel(SchoolDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Class NewClass { get; set; } = new();

        public void OnGet() {}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewClass.CreatedAt = DateTime.Now;
            _context.Classes.Add(NewClass);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}