namespace CarBookingApplicationProject.Domain
{
    public class Payment : BaseDomainModel
    {
        public string? PaymentType { get; set; }
        public decimal AmountPaid { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int RideId { get; set; }
        public int UserId { get; set; }
    }
}
