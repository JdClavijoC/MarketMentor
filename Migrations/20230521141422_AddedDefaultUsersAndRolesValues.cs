using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketMentor.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRolesValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63de1c26-2175-4770-975b-3753c441f9c8", "JDCLAVIJOC@UFPSO.EDU.CO", "AQAAAAIAAYagAAAAECNgIrkfqou7YRcYnhmo0c2Nd5UkVEQvPbaP//yFybcFtoQA/tslfxvuhi4J2ZX4Iw==", "92a7ab73-f74e-48c7-b9a8-136bfd1435fe", "jdclavijoc@ufpso.edu.co" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0e713874-ae22-4ab2-92b1-d1fc1e976549", "JACLAGAR1234@GMAIL.COM", "AQAAAAIAAYagAAAAEEqJBtxeWaMvO28OpjVheIOSsLnSSLmZkJSnl4uqKwyMcWJjQAUro5hv6ezUhtw8qA==", "2618d652-a6ac-4f29-91aa-8b9e5756fb34", "jaclagar1234@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "95326112-e4d0-4aba-8a7b-7fbaf9ebdea0", null, "AQAAAAIAAYagAAAAEPYw69/cewYQkH8QVusjU/2VGK76M/6HB2nb/qfGmlehL+apTSMfw4V3PT2LlAC1mA==", "c5a94757-18e4-4cc7-aaa5-554067374b96", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc1892d5-2c05-45cd-8856-2e28cf8a862b", null, "AQAAAAIAAYagAAAAEFqjukdvV/QRR2lE4dEcW0bdFeT0Ky/KeemcV4ecvZT76Ce5H9E0wV+aRZnc/TgeJg==", "f78d3274-d8fd-4f38-8d44-b8390375c1f8", null });
        }
    }
}
