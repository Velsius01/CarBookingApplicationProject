using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBookingApplicationProject.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bfc0c-20db-474f-8407-5a6b1599518a", // Administrator RoleId
                    UserId = "3781efa7-66dc-4710-860f-e506d40102e4"  // Admin UserId
                }
            );
        }
    }
}
