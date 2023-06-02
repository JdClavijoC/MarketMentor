using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketMentor.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c7bd218-21c0-4540-a722-0108a249cffe", "AQAAAAIAAYagAAAAEBBA7WjqoAgDhJSfVZ9qysPrYb+dDDwOkVKISon35wNYAdgCB5oiQCYMghlNAF5USw==", "9e73879b-f75e-4f3b-bbbd-5ba38a3a97f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c775aa2-fd97-4509-96f8-54af8ccbf399", "AQAAAAIAAYagAAAAEKMi6RxyHu9VixTs/b4xoOSt8ZnjGNItzJrd1ijDTLYQSrNOhxc3dtRaojgpBB9unw==", "71218db0-0fb0-4d13-8a49-31b1f57549e9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63de1c26-2175-4770-975b-3753c441f9c8", "AQAAAAIAAYagAAAAECNgIrkfqou7YRcYnhmo0c2Nd5UkVEQvPbaP//yFybcFtoQA/tslfxvuhi4J2ZX4Iw==", "92a7ab73-f74e-48c7-b9a8-136bfd1435fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e713874-ae22-4ab2-92b1-d1fc1e976549", "AQAAAAIAAYagAAAAEEqJBtxeWaMvO28OpjVheIOSsLnSSLmZkJSnl4uqKwyMcWJjQAUro5hv6ezUhtw8qA==", "2618d652-a6ac-4f29-91aa-8b9e5756fb34" });
        }
    }
}
