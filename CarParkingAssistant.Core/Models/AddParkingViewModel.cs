using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Core.Models
{
    public class AddParkingViewModel
    {
        [Required]
        [MaxLength(100, ErrorMessage = "{0} length cannot be more than {1}")]
        [MinLength(10, ErrorMessage = "{0} length cannot be less than {1}")]
        public required string Address { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "{0} must be between {1} and {2}")]
        public required int NumSlots { get; set; }
        [Required]
        [Range(0.5, 10, ErrorMessage = "{0} must be between {1} and {2}")]
        
        public required decimal Price { get; set; }
    }
}
