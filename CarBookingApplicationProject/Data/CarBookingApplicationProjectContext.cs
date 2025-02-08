using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBookingApplicationProject.Domain;

namespace CarBookingApplicationProject.Data
{
    public class CarBookingApplicationProjectContext : DbContext
    {
        public CarBookingApplicationProjectContext (DbContextOptions<CarBookingApplicationProjectContext> options)
            : base(options)
        {
        }
        public DbSet<CarBookingApplicationProject.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Promotion> Promotion { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Ride> Ride { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.UserProfile> UserProfile { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Vehicle> Vehicle { get; set; } = default!;

        
    }
}
