using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarParkingAssistant.Areas.Identity.Data;

public class CarParkingAssistantUser : IdentityUser
{
    [Required]
    public required string FirstName { get; set; }

    [Required]
    public required string LastName { get; set; }

    [Required]
    public DateTime RegisteredOn { get; set; }

    [Required]
    public required float Credits { get; set; } = 0;

    public required ICollection<ParkingBooking> ParkingBookings { get; set; }

}

