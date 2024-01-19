using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data
{
    public class Parking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public required string Address { get; set; }

        [Required]
        public required int NumSlots { get; set; }

        [Required]
        public required float Price { get; set; }



        [Required]
        public Guid WorkerId { get; set; }

        public required ICollection<ParkingBooking> ParkingBookings { get; set; }

    }

}
