using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Areas.Identity.Data
{
    public class Worker

    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime QuitDate { get; set; }

        [Required]
        public required string EGN { get; set; }

        [Required]
        public required float Salary { get; set; }



        public required ICollection<Parking> AssignedParkings { get; set; }

    }
}
