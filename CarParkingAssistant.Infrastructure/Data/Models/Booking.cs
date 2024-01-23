using CarParkingAssistant.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Infrastructure.Data.Models
{
    public class Booking
    {
        public Booking()
        {
            Id = Guid.NewGuid();
            IsPaid = false;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 7)]
        public required string LicensePlate { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [Range(2, 20, ErrorMessage = "Must be between 2 and 20!")]
        [Column(TypeName = "decimal(4, 2)")]
        public required decimal TotalPrice { get; set; }

        [Required]
        public required bool IsPaid { get; set; }

        [ForeignKey(nameof(User))]
        public required string UserId { get; set; }
        public required CarParkingAssistantUser User { get; set; }

        [ForeignKey(nameof(Parking))]
        public required Guid ParkingId { get; set; }
        public required Parking Parking { get; set; }
    }

}