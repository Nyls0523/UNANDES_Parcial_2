using Microsoft.EntityFrameworkCore;
using WebApplication_P2.Data.Entity;

namespace WebApplication_P2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Planta> Plantas { get; set; } = null!;
        public DbSet<Riego> riegos { get; set; } = null!;
    }
}
