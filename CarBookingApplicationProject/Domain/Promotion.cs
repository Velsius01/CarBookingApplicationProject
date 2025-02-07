namespace CarBookingApplicationProject.Domain
{
    public class Promotion : BaseDomainModel
    {
        public string? PromotionCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
