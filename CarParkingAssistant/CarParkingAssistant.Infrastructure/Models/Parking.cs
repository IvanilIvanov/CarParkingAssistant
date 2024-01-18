using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure.Models
{
    public class Parking
    {
        public required Guid Id { get; set; } = Guid.NewGuid();
        public required string Address { get; set; }
        public required int NumSlots { get; set; }
        public required float Price { get; set; }

        public required virtual ICollection<Booking> CurrBookings { get; set; }
        public required virtual ICollection<Booking> AllBookings { get; set; }

        public required Worker worker { get; set; }
    }
}
