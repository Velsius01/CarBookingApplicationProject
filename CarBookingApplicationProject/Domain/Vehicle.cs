namespace CarBookingApplicationProject.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string? LicensePlate { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public int? Year { get; set; }
        public string? Status { get; set; }
        public int? MaximumPassengers { get; set; }
        public int? UserId { get; set; } // Nullable integer


        public User? User { get; set; }
    }
}
