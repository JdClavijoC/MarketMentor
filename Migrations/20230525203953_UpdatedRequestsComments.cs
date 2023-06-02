using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketMentor.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestsComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d596ae-2649-469d-8c59-9e57ec38cf08", "AQAAAAIAAYagAAAAEEDrMtxPz6sxic+TEPM97nrjAKz7QIPPx1klb9MxO97Xq2HaNkD1eeLOqPNoXtk2NA==", "d2b5e23a-52db-4294-b8ed-172b8268a5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a8e37a8-d6a4-4e10-a775-38ac505cb084", "AQAAAAIAAYagAAAAEE8lAR/hcCTcm/9V+XlEUPJlxsGj21L8YdjhicuzEqIk3t8zIIjRaYg3d0jRJChsOw==", "8e7fd370-5005-478b-b8da-4718bee436a9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f63707-30f8-47f0-af90-e96561934ff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78945919-345c-41d9-86d9-6c0e29db9227", "AQAAAAIAAYagAAAAEOAZaVcRgW0nTVYDs54zVuCZE3txGDBPAqbYbqDGuA7uukjtP/G8uyeLPgfFJYec4A==", "e961ebb2-30db-4c56-9af1-6434f84420ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67e26e4c-409b-4abc-81dd-d24d0255626e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b894ee-5e99-4062-acff-9d5c278c2b12", "AQAAAAIAAYagAAAAEBac7d8GD3VcZR3cXekR7RhPsCblHbCILPxgCOMcEobSOJMQzp8fBnY2i4hvJoxAEQ==", "f2b5c3fa-0434-4fb0-8d69-21bacb69b5fc" });
        }
    }
}
