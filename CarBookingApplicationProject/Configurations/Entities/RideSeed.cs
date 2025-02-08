using CarBookingApplicationProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarBookingApplicationProject.Configurations.Entities
{
    public class RideSeed : IEntityTypeConfiguration<Ride>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ride> builder)
        {
            builder.HasData(
                new Ride
                {
                    Id = 1,
                    PickupTime = DateTime.Now.AddHours(-2), // 2 hours ago
                    DropoffTime = DateTime.Now.AddHours(-1), // 1 hour ago
                    RideStatus = "Completed",
                    RideCost = 25.50m,
                    UserId = 1,
                    LocationId = 1,
                    PromotionId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Ride
                {
                    Id = 2,
                    PickupTime = DateTime.Now.AddHours(-1), // 1 hour ago
                    DropoffTime = DateTime.Now, // Current time
                    RideStatus = "Ongoing",
                    RideCost = 30.00m,
                    UserId = 2,
                    LocationId = 2,
                    PromotionId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
