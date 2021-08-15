using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class NumberInNumberCategoryUniqueChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_objNumbers_NumberCategoryId",
                table: "objNumbers");

            migrationBuilder.CreateIndex(
                name: "IX_objNumbers_NumberCategoryId",
                table: "objNumbers",
                column: "NumberCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_objNumbers_NumberCategoryId",
                table: "objNumbers");

            migrationBuilder.CreateIndex(
                name: "IX_objNumbers_NumberCategoryId",
                table: "objNumbers",
                column: "NumberCategoryId",
                unique: true);
        }
    }
}
