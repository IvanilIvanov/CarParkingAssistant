using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarParkingAssistant.Areas.Identity.Data.Entities;

public class CarParkingAssistantUser : IdentityUser
{
    [Required]
    public required string FirstName { get; set; }

    [Required]
    public required string LastName { get; set; }

    [Required]
    public DateTime RegisteredOn { get; set; }

    public Guid CurrentBookingId { get; set; }

    public Booking? CurrentBooking { get; set; }

    [Required]
    public required float Credits { get; set; } = 0;

    [InverseProperty("User")]
    public required ICollection<Booking> BookingHistory { get; set; }
}

