using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Data.Migrations
{
    public partial class DeleteCategory : Migration
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
                    { 1, "Content from activity 1", new DateTime(2021, 8, 9, 10, 48, 8, 78, DateTimeKind.Local).AddTicks(5734), "Image from activity 1", false, "Activity 1" },
                    { 2, "Content from activity 2", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7267), "Image from activity 2", false, "Activity 2" },
                    { 3, "Content from activity 3", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7449), "Image from activity 3", false, "Activity 3" },
                    { 4, "Content from activity 4", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7475), "Image from activity 4", false, "Activity 4" },
                    { 5, "Content from activity 5", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7498), "Image from activity 5", false, "Activity 5" },
                    { 6, "Content from activity 6", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7528), "Image from activity 6", false, "Activity 6" },
                    { 7, "Content from activity 7", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7548), "Image from activity 7", false, "Activity 7" },
                    { 8, "Content from activity 8", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7568), "Image from activity 8", false, "Activity 8" },
                    { 9, "Content from activity 9", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7588), "Image from activity 9", false, "Activity 9" },
                    { 10, "Content from activity 10", new DateTime(2021, 8, 9, 10, 48, 8, 84, DateTimeKind.Local).AddTicks(7611), "Image from activity 10", false, "Activity 10" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7772), "Descripcion 10Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 10", false, "name 10" },
                    { 9, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7695), "Descripcion 9Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 9", false, "name 9" },
                    { 7, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7591), "Descripcion 7Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 7", false, "name 7" },
                    { 6, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7509), "Descripcion 6Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 6", false, "name 6" },
                    { 8, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7661), "Descripcion 8Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 8", false, "name 8" },
                    { 4, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7417), "Descripcion 4Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 4", false, "name 4" },
                    { 3, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7353), "Descripcion 3Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 3", false, "name 3" },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7151), "Descripcion 2Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 2", false, "name 2" },
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(6738), "Descripcion 1Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 1", false, "name 1" },
                    { 5, new DateTime(2021, 8, 9, 10, 48, 8, 103, DateTimeKind.Local).AddTicks(7450), "Descripcion 5Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "image 5", false, "name 5" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedAt", "IsDeleted", "User_id", "post_id" },
                values: new object[,]
                {
                    { 18, "body of post_id=6", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2377), false, 6, 6 },
                    { 19, "body of post_id=7", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2398), false, 7, 7 },
                    { 20, "body of post_id=7", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2418), false, 7, 7 },
                    { 21, "body of post_id=7", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2439), false, 7, 7 },
                    { 22, "body of post_id=8", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2459), false, 8, 8 },
                    { 23, "body of post_id=8", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2479), false, 8, 8 },
                    { 26, "body of post_id=9", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2541), false, 9, 9 },
                    { 25, "body of post_id=9", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2521), false, 9, 9 },
                    { 27, "body of post_id=9", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2562), false, 9, 9 },
                    { 28, "body of post_id=10", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2584), false, 10, 10 },
                    { 29, "body of post_id=10", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2604), false, 10, 10 },
                    { 30, "body of post_id=10", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2624), false, 10, 10 },
                    { 17, "body of post_id=6", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2353), false, 6, 6 },
                    { 24, "body of post_id=8", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2500), false, 8, 8 },
                    { 16, "body of post_id=6", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2333), false, 6, 6 },
                    { 8, "body of post_id=3", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1854), false, 3, 3 },
                    { 14, "body of post_id=5", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2292), false, 5, 5 },
                    { 1, "body of post_id=1", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1463), false, 1, 1 },
                    { 2, "body of post_id=1", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1714), false, 1, 1 },
                    { 3, "body of post_id=1", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1745), false, 1, 1 },
                    { 4, "body of post_id=2", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1768), false, 2, 2 },
                    { 15, "body of post_id=5", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2312), false, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedAt", "IsDeleted", "User_id", "post_id" },
                values: new object[,]
                {
                    { 6, "body of post_id=2", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1813), false, 2, 2 },
                    { 5, "body of post_id=2", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1789), false, 2, 2 },
                    { 9, "body of post_id=3", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1874), false, 3, 3 },
                    { 10, "body of post_id=4", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1896), false, 4, 4 },
                    { 11, "body of post_id=4", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1916), false, 4, 4 },
                    { 12, "body of post_id=4", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2240), false, 4, 4 },
                    { 13, "body of post_id=5", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(2272), false, 5, 5 },
                    { 7, "body of post_id=3", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(1833), false, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "Message", "Name", "Phone" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2162), "email7gmail.com", false, "Message Message Message Message7", "Contact 7", 32762388 },
                    { 10, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2226), "email10gmail.com", false, "Message Message Message Message10", "Contact 10", 87717780 },
                    { 9, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2202), "email9gmail.com", false, "Message Message Message Message9", "Contact 9", 14536519 },
                    { 8, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2183), "email8gmail.com", false, "Message Message Message Message8", "Contact 8", 32675654 },
                    { 6, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2142), "email6gmail.com", false, "Message Message Message Message6", "Contact 6", 25783295 },
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(1683), "email1gmail.com", false, "Message Message Message Message1", "Contact 1", 27843668 },
                    { 4, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2094), "email4gmail.com", false, "Message Message Message Message4", "Contact 4", 51075563 },
                    { 3, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2071), "email3gmail.com", false, "Message Message Message Message3", "Contact 3", 24096475 },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(1989), "email2gmail.com", false, "Message Message Message Message2", "Contact 2", 14217134 },
                    { 5, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(2115), "email5gmail.com", false, "Message Message Message Message5", "Contact 5", 78199484 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "CreatedAt", "Description", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(9272), "Descripcion10Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member10", "image 10", "https://instagram/member10", false, "https://Linkedin/member10", "name10" },
                    { 9, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(9232), "Descripcion9Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member9", "image 9", "https://instagram/member9", false, "https://Linkedin/member9", "name9" },
                    { 8, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(9198), "Descripcion8Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member8", "image 8", "https://instagram/member8", false, "https://Linkedin/member8", "name8" },
                    { 7, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(9161), "Descripcion7Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member7", "image 7", "https://instagram/member7", false, "https://Linkedin/member7", "name7" },
                    { 6, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(9113), "Descripcion6Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member6", "image 6", "https://instagram/member6", false, "https://Linkedin/member6", "name6" },
                    { 5, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(8964), "Descripcion5Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member5", "image 5", "https://instagram/member5", false, "https://Linkedin/member5", "name5" },
                    { 4, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(8929), "Descripcion4Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member4", "image 4", "https://instagram/member4", false, "https://Linkedin/member4", "name4" },
                    { 3, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(8890), "Descripcion3Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member3", "image 3", "https://instagram/member3", false, "https://Linkedin/member3", "name3" },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(8830), "Descripcion2Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member2", "image 2", "https://instagram/member2", false, "https://Linkedin/member2", "name2" },
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 102, DateTimeKind.Local).AddTicks(8076), "Descripcion1Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://facebook.com/member1", "image 1", "https://instagram/member1", false, "https://Linkedin/member1", "name1" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "AboutUsText", "Adress", "CreatedAt", "Email", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name", "Phone", "WelcomeText" },
                values: new object[,]
                {
                    { 10, "text about us10", "Adress 101010", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3333), "email10@gmail.com", "https://facebook.com/organization10", "image10", null, false, null, "organizacion10", 77616420, "texto welcome to visit10" },
                    { 8, "text about us8", "Adress 888", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3271), "email8@gmail.com", "https://facebook.com/organization8", "image8", null, false, null, "organizacion8", 25090800, "texto welcome to visit8" },
                    { 7, "text about us7", "Adress 777", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3072), "email7@gmail.com", "https://facebook.com/organization7", "image7", null, false, null, "organizacion7", 49801704, "texto welcome to visit7" },
                    { 6, "text about us6", "Adress 666", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3047), "email6@gmail.com", "https://facebook.com/organization6", "image6", null, false, null, "organizacion6", 46941046, "texto welcome to visit6" },
                    { 9, "text about us9", "Adress 999", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3306), "email9@gmail.com", "https://facebook.com/organization9", "image9", null, false, null, "organizacion9", 75096814, "texto welcome to visit9" },
                    { 4, "text about us4", "Adress 444", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(2994), "email4@gmail.com", "https://facebook.com/organization4", "image4", null, false, null, "organizacion4", 29950874, "texto welcome to visit4" },
                    { 3, "text about us3", "Adress 333", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(2969), "email3@gmail.com", "https://facebook.com/organization3", "image3", null, false, null, "organizacion3", 57050465, "texto welcome to visit3" },
                    { 2, "text about us2", "Adress 222", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(2935), "email2@gmail.com", "https://facebook.com/organization2", "image2", null, false, null, "organizacion2", 98644092, "texto welcome to visit2" },
                    { 1, "text about us1", "Adress 111", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(2684), "email1@gmail.com", "https://facebook.com/organization1", "image1", null, false, null, "organizacion1", 84546122, "texto welcome to visit1" },
                    { 5, "text about us5", "Adress 555", new DateTime(2021, 8, 9, 10, 48, 8, 105, DateTimeKind.Local).AddTicks(3019), "email5@gmail.com", "https://facebook.com/organization5", "image5", null, false, null, "organizacion5", 89660613, "texto welcome to visit5" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 85, DateTimeKind.Local).AddTicks(2752), "Admin User", false, "Admin" },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 85, DateTimeKind.Local).AddTicks(3014), "Standard User", false, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsDeleted", "Order", "OrganizationId", "Text" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7202), "imagen 10", false, 10, "10", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 9, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7180), "imagen 9", false, 9, "9", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsDeleted", "Order", "OrganizationId", "Text" },
                values: new object[,]
                {
                    { 8, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7161), "imagen 8", false, 8, "8", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 6, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7122), "imagen 6", false, 6, "6", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 7, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7142), "imagen 7", false, 7, "7", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 4, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(6911), "imagen 4", false, 4, "4", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 3, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(6891), "imagen 3", false, 3, "3", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(6860), "imagen 2", false, 2, "2", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(6613), "imagen 1", false, 1, "1", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" },
                    { 5, new DateTime(2021, 8, 9, 10, 48, 8, 100, DateTimeKind.Local).AddTicks(7098), "imagen 5", false, 5, "5", "sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 9, "Content9Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7702), "image9", false, "name 9" },
                    { 1, "Content1Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7192), "image1", false, "name 1" },
                    { 2, "Content2Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7439), "image2", false, "name 2" },
                    { 3, "Content3Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7469), "image3", false, "name 3" },
                    { 4, "Content4Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7491), "image4", false, "name 4" },
                    { 5, "Content5Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7512), "image5", false, "name 5" },
                    { 6, "Content6Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7536), "image6", false, "name 6" },
                    { 7, "Content7Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7559), "image7", false, "name 7" },
                    { 8, "Content8Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7580), "image8", false, "name 8" },
                    { 10, "Content10Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 101, DateTimeKind.Local).AddTicks(7730), "image10", false, "name 10" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Content 1 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(4465), "image 1", false, "new's name " },
                    { 10, 10, "Content 10 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5106), "image 10", false, "new's name " },
                    { 9, 9, "Content 9 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5081), "image 9", false, "new's name " },
                    { 7, 7, "Content 7 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5037), "image 7", false, "new's name " },
                    { 6, 6, "Content 6 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5014), "image 6", false, "new's name " },
                    { 5, 5, "Content 5 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(4988), "image 5", false, "new's name " },
                    { 4, 4, "Content 4 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(4965), "image 4", false, "new's name " },
                    { 8, 8, "Content 8 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5059), "image 8", false, "new's name " },
                    { 15, 2, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5250), "image ", false, "new's name " },
                    { 12, 2, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5209), "image ", false, "new's name " },
                    { 2, 2, "Content 2 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(4904), "image 2", false, "new's name " },
                    { 14, 1, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5231), "image ", false, "new's name " },
                    { 11, 1, "Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(5128), "image ", false, "new's name " },
                    { 3, 3, "Content 3 Lorem ipsum dolor sit amet,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2021, 8, 9, 10, 48, 8, 104, DateTimeKind.Local).AddTicks(4941), "image 3", false, "new's name " }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "email", "firstName", "lastName", "password", "photo", "roleId" },
                values: new object[,]
                {
                    { 11, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9487), false, "mail11@Mail.com", "User 11", "RegularUser 11", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 18, new DateTime(2021, 8, 9, 10, 48, 8, 99, DateTimeKind.Local).AddTicks(62), false, "mail18@Mail.com", "User 18", "RegularUser 18", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 17, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9933), false, "mail17@Mail.com", "User 17", "RegularUser 17", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 16, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9873), false, "mail16@Mail.com", "User 16", "RegularUser 16", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 15, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9811), false, "mail15@Mail.com", "User 15", "RegularUser 15", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 14, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9744), false, "mail14@Mail.com", "User 14", "RegularUser 14", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 13, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9620), false, "mail13@Mail.com", "User 13", "RegularUser 13", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 12, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9557), false, "mail12@Mail.com", "User 12", "RegularUser 12", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 10, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9350), false, "mail10@Mail.com", "User 10", "AdminUser 10", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 3, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8698), false, "mail3@Mail.com", "User 3", "AdminUser 3", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 8, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9211), false, "mail8@Mail.com", "User 8", "AdminUser 8", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 7, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8985), false, "mail7@Mail.com", "User 7", "AdminUser 7", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 6, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8920), false, "mail6@Mail.com", "User 6", "AdminUser 6", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 5, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8839), false, "mail5@Mail.com", "User 5", "AdminUser 5", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 4, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8774), false, "mail4@Mail.com", "User 4", "AdminUser 4", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 19, new DateTime(2021, 8, 9, 10, 48, 8, 99, DateTimeKind.Local).AddTicks(128), false, "mail19@Mail.com", "User 19", "RegularUser 19", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 },
                    { 2, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(8480), false, "mail2@Mail.com", "User 2", "AdminUser 2", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 1, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(7488), false, "mail1@Mail.com", "User 1", "AdminUser 1", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 9, new DateTime(2021, 8, 9, 10, 48, 8, 98, DateTimeKind.Local).AddTicks(9282), false, "mail9@Mail.com", "User 9", "AdminUser 9", "3b612c75a7b5048a435fb6ec81e52ff92d6d795a8b5a9c17070f6a63c97a53b2", "Test.jpg", 1 },
                    { 20, new DateTime(2021, 8, 9, 10, 48, 8, 99, DateTimeKind.Local).AddTicks(189), false, "mail20@Mail.com", "User 20", "RegularUser 20", "a61a8adf60038792a2cb88e670b20540a9d6c2ca204ab754fc768950e79e7d36", "Test.jpg", 2 }
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
