using Microsoft.EntityFrameworkCore;
using Rocky.Models;

namespace Rocky.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }

        public DbSet<Category> Category { get; set; }
    }
}
