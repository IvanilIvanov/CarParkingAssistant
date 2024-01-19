using CarParkingAssistant.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CarParkingAssistant.Data;

public class ApplicationDbContext : IdentityDbContext<CarParkingAssistantUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<CarParkingAssistantUser> Users { get; set; }
    public DbSet<Parking> Parkings { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ParkingBooking>()
    .HasKey(pb => new { pb.ParkingId, pb.BookingId });

    }
}
