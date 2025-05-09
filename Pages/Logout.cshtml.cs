using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetWeek5App.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            return LogoutAndRedirect();
        }

        public IActionResult OnPost()
        {
            return LogoutAndRedirect();
        }

        private IActionResult LogoutAndRedirect()
        {
            HttpContext.Session.Clear();

            foreach (var cookieKey in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookieKey);
            }

            return RedirectToPage("/Login");
        }
    }
}