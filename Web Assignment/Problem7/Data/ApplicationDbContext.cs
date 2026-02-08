using Microsoft.EntityFrameworkCore;
using Problem7.Models;

namespace Problem7.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
