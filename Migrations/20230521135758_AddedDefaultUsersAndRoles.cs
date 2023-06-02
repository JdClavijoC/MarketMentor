using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketMentor.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67e26e4c-409b-4abc-82cd-d24d0255626e", null, "Administrator", "ADMINISTRATOR" },
                    { "67e26e4c-459bc-4abc-81dd-d24d0255626", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02f63707-30f8-47f0-af90-e96561934ff1", 0, "95326112-e4d0-4aba-8a7b-7fbaf9ebdea0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdclavijoc@ufpso.edu.co", false, "Jesus David", "Clavijo Cardenas", false, null, "JDCLAVIJOC@UFPSO.EDU.CO", null, "AQAAAAIAAYagAAAAEPYw69/cewYQkH8QVusjU/2VGK76M/6HB2nb/qfGmlehL+apTSMfw4V3PT2LlAC1mA==", null, false, "c5a94757-18e4-4cc7-aaa5-554067374b96", null, false, null },
                    { "67e26e4c-409b-4abc-81dd-d24d0255626e", 0, "cc1892d5-2c05-45cd-8856-2e28cf8a862b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jaclagar1234@gmail.com", false, "Jesus", "David", false, null, "JACLAGAR1234@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFqjukdvV/QRR2lE4dEcW0bdFeT0Ky/KeemcV4ecvZT76Ce5H9E0wV+aRZnc/TgeJg==", null, false, "f78d3274-d8fd-4f38-8d44-b8390375c1f8", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "67e26e4c-409b-4abc-82cd-d24d0255626e", "02f63707-30f8-47f0-af90-e96561934ff1" },
                    { "67e26e4c-459bc-4abc-81dd-d24d0255626", "67e26e4c-409b-4abc-81dd-d24d0255626e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67e26e4c-409b-4abc-82cd-d24d0255626e", "02f63707-30f8-47f0-af90-e96561934ff1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67e26e4c-459bc-4abc-81dd-d24d0255626", "67e26e4c-409b-4abc-81dd-d24d0255626e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-82cd-d24d0255626e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67e26e4c-459bc-4abc-81dd-d24d0255626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e");
        }
    }
}
