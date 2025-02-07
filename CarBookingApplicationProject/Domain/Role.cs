namespace CarBookingApplicationProject.Domain
{
    public class Role : BaseDomainModel
    {
        public string? RoleType { get; set; }
        public int UserId { get; set; }
    }
}
