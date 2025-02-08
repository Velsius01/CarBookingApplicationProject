using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookingApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6354), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6355), new DateTime(2025, 2, 6, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6361), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6361), new DateTime(2025, 2, 7, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6638), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6641), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6830), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6831), new DateTime(2025, 2, 8, 16, 5, 47, 880, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 2, 8, 16, 25, 47, 880, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6957), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6957), new DateTime(2025, 2, 28, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 1, 29, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6960), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6961), new DateTime(2025, 2, 23, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6960), new DateTime(2025, 2, 3, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7030), new DateTime(2025, 2, 8, 15, 35, 47, 880, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 2, 8, 14, 35, 47, 880, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7034), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 2, 8, 15, 35, 47, 880, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7107), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7179), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7183), new DateTime(2025, 2, 8, 16, 35, 47, 880, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3034), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3035), new DateTime(2025, 2, 6, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Feedback",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "FeedbackDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 2, 7, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 2, 8, 12, 45, 35, 202, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TransactionDateTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 2, 8, 13, 5, 35, 202, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 2, 28, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3272), new DateTime(2025, 1, 29, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Promotion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 2, 23, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 2, 3, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3325), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3326), new DateTime(2025, 2, 8, 12, 15, 35, 202, DateTimeKind.Local).AddTicks(3323), new DateTime(2025, 2, 8, 11, 15, 35, 202, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Ride",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "DropoffTime", "PickupTime" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3328), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3329), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3327), new DateTime(2025, 2, 8, 12, 15, 35, 202, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3379), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3382), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3427), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3430), new DateTime(2025, 2, 8, 13, 15, 35, 202, DateTimeKind.Local).AddTicks(3430) });
        }
    }
}
