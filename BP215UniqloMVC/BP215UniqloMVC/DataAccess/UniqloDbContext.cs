using BP215UniqloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BP215UniqloMVC.DataAccess
{
    public class UniqloDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public UniqloDbContext(DbContextOptions opt) : base(opt) { }
    }
}
