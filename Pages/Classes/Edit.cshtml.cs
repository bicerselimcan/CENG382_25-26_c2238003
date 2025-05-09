using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models;
using DotNetWeek5App.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetWeek5App.Pages.Classes
{
    public class EditModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public EditModel(SchoolDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Class EditClass { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            EditClass = await _context.Classes.FirstOrDefaultAsync(x => x.Id == id);

            if (EditClass == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EditClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Classes.Any(e => e.Id == EditClass.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}