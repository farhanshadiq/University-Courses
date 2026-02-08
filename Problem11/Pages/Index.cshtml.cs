using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem11.Data;
using Problem11.Models;

namespace Problem11.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<ElectronicsProduct> ElectronicsProducts { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            ElectronicsProducts = _context.ElectronicsProducts.ToList();
        }
    }
}
