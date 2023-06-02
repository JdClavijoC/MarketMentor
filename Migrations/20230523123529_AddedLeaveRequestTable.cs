using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketMentor.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
