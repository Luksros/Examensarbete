using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedDate", "DriveItemId", "FileSize", "LastEditedDate", "OwnerPublicId", "ProjectFileName", "PublicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!116", 28778828, new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7342), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Dubstep Heater v12", new Guid("dd9b789c-8e44-4631-a90c-e8c395d55b2d") },
                    { 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!113", 11942208, new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7357), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Shitty Beat", new Guid("cb0d03a4-d8fe-4cb4-a8b2-9740afdf9be2") },
                    { 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!111", 27545588, new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7370), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "We Ain't Makin It Out The Hood", new Guid("8beb75d6-a970-4e57-afe4-81c0e85abb2c") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "PublicId", "Username" },
                values: new object[,]
                {
                    { 1, "Clockvice@gmail.com", "TestPassword", new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Clockvice" },
                    { 2, "testcollaborator@email.com", "TestPassword", new Guid("6b0c85b4-f847-43b8-bc81-09020a215ab8"), "Vorso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
