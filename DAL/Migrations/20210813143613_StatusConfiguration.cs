using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class StatusConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Definition",
                value: "SuperAdmin");

            migrationBuilder.UpdateData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Definition",
                value: "Admin");

            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition", "Status" },
                values: new object[] { 3, "Member", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Definition",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Definition",
                value: "Member");
        }
    }
}
