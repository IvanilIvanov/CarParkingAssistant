namespace CarParkingAssistant.Infrastructure.Models
{
    public class Worker : CarParkingAssistantUser
    {
        public required string EGN { get; set; }
        public required virtual ICollection<Parking> AssignedParkings { get; set; }
        public required float Salary { get; set; }
    }
}