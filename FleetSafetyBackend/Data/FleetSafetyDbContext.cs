using Microsoft.EntityFrameworkCore;

namespace FleetSafetyBackend.Data
{
    public class FleetSafetyDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public FleetSafetyDbContext(DbContextOptions<FleetSafetyDbContext> options) : base(options) { }

    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }

}

