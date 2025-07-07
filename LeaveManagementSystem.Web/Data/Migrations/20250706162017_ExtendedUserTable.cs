using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ac873d-99e4-4f23-86d7-f2bbf18d18ae",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54beb98c-1e12-4cb2-b9a0-85437dc586b9", new DateOnly(1978, 10, 27), "Default", "Default", "AQAAAAIAAYagAAAAEA9y/C+yE0ZgNzWxtSpuGFSLEK9iCHBxEC9GJCj4zveB5DnkGkCPBqNCIaxtovfCmg==", "cb9c6e27-5772-4ce2-8d7e-995bac3c02e1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ac873d-99e4-4f23-86d7-f2bbf18d18ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d82c161-5995-44a8-acb9-a47e24fe04a5", "AQAAAAIAAYagAAAAEG+K4hAmNKtT35+2s0fM5rbYDpGGghX91kGNqj4vNlrwJ1lHAcifnkHBuy31uWcVEQ==", "5c7fb60c-b43a-4b44-abfb-9fe5d8ef43dc" });
        }
    }
}
