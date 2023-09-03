using dasho.Models;
using Microsoft.EntityFrameworkCore;

namespace dasho.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
     
    }
}
