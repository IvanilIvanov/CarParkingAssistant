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
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public required string LastName { get; set; }

        [Required]
        public required DateTime StartDate { get; set; }

        public DateTime? QuitDate { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "The {0} must be between {2] and {1} characters long.", MinimumLength = 10)]
        public required string EGN { get; set; }

        [Required]
        [Column(TypeName = "decimal(8, 2)")]
        public required decimal Salary { get; set; }


        public virtual required ICollection<Parking> Parkings { get; set; }

    }
}
