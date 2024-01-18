namespace CarParkingAssistant.Infrastructure.Models
{
    public class Booking
    {
        public required Guid Id { get; set; } = Guid.NewGuid();
        public required string UserId { get; set; }
        public required string LicensePlate { get; set; }
        public float Price { get; set; }
        public bool IsPaid { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


    }
}