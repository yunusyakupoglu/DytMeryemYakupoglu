using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogAppUserStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogAppUserStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Coordinate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objAppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objAppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objMails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objMails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objNumberCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objNumberCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objProvidedServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objProvidedServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objSocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IconCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objSocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjWorkingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Morning = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Afternoon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjWorkingHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objAppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objAppUserRoles_objAppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "objAppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_objAppUserRoles_objAppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "objAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "objBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objBlogs_objCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "objCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "objNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumberCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objNumbers_objNumberCategories_NumberCategoryId",
                        column: x => x.NumberCategoryId,
                        principalTable: "objNumberCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogAppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    ObjBlogId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    ObjAppUserId = table.Column<int>(type: "int", nullable: true),
                    BlogAppUserStatusId = table.Column<int>(type: "int", nullable: false),
                    ObjBlogAppUserStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogAppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogAppUsers_blogAppUserStatuses_ObjBlogAppUserStatusId",
                        column: x => x.ObjBlogAppUserStatusId,
                        principalTable: "blogAppUserStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_blogAppUsers_objAppUsers_ObjAppUserId",
                        column: x => x.ObjAppUserId,
                        principalTable: "objAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_blogAppUsers_objBlogs_ObjBlogId",
                        column: x => x.ObjBlogId,
                        principalTable: "objBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogAppUsers_ObjAppUserId",
                table: "blogAppUsers",
                column: "ObjAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_blogAppUsers_ObjBlogAppUserStatusId",
                table: "blogAppUsers",
                column: "ObjBlogAppUserStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_blogAppUsers_ObjBlogId",
                table: "blogAppUsers",
                column: "ObjBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_objAppUserRoles_AppRoleId_AppUserId",
                table: "objAppUserRoles",
                columns: new[] { "AppRoleId", "AppUserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_objAppUserRoles_AppUserId",
                table: "objAppUserRoles",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_objBlogs_CategoryId",
                table: "objBlogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_objNumbers_NumberCategoryId",
                table: "objNumbers",
                column: "NumberCategoryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogAppUsers");

            migrationBuilder.DropTable(
                name: "objAddresses");

            migrationBuilder.DropTable(
                name: "objAppUserRoles");

            migrationBuilder.DropTable(
                name: "objMails");

            migrationBuilder.DropTable(
                name: "objNumbers");

            migrationBuilder.DropTable(
                name: "objProvidedServices");

            migrationBuilder.DropTable(
                name: "objSocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "ObjWorkingHours");

            migrationBuilder.DropTable(
                name: "blogAppUserStatuses");

            migrationBuilder.DropTable(
                name: "objBlogs");

            migrationBuilder.DropTable(
                name: "objAppRoles");

            migrationBuilder.DropTable(
                name: "objAppUsers");

            migrationBuilder.DropTable(
                name: "objNumberCategories");

            migrationBuilder.DropTable(
                name: "objCategories");
        }
    }
}
