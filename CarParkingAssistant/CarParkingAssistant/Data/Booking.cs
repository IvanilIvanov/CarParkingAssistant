using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public required string LicensePlate { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public bool IsPaid { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }





        [ForeignKey(nameof(User))]
        public required string UserId { get; set; }
        public required CarParkingAssistantUser User { get; set; }

    }

}