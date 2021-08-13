using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition" },
                values: new object[] { 2, "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "objAppRoles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
