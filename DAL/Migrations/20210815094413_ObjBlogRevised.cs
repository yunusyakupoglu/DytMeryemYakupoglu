using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ObjBlogRevised : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_objBlogs_objCategories_CategoryId",
                table: "objBlogs");

            migrationBuilder.DropIndex(
                name: "IX_objBlogs_CategoryId",
                table: "objBlogs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "objBlogs");

            migrationBuilder.AddColumn<int>(
                name: "ObjCategoryId",
                table: "objBlogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_objBlogs_ObjCategoryId",
                table: "objBlogs",
                column: "ObjCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_objBlogs_objCategories_ObjCategoryId",
                table: "objBlogs",
                column: "ObjCategoryId",
                principalTable: "objCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_objBlogs_objCategories_ObjCategoryId",
                table: "objBlogs");

            migrationBuilder.DropIndex(
                name: "IX_objBlogs_ObjCategoryId",
                table: "objBlogs");

            migrationBuilder.DropColumn(
                name: "ObjCategoryId",
                table: "objBlogs");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "objBlogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_objBlogs_CategoryId",
                table: "objBlogs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_objBlogs_objCategories_CategoryId",
                table: "objBlogs",
                column: "CategoryId",
                principalTable: "objCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
