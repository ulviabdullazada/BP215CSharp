using BP215UniqloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BP215UniqloMVC.DataAccess
{
    public class UniqloDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public UniqloDbContext(DbContextOptions opt) : base(opt) { }
    }
}
