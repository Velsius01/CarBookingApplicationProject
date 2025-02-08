using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBookingApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaximumPassengers",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Location",
                type: "decimal(10,6)",
                precision: 10,
                scale: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Location",
                type: "decimal(10,6)",
                precision: 10,
                scale: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptanceRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrequentLocations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredPickupTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDriver = table.Column<bool>(type: "bit", nullable: false),
                    IsPassenger = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "Comments", "CreatedBy", "DateCreated", "DateUpdated", "FeedbackDateTime", "Rating", "RideId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Great ride! The driver was very professional.", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3034), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3035), new DateTime(2025, 2, 6, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3020), 5, 1, "System", 1 },
                    { 2, "The ride was okay, but the car was a bit dirty.", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 2, 7, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3037), 3, 2, "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "City", "CreatedBy", "DateCreated", "DateUpdated", "Latitude", "Longitude", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Marina Bay Sands, 10 Bayfront Ave", "Singapore", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3168), 1.290270m, 103.851959m, "System" },
                    { 2, "Sentosa Island", "Singapore", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3171), 1.352083m, 103.819836m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "AmountPaid", "CreatedBy", "DateCreated", "DateUpdated", "PaymentStatus", "PaymentType", "RideId", "TransactionDateTime", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 25.50m, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3223), "Completed", "Credit Card", 1, new DateTime(2025, 2, 8, 12, 45, 35, 202, DateTimeKind.Local).AddTicks(3221), "System", 1 },
                    { 2, 30.00m, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3226), "Pending", "Cash", 2, new DateTime(2025, 2, 8, 13, 5, 35, 202, DateTimeKind.Local).AddTicks(3225), "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DiscountAmount", "EndDate", "PromotionCode", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3273), 10.00m, new DateTime(2025, 2, 28, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3272), "SAVE10", new DateTime(2025, 1, 29, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3271), "System" },
                    { 2, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3276), 20.00m, new DateTime(2025, 2, 23, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3275), "WELCOME20", new DateTime(2025, 2, 3, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3275), "System" }
                });

            migrationBuilder.InsertData(
                table: "Ride",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DropoffTime", "LocationId", "PickupTime", "PromotionId", "RideCost", "RideStatus", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3325), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3326), new DateTime(2025, 2, 8, 12, 15, 35, 202, DateTimeKind.Local).AddTicks(3323), 1, new DateTime(2025, 2, 8, 11, 15, 35, 202, DateTimeKind.Local).AddTicks(3323), 1, 25.50m, "Completed", "System", 1 },
                    { 2, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3328), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3329), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3327), 2, new DateTime(2025, 2, 8, 12, 15, 35, 202, DateTimeKind.Local).AddTicks(3327), 2, 30.00m, "Ongoing", "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "AcceptanceRate", "Address", "CarLicense", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DisplayName", "DrivingExperience", "Email", "FrequentLocations", "Gender", "IsDriver", "IsPassenger", "PhoneNumber", "PreferredPickupTime", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", "Jurong East", "", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3379), "05/03/2001", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3379), "Jordan", "", "Jordan01239@gmail.com", "Jurong East, Clementi", "Male", false, true, "97593043", "Morning", "System" },
                    { 2, "75.5%", "Jurong West", "SGX1234A", "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3382), "22/10/2000", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3383), "Jeff", "2 years", "Jeff019231@gmail.com", "Jurong West, Pioneer", "Male", true, false, "93843943", "Morning", "System" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "LicensePlate", "Manufacturer", "MaximumPassengers", "Model", "Status", "UpdatedBy", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3427), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3428), "MBX3829B", "Toyota", 4, "Corolla", "Active", "System", null, 2020 },
                    { 2, "System", new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3430), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3430), "JKX8273C", "Honda", 4, "Civic", "Active", "System", 2, 2017 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaximumPassengers",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Location",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)",
                oldPrecision: 10,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Location",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)",
                oldPrecision: 10,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptanceRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrivingExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrequentLocations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredPickupTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }
    }
}
