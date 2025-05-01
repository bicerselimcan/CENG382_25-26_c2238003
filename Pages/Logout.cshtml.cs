using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetWeek5App.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            try
            {
                // Session temizlemek için
                HttpContext.Session.Clear();

                // Tüm cookie'leri dögü ile silmek için
                foreach (var cookieKey in Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(cookieKey);
                }

                // Giriş sayfasına yönlendirmek için
                return RedirectToPage("/Login");
            }
            catch
            {
                // Hata olursa Logout sayfasında hata mesajı göstermek için
                return Content("Hata oluştu, Logout işlemi tamamlanamadı.");
            }
        }
    }
}