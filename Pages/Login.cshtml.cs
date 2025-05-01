using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models;
using System.Text.Json;

namespace DotNetWeek5App.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string Username { get; set; }
        [BindProperty] public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "users.json");
            var users = JsonSerializer.Deserialize<List<User>>(System.IO.File.ReadAllText(jsonPath));

            var user = users.FirstOrDefault(u => u.Username == Username && u.Password == Password && u.IsActive);

            if (user == null)
            {
                ErrorMessage = "Username or password is incorrect.";
                return Page();
            }

            // Token oluşturmak için
            var token = Guid.NewGuid().ToString();
            var sessionId = HttpContext.Session.Id;

            // Session'da tutmak için
            HttpContext.Session.SetString("username", Username);
            HttpContext.Session.SetString("token", token);
            HttpContext.Session.SetString("session_id", sessionId);

            // Cookies'de tutmak için
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(30),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };
            Response.Cookies.Append("username", Username, options);
            Response.Cookies.Append("token", token, options);
            Response.Cookies.Append("session_id", sessionId, options);

            return Redirect("/Index"); // Ana tabloya yönlendirmesi için
        }
    }
}