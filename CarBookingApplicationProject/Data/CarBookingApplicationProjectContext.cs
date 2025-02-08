using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarBookingApplicationProject.Data;
using CarBookingApplicationProject.Configurations.Entities;
using CarBookingApplicationProject.Domain;
using Microsoft.AspNetCore.Identity;

namespace CarBookingApplicationProject.Data
{
    public class CarBookingApplicationProjectContext(DbContextOptions<CarBookingApplicationProjectContext> options) : IdentityDbContext<CarBookingApplicationProjectUser>(options)
    {
        public DbSet<CarBookingApplicationProject.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Promotion> Promotion { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Ride> Ride { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.UserProfile> UserProfile { get; set; } = default!;
        public DbSet<CarBookingApplicationProject.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensures Identity tables are set up correctly

            // Explicitly define composite primary key for IdentityUserLogin<string>
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });


            // Decimal precision settings

            modelBuilder.Entity<Location>()
                .Property(l => l.Latitude)
                .HasPrecision(10, 6); // Setting precision for distance values
            modelBuilder.Entity<Location>()
                .Property(l => l.Longitude)
                .HasPrecision(10, 6); // Setting precision for distance values

            modelBuilder.Entity<Payment>()
                .Property(p => p.AmountPaid)
                .HasPrecision(18, 2); // Setting precision for monetary values

            modelBuilder.Entity<Promotion>()
                .Property(pr => pr.DiscountAmount)
                .HasPrecision(18, 2); // Setting precision for monetary values

            modelBuilder.Entity<Ride>()
                .Property(r => r.RideCost)
                .HasPrecision(18, 2); // Setting precision for monetary values




            modelBuilder.ApplyConfiguration(new FeedbackSeed());
            modelBuilder.ApplyConfiguration(new LocationSeed());
            modelBuilder.ApplyConfiguration(new PaymentSeed());
            modelBuilder.ApplyConfiguration(new PromotionSeed());
            modelBuilder.ApplyConfiguration(new RideSeed());
            modelBuilder.ApplyConfiguration(new UserProfileSeed());
            modelBuilder.ApplyConfiguration(new VehicleSeed());





        }
        }
    }
