using CarParkingAssistant.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Core.Models
{
    public class AdminParkingViewModel
    {
        public ICollection<Parking> Parkings { get; set; }
    }
}
