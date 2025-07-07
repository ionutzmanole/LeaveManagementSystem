using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRoleandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a5f0781-baae-430c-bb39-bccf190a2c8c", null, "Employee", "EMPLOYEE" },
                    { "8fe0b8af-b76d-45f9-94b9-c3b7d43b02e9", null, "Supervisor", "SUPERVISOR" },
                    { "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "04ac873d-99e4-4f23-86d7-f2bbf18d18ae", 0, "6d82c161-5995-44a8-acb9-a47e24fe04a5", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEG+K4hAmNKtT35+2s0fM5rbYDpGGghX91kGNqj4vNlrwJ1lHAcifnkHBuy31uWcVEQ==", null, false, "5c7fb60c-b43a-4b44-abfb-9fe5d8ef43dc", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe", "04ac873d-99e4-4f23-86d7-f2bbf18d18ae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a5f0781-baae-430c-bb39-bccf190a2c8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fe0b8af-b76d-45f9-94b9-c3b7d43b02e9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe", "04ac873d-99e4-4f23-86d7-f2bbf18d18ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ac873d-99e4-4f23-86d7-f2bbf18d18ae");
        }
    }
}
