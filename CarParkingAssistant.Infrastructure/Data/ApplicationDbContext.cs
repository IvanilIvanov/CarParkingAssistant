using CarParkingAssistant.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarParkingAssistant.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<CarParkingAssistantUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Parking> Parkings{ get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
