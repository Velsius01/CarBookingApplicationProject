using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarBookingApplicationProject.Domain;
namespace CarBookingApplicationProject.Configurations.Entities
{
   
        public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
        {
            public void Configure(EntityTypeBuilder<UserProfile> builder)
            {
                builder.HasData(
                    new UserProfile
                    {
                        Id = 1, // Unique ID
                        DisplayName = "Jordan",
                        Email = "Jordan01239@gmail.com",
                        PhoneNumber = "97593043",
                        DateOfBirth = "05/03/2001",
                        Gender = "Male",
                        Address = "Jurong East",
                        CarLicense = "",
                        AcceptanceRate = "",
                        DrivingExperience = "",
                        FrequentLocations = "Jurong East, Clementi",
                        PreferredPickupTime = "Morning",
                        IsDriver = false,
                        IsPassenger = true,
                        
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new UserProfile
                    {
                        Id = 2, // Unique ID
                        DisplayName = "Jeff",
                        Email = "Jeff019231@gmail.com",
                        PhoneNumber = "93843943",
                        DateOfBirth = "22/10/2000",
                        Gender = "Male",
                        Address = "Jurong West",
                        CarLicense = "SGX1234A",
                        AcceptanceRate = "75.5%",
                        DrivingExperience = "2 years",
                        FrequentLocations = "Jurong West, Pioneer",
                        PreferredPickupTime = "Morning",
                        IsDriver = true,
                        IsPassenger = false,
                        
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                );
            }
        }
    }
