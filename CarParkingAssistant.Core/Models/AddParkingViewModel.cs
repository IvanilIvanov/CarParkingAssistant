using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Core.Models
{
    public class AddParkingViewModel
    {
        public string Address { get; set; }
        public int NumSlots { get; set; }
        public string Name { get; set; }
    }
}
