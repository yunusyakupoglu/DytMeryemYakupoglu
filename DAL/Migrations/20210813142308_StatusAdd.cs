using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class StatusAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ObjWorkingHours",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objSocialMediaAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objProvidedServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objNumbers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objMails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objAppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objAppRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "objAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ObjWorkingHours");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objSocialMediaAccounts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objProvidedServices");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objNumbers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objMails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objAppUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objAppRoles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "objAddresses");
        }
    }
}
