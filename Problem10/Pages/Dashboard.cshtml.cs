using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Problem10.Pages
{
    public class DashboardModel : PageModel
    {
        public string? Username { get; set; }

        public IActionResult OnGet()
        {
            Username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(Username))
            {
                return RedirectToPage("Login");
            }

            return Page();
        }
    }
}
