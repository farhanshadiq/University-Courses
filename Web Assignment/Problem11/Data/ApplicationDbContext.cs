using Microsoft.EntityFrameworkCore;
using Problem11.Models;

namespace Problem11.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ElectronicsProduct> ElectronicsProducts { get; set; }
    }
}
