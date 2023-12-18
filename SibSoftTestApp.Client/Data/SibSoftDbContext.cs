using Microsoft.EntityFrameworkCore;
using SibSoftTestApp.Client.Models;

namespace SibSoftTestApp.Client.Data
{
    public class SibSoftDbContext : DbContext
    {
        public SibSoftDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleServices { get; set; }
    }
}