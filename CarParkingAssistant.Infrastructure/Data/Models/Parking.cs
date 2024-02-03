using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Infrastructure.Data.Models
{
    public class Parking
    {
        public Parking()
        {
            Id = Guid.NewGuid();
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public required Guid Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "{0} length cannot be more than {1}")]
        [MinLength(10, ErrorMessage = "{0} length cannot be less than {1}")]
        public required string Address { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Parkings slots cannot be less than {1}")]
        public required int NumSlots { get; set; }

        [Required]
        [Range(0.5, 10, ErrorMessage = "{0} must be between {1} and {2}")]
        [Column(TypeName = "decimal(4, 2)")]
        public required decimal Price { get; set; }

        
        [ForeignKey(nameof(Worker))]
        public Guid? WorkerId { get; set; }
        public Worker Worker { get; set; }

        public required virtual ICollection<Booking> Bookings { get; set; }
    }

}
