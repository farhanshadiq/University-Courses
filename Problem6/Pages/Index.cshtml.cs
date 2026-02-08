using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem6.Data;
using Problem6.Models;

namespace Problem6.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Student> Students { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Students = _context.Students.ToList();
        }
    }
}
