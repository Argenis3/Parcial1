using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Technician> Technicians { get; set; }

        public DataContext(DbContextOptions<DataContext> options):base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Classification>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
