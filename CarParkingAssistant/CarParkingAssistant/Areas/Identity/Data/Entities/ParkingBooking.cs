using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data.Entities
{
    public class ParkingBooking
    {

        [Required]
        [ForeignKey(nameof(Parking))]
        public Guid ParkingId { get; set; }
        public required Parking Parking { get; set; }

        [Required]
        [ForeignKey(nameof(Booking))]
        public Guid BookingId { get; set; }
        public required Booking Booking { get; set; }
    }
}
