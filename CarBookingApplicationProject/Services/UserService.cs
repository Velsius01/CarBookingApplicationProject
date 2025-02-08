using CarBookingApplicationProject.Domain;
using System;

namespace CarBookingApplicationProject.Services
{
    public class UserService
    {
        public void ValidateUserRoles(UserProfile user)
        {
            if (!user.IsDriver && !user.IsPassenger)
            {
                throw new Exception("User must register as either a Driver or Passenger.");
            }
        }

        public void RegisterUser(UserProfile user)
        {
            // Validate roles
            ValidateUserRoles(user);

            // Add logic to save user to the database
            // For example:
            // _dbContext.Users.Add(user);
            // _dbContext.SaveChanges();
        }
    }
}
