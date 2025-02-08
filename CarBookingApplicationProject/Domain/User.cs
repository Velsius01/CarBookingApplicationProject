namespace CarBookingApplicationProject.Domain
{
    public class User : BaseDomainModel
    {
        public string? DisplayName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? CarLicense { get; set; }
        public string? AcceptanceRate { get; set; }
        public string? DrivingExperience { get; set; }
        public string? FrequentLocations { get; set; }
        public string? PreferredPickupTime { get; set; }
        

        public bool IsDriver { get; set; } // Indicates if the user is a driver
        public bool IsPassenger { get; set; } // Indicates if the user is a passenger
    }
}
