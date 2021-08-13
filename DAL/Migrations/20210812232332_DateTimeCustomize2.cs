using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DateTimeCustomize2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "objProvidedServices",
                type: "Date",
                nullable: false,
                defaultValueSql: "getDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "objProvidedServices",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getDate()",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValueSql: "getDate()");
        }
    }
}
