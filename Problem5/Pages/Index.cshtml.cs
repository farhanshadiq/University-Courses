using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem5.Data;
using Problem5.Models;

namespace Problem5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Employee> Employees { get; set; } = new();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Employees = _context.Employees.ToList();
        }
    }
}
