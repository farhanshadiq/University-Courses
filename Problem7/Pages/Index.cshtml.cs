using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem7.Data;
using Problem7.Models;

namespace Problem7.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Teacher> Teachers { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Teachers = _context.Teachers.ToList();
        }
    }
}
