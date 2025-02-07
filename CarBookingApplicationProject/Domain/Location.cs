namespace CarBookingApplicationProject.Domain
{
    public class Location : BaseDomainModel
    {
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
    }
}
