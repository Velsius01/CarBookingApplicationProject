using CarBookingApplicationProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarBookingApplicationProject.Configurations.Entities
{
    public class VehicleSeed : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    LicensePlate = "MBX3829B",
                    Model = "Corolla",
                    Manufacturer = "Toyota",
                    Year = 2020,
                    Status = "Active",
                    MaximumPassengers = 4,
                    UserId = null, // Vehicle not assigned to a user
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Vehicle
                {
                    Id = 2,
                    LicensePlate = "JKX8273C",
                    Model = "Civic",
                    Manufacturer = "Honda",
                    Year = 2017,
                    Status = "Active",
                    MaximumPassengers = 4,
                    UserId = 2, // Assigned to User with ID 2 (Driver)
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
        );
        }
    }
}
