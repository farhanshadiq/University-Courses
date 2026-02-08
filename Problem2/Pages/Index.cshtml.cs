using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem1.Data;
using Problem1.Models;

namespace Problem1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Product> Products { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
