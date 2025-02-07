namespace CarBookingApplicationProject.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string? LicensePlate { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string? Year { get; set; }
        public string? Status { get; set; }
        public string? MaximumPassengers { get; set; }
        public int UserId { get; set; }
    }
}
