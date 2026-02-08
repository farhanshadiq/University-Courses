using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem12.Data;
using Problem12.Models;

namespace Problem12.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
