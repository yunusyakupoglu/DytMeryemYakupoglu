using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class WeakenedMonthAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "ObjWeakened",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "ObjWeakened");
        }
    }
}
