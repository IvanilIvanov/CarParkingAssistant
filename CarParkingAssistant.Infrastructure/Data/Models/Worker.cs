using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParkingAssistant.Infrastructure.Data.Models
{
    public class Worker
    {

        public Worker()
        {
            Id = Guid.NewGuid();
            StartDate = DateTime.Now;
            Parkings = new HashSet<Parking>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required]
        public required DateTime StartDate { get; set; }

        public DateTime? QuitDate { get; set; }

        [Required]
        public required string EGN { get; set; }

        [Required]
        public required float Salary { get; set; }


        public virtual required ICollection<Parking> Parkings { get; set; }

    }
}
