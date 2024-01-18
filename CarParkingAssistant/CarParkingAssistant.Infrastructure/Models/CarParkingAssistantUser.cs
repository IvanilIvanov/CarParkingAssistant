using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure.Models
{
    public class CarParkingAssistantUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required string Email { get; set; }
        public required string HashedPassword { get; set; }

        public required Guid BookingId { get; set; }
        public required Booking CurrentBooking { get; set; }

        public required virtual ICollection<Booking> PreviousBookings { get; set; }

        public DateTime RegisteredOn { get; set; }

        public float Credits { get; set; }
    }
}
