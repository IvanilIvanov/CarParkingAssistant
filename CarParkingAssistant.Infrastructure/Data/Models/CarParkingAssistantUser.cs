using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure.Data.Models
{
    public class CarParkingAssistantUser : IdentityUser
    {
        public CarParkingAssistantUser()
        {
            RegisterDate = DateTime.Now;
            IsDeleted = false;
            Credits = 0;
            Bookings = new HashSet<Booking>();
        }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string? LastName { get; set; }

        [Required]
        public required DateTime RegisterDate { get; set; }

        [Required]
        public required bool IsDeleted { get; set; }

        [Required]
        public required float Credits { get; set; }


        public virtual required ICollection<Booking> Bookings { get; set; }
    }
}
