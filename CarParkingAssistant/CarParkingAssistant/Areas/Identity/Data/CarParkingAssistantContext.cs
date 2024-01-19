using CarParkingAssistant.Areas.Identity.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CarParkingAssistant.Data;

public class CarParkingAssistantContext : IdentityDbContext<CarParkingAssistantUser>
{
    public CarParkingAssistantContext(DbContextOptions<CarParkingAssistantContext> options)
        : base(options)
    {
    }

    public DbSet<Parking> Parkings { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ParkingBooking>()
    .HasKey(pb => new { pb.ParkingId, pb.BookingId });

    }
}
