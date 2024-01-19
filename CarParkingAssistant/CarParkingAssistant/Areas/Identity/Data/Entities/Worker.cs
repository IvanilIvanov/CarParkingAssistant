using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data.Entities
{
    public class Worker
    {
        [Key]
        public required string EGN { get; set; }

        [Required]
        public required string UserId { get; set; }
        [Required]
        public required float Salary { get; set; }


        [ForeignKey(nameof(UserId))]
        public required CarParkingAssistantUser User { get; set; }


        [InverseProperty("Worker")]
        public required ICollection<Parking> AssignedParkings { get; set; }
    }
}
