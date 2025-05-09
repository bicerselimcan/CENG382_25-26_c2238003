using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetWeek5App.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public LoginModel(SchoolDbContext context)
        {
            _context = context;
        }

        [BindProperty] public string Username { get; set; }
        [BindProperty] public string Password { get; set; }
        [BindProperty] public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.Users.FirstOrDefaultAsync(u =>
                u.Username == Username && u.Password == Password && u.IsActive);

            if (user == null)
            {
                ErrorMessage = "Invalid credentials.";
                return Page();
            }

            var token = Guid.NewGuid().ToString();
            HttpContext.Session.SetString("username", Username);
            HttpContext.Session.SetString("token", token);
            HttpContext.Session.SetString("session_id", HttpContext.Session.Id);

            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddMinutes(30),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };

            Response.Cookies.Append("username", Username, cookieOptions);
            Response.Cookies.Append("token", token, cookieOptions);
            Response.Cookies.Append("session_id", HttpContext.Session.Id, cookieOptions);

            return RedirectToPage("/Index");
        }
    }
}