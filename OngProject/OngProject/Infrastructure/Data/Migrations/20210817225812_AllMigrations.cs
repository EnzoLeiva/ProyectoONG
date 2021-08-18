using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OngProject.Infrastructure.Data.Migrations
{
    public partial class AllMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 200, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 204, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 50, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1402), "Descripcion 50Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories50.jpg", false, "name 50" },
                    { 49, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1379), "Descripcion 49Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories49.jpg", false, "name 49" },
                    { 48, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1356), "Descripcion 48Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories48.jpg", false, "name 48" },
                    { 47, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1331), "Descripcion 47Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories47.jpg", false, "name 47" },
                    { 46, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1233), "Descripcion 46Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories46.jpg", false, "name 46" },
                    { 45, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1210), "Descripcion 45Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories45.jpg", false, "name 45" },
                    { 44, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1187), "Descripcion 44Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories44.jpg", false, "name 44" },
                    { 43, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1164), "Descripcion 43Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories43.jpg", false, "name 43" },
                    { 42, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1141), "Descripcion 42Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories42.jpg", false, "name 42" },
                    { 41, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1118), "Descripcion 41Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories41.jpg", false, "name 41" },
                    { 11, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(228), "Descripcion 11Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories11.jpg", false, "name 11" },
                    { 39, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1072), "Descripcion 39Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories39.jpg", false, "name 39" },
                    { 12, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(252), "Descripcion 12Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories12.jpg", false, "name 12" },
                    { 13, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(275), "Descripcion 13Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories13.jpg", false, "name 13" },
                    { 14, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(298), "Descripcion 14Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories14.jpg", false, "name 14" },
                    { 40, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1095), "Descripcion 40Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories40.jpg", false, "name 40" },
                    { 16, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(345), "Descripcion 16Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories16.jpg", false, "name 16" },
                    { 17, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(368), "Descripcion 17Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories17.jpg", false, "name 17" },
                    { 18, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(394), "Descripcion 18Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories18.jpg", false, "name 18" },
                    { 19, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(417), "Descripcion 19Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories19.jpg", false, "name 19" },
                    { 20, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(512), "Descripcion 20Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories20.jpg", false, "name 20" },
                    { 21, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(536), "Descripcion 21Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories21.jpg", false, "name 21" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 22, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(559), "Descripcion 22Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories22.jpg", false, "name 22" },
                    { 23, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(582), "Descripcion 23Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories23.jpg", false, "name 23" },
                    { 24, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(605), "Descripcion 24Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories24.jpg", false, "name 24" },
                    { 25, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(629), "Descripcion 25Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories25.jpg", false, "name 25" },
                    { 15, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(322), "Descripcion 15Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories15.jpg", false, "name 15" },
                    { 27, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(675), "Descripcion 27Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories27.jpg", false, "name 27" },
                    { 38, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(1048), "Descripcion 38Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories38.jpg", false, "name 38" },
                    { 37, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(975), "Descripcion 37Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories37.jpg", false, "name 37" },
                    { 36, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(952), "Descripcion 36Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories36.jpg", false, "name 36" },
                    { 35, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(928), "Descripcion 35Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories35.jpg", false, "name 35" },
                    { 33, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(879), "Descripcion 33Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories33.jpg", false, "name 33" },
                    { 34, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(905), "Descripcion 34Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories34.jpg", false, "name 34" },
                    { 31, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(833), "Descripcion 31Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories31.jpg", false, "name 31" },
                    { 30, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(809), "Descripcion 30Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories30.jpg", false, "name 30" },
                    { 26, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(652), "Descripcion 26Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories26.jpg", false, "name 26" },
                    { 29, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(785), "Descripcion 29Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories29.jpg", false, "name 29" },
                    { 28, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(698), "Descripcion 28Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories28.jpg", false, "name 28" },
                    { 32, new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(856), "Descripcion 32Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "imageCategories32.jpg", false, "name 32" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(4518), 49787573 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6081), 81514868 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6140), 73234563 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6174), 47880767 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6213), 24460807 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6282), 92733525 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6318), 80662415 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6349), 74541662 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6383), 76343719 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 17, 19, 58, 11, 214, DateTimeKind.Local).AddTicks(6422), 82251108 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 217, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 218, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 219, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 205, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 205, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 215, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 216, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 17, 19, 58, 11, 212, DateTimeKind.Local).AddTicks(6661));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 477, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 482, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3136), 30938102 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3376), 34458897 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3408), 40899064 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3562), 67923064 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3586), 77967949 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3612), 85024485 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3633), 42460468 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3653), 42721509 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3674), 23867933 });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Phone" },
                values: new object[] { new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(3698), 16605473 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 502, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 503, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 504, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 483, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 483, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 500, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 501, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 13, 13, 58, 17, 499, DateTimeKind.Local).AddTicks(6735));
        }
    }
}
