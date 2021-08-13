using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Migrations
{
    public partial class Initialcreate : Migration
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
                    { 1, "Content from activity 1", new DateTime(2021, 8, 13, 13, 58, 17, 477, DateTimeKind.Local).AddTicks(6238), "ImageActivities1.jpg", false, "Activity 1" },
                    { 2, "Content from activity 2", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4286), "ImageActivities2.jpg", false, "Activity 2" },
                    { 3, "Content from activity 3", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4512), "ImageActivities3.jpg", false, "Activity 3" },
                    { 4, "Content from activity 4", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4539), "ImageActivities4.jpg", false, "Activity 4" },
                    { 5, "Content from activity 5", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4561), "ImageActivities5.jpg", false, "Activity 5" },
                    { 6, "Content from activity 6", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4591), "ImageActivities6.jpg", false, "Activity 6" },
                    { 7, "Content from activity 7", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4612), "ImageActivities7.jpg", false, "Activity 7" },
                    { 8, "Content from activity 8", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4632), "ImageActivities8.jpg", false, "Activity 8" },
                    { 9, "Content from activity 9", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4795), "ImageActivities9.jpg", false, "Activity 9" },
                    { 10, "Content from activity 10", new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4825), "ImageActivities10.jpg", false, "Activity 10" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9600), "Descripcion 10Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories10.jpg", false, "name 10" },
                    { 9, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9555), "Descripcion 9Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories9.jpg", false, "name 9" },
                    { 8, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9535), "Descripcion 8Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories8.jpg", false, "name 8" },
                    { 6, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9492), "Descripcion 6Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories6.jpg", false, "name 6" },
                    { 7, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9514), "Descripcion 7Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories7.jpg", false, "name 7" },
                    { 4, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9440), "Descripcion 4Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories4.jpg", false, "name 4" },
                    { 3, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9339), "Descripcion 3Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories3.jpg", false, "name 3" },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9307), "Descripcion 2Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories2.jpg", false, "name 2" },
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9089), "Descripcion 1Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories1.jpg", false, "name 1" },
                    { 5, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9467), "Descripcion 5Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories5.jpg", false, "name 5" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedAt", "IsDeleted", "User_id", "post_id" },
                values: new object[,]
                {
                    { 18, "body of post_id=6", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3279), false, 6, 6 },
                    { 19, "body of post_id=7", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3299), false, 7, 7 },
                    { 20, "body of post_id=7", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3318), false, 7, 7 },
                    { 21, "body of post_id=7", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3336), false, 7, 7 },
                    { 22, "body of post_id=8", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3355), false, 8, 8 },
                    { 23, "body of post_id=8", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3374), false, 8, 8 },
                    { 25, "body of post_id=9", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3412), false, 9, 9 },
                    { 26, "body of post_id=9", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3430), false, 9, 9 },
                    { 28, "body of post_id=10", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3470), false, 10, 10 },
                    { 29, "body of post_id=10", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3489), false, 10, 10 },
                    { 30, "body of post_id=10", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3508), false, 10, 10 },
                    { 17, "body of post_id=6", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3258), false, 6, 6 },
                    { 24, "body of post_id=8", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3393), false, 8, 8 },
                    { 16, "body of post_id=6", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3233), false, 6, 6 },
                    { 27, "body of post_id=9", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3450), false, 9, 9 },
                    { 14, "body of post_id=5", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3112), false, 5, 5 },
                    { 15, "body of post_id=5", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3130), false, 5, 5 },
                    { 2, "body of post_id=1", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2859), false, 1, 1 },
                    { 3, "body of post_id=1", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2888), false, 1, 1 },
                    { 4, "body of post_id=2", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2909), false, 2, 2 },
                    { 5, "body of post_id=2", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2929), false, 2, 2 },
                    { 6, "body of post_id=2", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2954), false, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedAt", "IsDeleted", "User_id", "post_id" },
                values: new object[,]
                {
                    { 1, "body of post_id=1", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2641), false, 1, 1 },
                    { 8, "body of post_id=3", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2994), false, 3, 3 },
                    { 9, "body of post_id=3", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3013), false, 3, 3 },
                    { 10, "body of post_id=4", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3034), false, 4, 4 },
                    { 11, "body of post_id=4", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3053), false, 4, 4 },
                    { 12, "body of post_id=4", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3073), false, 4, 4 },
                    { 13, "body of post_id=5", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3092), false, 5, 5 },
                    { 7, "body of post_id=3", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2975), false, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "Message", "Name", "Phone" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3698), "email10gmail.com", false, "Message Message Message Message10", "Contact 10", 16605473 },
                    { 9, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3674), "email9gmail.com", false, "Message Message Message Message9", "Contact 9", 23867933 },
                    { 8, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3653), "email8gmail.com", false, "Message Message Message Message8", "Contact 8", 42721509 },
                    { 7, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3633), "email7gmail.com", false, "Message Message Message Message7", "Contact 7", 42460468 },
                    { 6, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3612), "email6gmail.com", false, "Message Message Message Message6", "Contact 6", 85024485 },
                    { 4, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3562), "email4gmail.com", false, "Message Message Message Message4", "Contact 4", 67923064 },
                    { 3, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3408), "email3gmail.com", false, "Message Message Message Message3", "Contact 3", 40899064 },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3376), "email2gmail.com", false, "Message Message Message Message2", "Contact 2", 34458897 },
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3136), "email1gmail.com", false, "Message Message Message Message1", "Contact 1", 30938102 },
                    { 5, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3586), "email5gmail.com", false, "Message Message Message Message5", "Contact 5", 77967949 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "CreatedAt", "Description", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4877), "Descripcion10Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member10", "imageMembers10.jpg", "https://instagram/member10", false, "https://Linkedin/member10", "name10" },
                    { 9, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4851), "Descripcion9Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member9", "imageMembers9.jpg", "https://instagram/member9", false, "https://Linkedin/member9", "name9" },
                    { 8, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4829), "Descripcion8Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member8", "imageMembers8.jpg", "https://instagram/member8", false, "https://Linkedin/member8", "name8" },
                    { 7, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4803), "Descripcion7Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member7", "imageMembers7.jpg", "https://instagram/member7", false, "https://Linkedin/member7", "name7" },
                    { 6, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4705), "Descripcion6Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member6", "imageMembers6.jpg", "https://instagram/member6", false, "https://Linkedin/member6", "name6" },
                    { 4, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4655), "Descripcion4Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member4", "imageMembers4.jpg", "https://instagram/member4", false, "https://Linkedin/member4", "name4" },
                    { 3, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4629), "Descripcion3Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member3", "imageMembers3.jpg", "https://instagram/member3", false, "https://Linkedin/member3", "name3" },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4595), "Descripcion2Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member2", "imageMembers2.jpg", "https://instagram/member2", false, "https://Linkedin/member2", "name2" },
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4364), "Descripcion1Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member1", "imageMembers1.jpg", "https://instagram/member1", false, "https://Linkedin/member1", "name1" },
                    { 5, new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4679), "Descripcion5Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member5", "imageMembers5.jpg", "https://instagram/member5", false, "https://Linkedin/member5", "name5" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "AboutUsText", "Adress", "CreatedAt", "Email", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name", "Phone", "WelcomeText" },
                values: new object[] { 1, "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Catamarca 1585 , CP: 1585", new DateTime(2021, 8, 13, 13, 58, 17, 504, DateTimeKind.Local).AddTicks(1803), "somomasong@gmail.com", "https://facebook.com/organization", "imageOrganization.jpg", null, false, null, "Somos Más", 1128559685, "Bienvenidos a nuestro sitio web" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 483, DateTimeKind.Local).AddTicks(1472), "Admin User", false, "Admin" },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 483, DateTimeKind.Local).AddTicks(1748), "Standard User", false, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsDeleted", "Order", "OrganizationId", "Text" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8699), "imagenSlides10.jpg", false, 10, "10", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 9, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8675), "imagenSlides9.jpg", false, 9, "9", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 8, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8649), "imagenSlides8.jpg", false, 8, "8", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 6, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8531), "imagenSlides6.jpg", false, 6, "6", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 7, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8550), "imagenSlides7.jpg", false, 7, "7", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 4, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8486), "imagenSlides4.jpg", false, 4, "4", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 3, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8464), "imagenSlides3.jpg", false, 3, "3", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8433), "imagenSlides2.jpg", false, 2, "2", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8104), "imagenSlides1.jpg", false, 1, "1", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 5, new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8506), "imagenSlides5.jpg", false, 5, "5", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[] { 9, "Content9Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8465), "imageTestimonials9.jpg", false, "name 9" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Content1Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8003), "imageTestimonials1.jpg", false, "name 1" },
                    { 2, "Content2Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8300), "imageTestimonials2.jpg", false, "name 2" },
                    { 3, "Content3Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8333), "imageTestimonials3.jpg", false, "name 3" },
                    { 4, "Content4Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8356), "imageTestimonials4.jpg", false, "name 4" },
                    { 5, "Content5Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8378), "imageTestimonials5.jpg", false, "name 5" },
                    { 6, "Content6Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8402), "imageTestimonials6.jpg", false, "name 6" },
                    { 7, "Content7Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8424), "imageTestimonials7.jpg", false, "name 7" },
                    { 8, "Content8Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8444), "imageTestimonials8.jpg", false, "name 8" },
                    { 10, "Content10Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8555), "imageTestimonials10.jpg", false, "name 10" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Content 1 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(5682), "imageNews1.jpg", false, "new's name " },
                    { 10, 10, "Content 10 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6196), "imageNews10.jpg", false, "new's name " },
                    { 9, 9, "Content 9 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6170), "imageNews9.jpg", false, "new's name " },
                    { 7, 7, "Content 7 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6126), "imageNews7.jpg", false, "new's name " },
                    { 6, 6, "Content 6 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6104), "imageNews6.jpg", false, "new's name " },
                    { 5, 5, "Content 5 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6079), "imageNews5.jpg", false, "new's name " },
                    { 4, 4, "Content 4 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6056), "imageNews4.jpg", false, "new's name " },
                    { 8, 8, "Content 8 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6148), "imageNews8.jpg", false, "new's name " },
                    { 15, 2, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6396), "imageNews15.jpg", false, "new's name " },
                    { 12, 2, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6243), "imageNews12.jpg", false, "new's name " },
                    { 2, 2, "Content 2 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(5921), "imageNews2.jpg", false, "new's name " },
                    { 14, 1, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6368), "imageNews14.jpg", false, "new's name " },
                    { 11, 1, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6220), "imageNews11.jpg", false, "new's name " },
                    { 3, 3, "Content 3 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6027), "imageNews3.jpg", false, "new's name " }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "email", "firstName", "lastName", "password", "photo", "roleId" },
                values: new object[,]
                {
                    { 11, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5938), false, "mail11@Mail.com", "User 11", "RegularUser 11", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers11.jpg", 2 },
                    { 18, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6604), false, "mail18@Mail.com", "User 18", "RegularUser 18", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers18.jpg", 2 },
                    { 17, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6452), false, "mail17@Mail.com", "User 17", "RegularUser 17", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers17.jpg", 2 },
                    { 16, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6388), false, "mail16@Mail.com", "User 16", "RegularUser 16", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers16.jpg", 2 },
                    { 15, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6322), false, "mail15@Mail.com", "User 15", "RegularUser 15", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers15.jpg", 2 },
                    { 14, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6197), false, "mail14@Mail.com", "User 14", "RegularUser 14", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers14.jpg", 2 },
                    { 13, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6134), false, "mail13@Mail.com", "User 13", "RegularUser 13", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers13.jpg", 2 },
                    { 12, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6066), false, "mail12@Mail.com", "User 12", "RegularUser 12", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers12.jpg", 2 },
                    { 10, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5871), false, "mail10@Mail.com", "User 10", "AdminUser 10", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers10.jpg", 1 },
                    { 3, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5234), false, "mail3@Mail.com", "User 3", "AdminUser 3", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers3.jpg", 1 },
                    { 8, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5670), false, "mail8@Mail.com", "User 8", "AdminUser 8", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers8.jpg", 1 },
                    { 7, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5606), false, "mail7@Mail.com", "User 7", "AdminUser 7", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers7.jpg", 1 },
                    { 6, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5540), false, "mail6@Mail.com", "User 6", "AdminUser 6", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers6.jpg", 1 },
                    { 5, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5373), false, "mail5@Mail.com", "User 5", "AdminUser 5", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers5.jpg", 1 },
                    { 4, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5308), false, "mail4@Mail.com", "User 4", "AdminUser 4", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers4.jpg", 1 },
                    { 19, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6672), false, "mail19@Mail.com", "User 19", "RegularUser 19", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers19.jpg", 2 },
                    { 2, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5103), false, "mail2@Mail.com", "User 2", "AdminUser 2", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers2.jpg", 1 },
                    { 1, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(4015), false, "mail1@Mail.com", "User 1", "AdminUser 1", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers1.jpg", 1 },
                    { 9, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5798), false, "mail9@Mail.com", "User 9", "AdminUser 9", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "TestUsers9.jpg", 1 },
                    { 20, new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6735), false, "mail20@Mail.com", "User 20", "RegularUser 20", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "TestUsers20.jpg", 2 }
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
