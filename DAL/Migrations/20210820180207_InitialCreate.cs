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
                name: "ObjAboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjAboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Coordinate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjAndulasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "getDate()"),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjAndulasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objAppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                name: "ObjComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InstagramAccount = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjFaqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjFaqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjFaxNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjFaxNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "objMails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objMails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjOnlineDiet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfMeals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteFoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HateFoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllergicFoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyNutrition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthProblem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseMedicine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferencePerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharePhotos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjOnlineDiet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjOnlineDietFaqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjOnlineDietFaqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjOnlineDietInformationLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjOnlineDietInformationLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjPhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjPhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjPricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjPricings", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "getDate()"),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                    IconCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objSocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjWeakened",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjWeakened", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjWorkingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Morning = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Afternoon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "getDate()"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ObjCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objBlogs_objCategories_ObjCategoryId",
                        column: x => x.ObjCategoryId,
                        principalTable: "objCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition", "Status" },
                values: new object[] { 1, "SuperAdmin", false });

            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition", "Status" },
                values: new object[] { 2, "Admin", false });

            migrationBuilder.InsertData(
                table: "objAppRoles",
                columns: new[] { "Id", "Definition", "Status" },
                values: new object[] { 3, "Member", false });

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
                name: "IX_objBlogs_ObjCategoryId",
                table: "objBlogs",
                column: "ObjCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogAppUsers");

            migrationBuilder.DropTable(
                name: "ObjAboutUs");

            migrationBuilder.DropTable(
                name: "objAddresses");

            migrationBuilder.DropTable(
                name: "ObjAndulasyons");

            migrationBuilder.DropTable(
                name: "objAppUserRoles");

            migrationBuilder.DropTable(
                name: "ObjComments");

            migrationBuilder.DropTable(
                name: "ObjFaqs");

            migrationBuilder.DropTable(
                name: "ObjFaxNumbers");

            migrationBuilder.DropTable(
                name: "objMails");

            migrationBuilder.DropTable(
                name: "ObjOnlineDiet");

            migrationBuilder.DropTable(
                name: "ObjOnlineDietFaqs");

            migrationBuilder.DropTable(
                name: "ObjOnlineDietInformationLists");

            migrationBuilder.DropTable(
                name: "ObjPhoneNumbers");

            migrationBuilder.DropTable(
                name: "ObjPricings");

            migrationBuilder.DropTable(
                name: "objProvidedServices");

            migrationBuilder.DropTable(
                name: "objSocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "ObjWeakened");

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
                name: "objCategories");
        }
    }
}
