using Microsoft.AspNetCore.Identity;

namespace CarBookingApplicationProject.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarBookingApplicationProjectUser : IdentityUser
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
