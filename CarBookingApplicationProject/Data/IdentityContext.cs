using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarBookingApplicationProject.Data;

namespace CarBookingApplicationProject.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CarBookingApplicationProjectUser>(options)
    {
    }
}
