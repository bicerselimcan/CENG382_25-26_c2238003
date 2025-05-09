using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetWeek5App.Models;
using DotNetWeek5App.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWeek5App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public IndexModel(SchoolDbContext context)
        {
            _context = context;
        }

        public IList<Class> ClassList { get; set; } = new List<Class>();

        public async Task OnGetAsync()
        {
            var username = HttpContext.Session.GetString("username");
            var token = HttpContext.Session.GetString("token");
            var sessionId = HttpContext.Session.GetString("session_id");

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(token) ||
                string.IsNullOrEmpty(sessionId) ||
                username != Request.Cookies["username"] ||
                token != Request.Cookies["token"] ||
                sessionId != Request.Cookies["session_id"])
            {
                Response.Redirect("/Login");
                return;
            }

            ClassList = await _context.Classes
                .Where(c => c.IsActive)
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var classToDeactivate = await _context.Classes.FindAsync(id);
            if (classToDeactivate != null)
            {
                classToDeactivate.IsActive = false;
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}