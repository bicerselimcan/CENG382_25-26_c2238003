using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetWeek5App.Migrations
{
    /// <inheritdoc />
    public partial class SeedClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name", "PersonCount" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 1", true, "Class 1", 11 },
                    { 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 2", true, "Class 2", 12 },
                    { 3, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 3", true, "Class 3", 13 },
                    { 4, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 4", true, "Class 4", 14 },
                    { 5, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 5", true, "Class 5", 15 },
                    { 6, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 6", true, "Class 6", 16 },
                    { 7, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 7", true, "Class 7", 17 },
                    { 8, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 8", true, "Class 8", 18 },
                    { 9, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 9", true, "Class 9", 19 },
                    { 10, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 10", true, "Class 10", 20 },
                    { 11, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 11", true, "Class 11", 21 },
                    { 12, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 12", true, "Class 12", 22 },
                    { 13, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 13", true, "Class 13", 23 },
                    { 14, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 14", true, "Class 14", 24 },
                    { 15, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 15", true, "Class 15", 25 },
                    { 16, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 16", true, "Class 16", 26 },
                    { 17, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 17", true, "Class 17", 27 },
                    { 18, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 18", true, "Class 18", 28 },
                    { 19, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 19", true, "Class 19", 29 },
                    { 20, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 20", true, "Class 20", 30 },
                    { 21, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 21", true, "Class 21", 31 },
                    { 22, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 22", true, "Class 22", 32 },
                    { 23, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 23", true, "Class 23", 33 },
                    { 24, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 24", true, "Class 24", 34 },
                    { 25, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 25", true, "Class 25", 35 },
                    { 26, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 26", true, "Class 26", 36 },
                    { 27, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 27", true, "Class 27", 37 },
                    { 28, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 28", true, "Class 28", 38 },
                    { 29, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 29", true, "Class 29", 39 },
                    { 30, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 30", true, "Class 30", 10 },
                    { 31, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 31", true, "Class 31", 11 },
                    { 32, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 32", true, "Class 32", 12 },
                    { 33, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 33", true, "Class 33", 13 },
                    { 34, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 34", true, "Class 34", 14 },
                    { 35, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 35", true, "Class 35", 15 },
                    { 36, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 36", true, "Class 36", 16 },
                    { 37, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 37", true, "Class 37", 17 },
                    { 38, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 38", true, "Class 38", 18 },
                    { 39, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 39", true, "Class 39", 19 },
                    { 40, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 40", true, "Class 40", 20 },
                    { 41, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 41", true, "Class 41", 21 },
                    { 42, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 42", true, "Class 42", 22 },
                    { 43, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 43", true, "Class 43", 23 },
                    { 44, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 44", true, "Class 44", 24 },
                    { 45, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 45", true, "Class 45", 25 },
                    { 46, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 46", true, "Class 46", 26 },
                    { 47, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 47", true, "Class 47", 27 },
                    { 48, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 48", true, "Class 48", 28 },
                    { 49, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 49", true, "Class 49", 29 },
                    { 50, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 50", true, "Class 50", 30 },
                    { 51, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 51", true, "Class 51", 31 },
                    { 52, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 52", true, "Class 52", 32 },
                    { 53, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 53", true, "Class 53", 33 },
                    { 54, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 54", true, "Class 54", 34 },
                    { 55, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 55", true, "Class 55", 35 },
                    { 56, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 56", true, "Class 56", 36 },
                    { 57, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 57", true, "Class 57", 37 },
                    { 58, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 58", true, "Class 58", 38 },
                    { 59, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 59", true, "Class 59", 39 },
                    { 60, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 60", true, "Class 60", 10 },
                    { 61, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 61", true, "Class 61", 11 },
                    { 62, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 62", true, "Class 62", 12 },
                    { 63, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 63", true, "Class 63", 13 },
                    { 64, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 64", true, "Class 64", 14 },
                    { 65, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 65", true, "Class 65", 15 },
                    { 66, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 66", true, "Class 66", 16 },
                    { 67, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 67", true, "Class 67", 17 },
                    { 68, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 68", true, "Class 68", 18 },
                    { 69, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 69", true, "Class 69", 19 },
                    { 70, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 70", true, "Class 70", 20 },
                    { 71, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 71", true, "Class 71", 21 },
                    { 72, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 72", true, "Class 72", 22 },
                    { 73, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 73", true, "Class 73", 23 },
                    { 74, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 74", true, "Class 74", 24 },
                    { 75, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 75", true, "Class 75", 25 },
                    { 76, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 76", true, "Class 76", 26 },
                    { 77, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 77", true, "Class 77", 27 },
                    { 78, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 78", true, "Class 78", 28 },
                    { 79, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 79", true, "Class 79", 29 },
                    { 80, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 80", true, "Class 80", 30 },
                    { 81, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 81", true, "Class 81", 31 },
                    { 82, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 82", true, "Class 82", 32 },
                    { 83, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 83", true, "Class 83", 33 },
                    { 84, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 84", true, "Class 84", 34 },
                    { 85, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 85", true, "Class 85", 35 },
                    { 86, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 86", true, "Class 86", 36 },
                    { 87, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 87", true, "Class 87", 37 },
                    { 88, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 88", true, "Class 88", 38 },
                    { 89, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 89", true, "Class 89", 39 },
                    { 90, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 90", true, "Class 90", 10 },
                    { 91, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 91", true, "Class 91", 11 },
                    { 92, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 92", true, "Class 92", 12 },
                    { 93, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 93", true, "Class 93", 13 },
                    { 94, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 94", true, "Class 94", 14 },
                    { 95, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 95", true, "Class 95", 15 },
                    { 96, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 96", true, "Class 96", 16 },
                    { 97, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 97", true, "Class 97", 17 },
                    { 98, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 98", true, "Class 98", 18 },
                    { 99, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 99", true, "Class 99", 19 },
                    { 100, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is class 100", true, "Class 100", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
