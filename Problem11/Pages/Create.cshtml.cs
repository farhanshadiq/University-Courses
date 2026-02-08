using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem11.Data;
using Problem11.Models;

namespace Problem11.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ElectronicsProduct ElectronicsProduct { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            _context.ElectronicsProducts.Add(ElectronicsProduct);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
