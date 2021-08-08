using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class SecondSprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    post_id = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FacebookUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    WelcomeText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AboutUsText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65535, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 65535, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    photo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_roleId",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Content from activity 1", new DateTime(2021, 8, 5, 10, 28, 3, 514, DateTimeKind.Local).AddTicks(2749), "Image from activity 1", false, "Activity 1" },
                    { 2, "Content from activity 2", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(1891), "Image from activity 2", false, "Activity 2" },
                    { 3, "Content from activity 3", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2190), "Image from activity 3", false, "Activity 3" },
                    { 4, "Content from activity 4", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2233), "Image from activity 4", false, "Activity 4" },
                    { 5, "Content from activity 5", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2271), "Image from activity 5", false, "Activity 5" },
                    { 6, "Content from activity 6", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2319), "Image from activity 6", false, "Activity 6" },
                    { 7, "Content from activity 7", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2355), "Image from activity 7", false, "Activity 7" },
                    { 8, "Content from activity 8", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2390), "Image from activity 8", false, "Activity 8" },
                    { 9, "Content from activity 9", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2425), "Image from activity 9", false, "Activity 9" },
                    { 10, "Content from activity 10", new DateTime(2021, 8, 5, 10, 28, 3, 519, DateTimeKind.Local).AddTicks(2465), "Image from activity 10", false, "Activity 10" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 5, 10, 28, 3, 520, DateTimeKind.Local).AddTicks(236), "Admin User", false, "Admin" },
                    { 2, new DateTime(2021, 8, 5, 10, 28, 3, 520, DateTimeKind.Local).AddTicks(972), "Standard User", false, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "email", "firstName", "lastName", "password", "photo", "roleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(1364), false, "mail1@Mail.com", "User 1", "AdminUser 1", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 18, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3842), false, "mail18@Mail.com", "User 18", "RegularUser 18", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 17, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3765), false, "mail17@Mail.com", "User 17", "RegularUser 17", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 16, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3684), false, "mail16@Mail.com", "User 16", "RegularUser 16", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 15, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3636), false, "mail15@Mail.com", "User 15", "RegularUser 15", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 14, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3586), false, "mail14@Mail.com", "User 14", "RegularUser 14", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 13, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3533), false, "mail13@Mail.com", "User 13", "RegularUser 13", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 12, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3395), false, "mail12@Mail.com", "User 12", "RegularUser 12", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 11, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3345), false, "mail11@Mail.com", "User 11", "RegularUser 11", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 10, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3292), false, "mail10@Mail.com", "User 10", "AdminUser 10", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 9, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3210), false, "mail9@Mail.com", "User 9", "AdminUser 9", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 8, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3159), false, "mail8@Mail.com", "User 8", "AdminUser 8", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 7, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3104), false, "mail7@Mail.com", "User 7", "AdminUser 7", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 6, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3024), false, "mail6@Mail.com", "User 6", "AdminUser 6", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 5, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(2967), false, "mail5@Mail.com", "User 5", "AdminUser 5", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 4, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(2913), false, "mail4@Mail.com", "User 4", "AdminUser 4", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 3, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(2854), false, "mail3@Mail.com", "User 3", "AdminUser 3", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 2, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(2680), false, "mail2@Mail.com", "User 2", "AdminUser 2", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 19, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3892), false, "mail19@Mail.com", "User 19", "RegularUser 19", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 20, new DateTime(2021, 8, 5, 10, 28, 3, 526, DateTimeKind.Local).AddTicks(3973), false, "mail20@Mail.com", "User 20", "RegularUser 20", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleId",
                table: "Users",
                column: "roleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
