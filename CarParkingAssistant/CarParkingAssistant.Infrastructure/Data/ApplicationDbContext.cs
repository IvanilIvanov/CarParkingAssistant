using CarParkingAssistant.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<CarParkingAssistantUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ParkingBooking>()
    .HasKey(pb => new { pb.BookingId, pb.ParkingId });

            base.OnModelCreating(builder);
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<ParkingBooking> ParkingsBookings { get; set; }

        public DbSet<Worker> Workers { get; set; }
    }

}
