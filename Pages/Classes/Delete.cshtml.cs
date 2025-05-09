using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models;
using DotNetWeek5App.Models.Data;

namespace DotNetWeek5App.Pages.Classes
{
    public class DeleteModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public DeleteModel(SchoolDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Class ClassToDelete { get; set; }

        public IActionResult OnGet(int id)
        {
            ClassToDelete = _context.Classes.FirstOrDefault(c => c.Id == id);
            if (ClassToDelete == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var classEntity = _context.Classes.FirstOrDefault(c => c.Id == ClassToDelete.Id);
            if (classEntity != null)
            {
                _context.Classes.Remove(classEntity);
                _context.SaveChanges();
            }
            return RedirectToPage("Index");
        }
    }
}