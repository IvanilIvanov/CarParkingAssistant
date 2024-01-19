using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data
{
    public class ParkingBooking
    {

        [ForeignKey(nameof(Parking))]
        public Guid ParkingId { get; set; }
        public required Parking Parking { get; set; }

        [ForeignKey(nameof(Booking))]
        public Guid BookingId { get; set; }
        public required Booking Booking { get; set; }

    }
}
