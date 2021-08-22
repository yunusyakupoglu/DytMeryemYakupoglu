using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProvidedServiceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "objProvidedServices");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "objProvidedServices");

            migrationBuilder.AddColumn<string>(
                name: "IconCode",
                table: "objProvidedServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconCode",
                table: "objProvidedServices");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "objProvidedServices",
                type: "Date",
                nullable: false,
                defaultValueSql: "getDate()");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "objProvidedServices",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
