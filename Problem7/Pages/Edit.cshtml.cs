using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Problem7.Data;
using Problem7.Models;

namespace Problem7.Pages
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var teacher = await _context.Teachers.FindAsync(Id);
            if (teacher == null)
            {
                return NotFound();
            }

            Teacher = teacher;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            _context.Teachers.Update(Teacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
