using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data.Entities
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
        public required string WorkerEGN { get; set; }

        [ForeignKey(nameof(WorkerEGN))]
        public required Worker Worker { get; set; }


        public required ICollection<Booking> CurrentBookings { get; set; }
        public required ICollection<Booking> AllBookings { get; set; }
    }

}
