namespace CarBookingApplicationProject.Domain
{
    public class Ride : BaseDomainModel
    {
        public DateTime PickupTime { get; set; }
        public DateTime DropoffTime { get; set; }
        public string? RideStatus { get; set; }
        public decimal RideCost { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public int PromotionId { get; set; }
    }
}
