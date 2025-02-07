namespace CarBookingApplicationProject.Domain
{
    public class Feedback : BaseDomainModel
    {
        public int Rating { get; set; }
        public string? Comments { get; set; }
        public DateTime FeedbackDateTime { get; set; }
        public int RideId { get; set; }
        public int UserId { get; set; }
    }
}
