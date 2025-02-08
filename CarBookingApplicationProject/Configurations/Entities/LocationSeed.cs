using Microsoft.EntityFrameworkCore;
using CarBookingApplicationProject.Domain;
namespace CarBookingApplicationProject.Configurations.Entities
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = 1,
                    Longitude = 103.851959m,
                    Latitude = 1.290270m,
                    Address = "Marina Bay Sands, 10 Bayfront Ave",
                    City = "Singapore",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Location
                {
                    Id = 2,
                    Longitude = 103.819836m,
                    Latitude = 1.352083m,
                    Address = "Sentosa Island",
                    City = "Singapore",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
