
using Microsoft.EntityFrameworkCore;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Data
{
    public class DataContext:DbContext
    {
        DbSet<Vehicle> Vehicles { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vehicle>().HasIndex(x => x.type).IsUnique();
        }
    }
}
