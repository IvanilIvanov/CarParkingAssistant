using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure.Data.Models
{
    public class CarParkingAssistantUser : IdentityUser
    {
        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string? LastName { get; set; }


        [Required]
        public DateTime RegisterDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
