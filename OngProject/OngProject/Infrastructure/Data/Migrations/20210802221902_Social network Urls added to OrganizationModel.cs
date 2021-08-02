using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class SocialnetworkUrlsaddedtoOrganizationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "linkedinUrl",
                table: "Organizations",
                newName: "LinkedinUrl");

            migrationBuilder.RenameColumn(
                name: "instagramUrl",
                table: "Organizations",
                newName: "InstagramUrl");

            migrationBuilder.RenameColumn(
                name: "facebookUrl",
                table: "Organizations",
                newName: "FacebookUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkedinUrl",
                table: "Organizations",
                newName: "linkedinUrl");

            migrationBuilder.RenameColumn(
                name: "InstagramUrl",
                table: "Organizations",
                newName: "instagramUrl");

            migrationBuilder.RenameColumn(
                name: "FacebookUrl",
                table: "Organizations",
                newName: "facebookUrl");
        }
    }
}
