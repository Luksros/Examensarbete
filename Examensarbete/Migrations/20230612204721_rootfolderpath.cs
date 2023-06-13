using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class rootfolderpath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocalRootFolderPath",
                table: "UserSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalRootFolderPath",
                table: "UserSettings");

            //migrationBuilder.InsertData(
            //    table: "Projects",
            //    columns: new[] { "Id", "CreatedDate", "DriveItemId", "FileSize", "LastEditedDate", "OwnerPublicId", "ProjectFileName", "PublicId" },
            //    values: new object[,]
            //    {
            //        { 1, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!116", 28778828, new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9064), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Dubstep Heater v12", new Guid("e1aed9e5-15bf-4831-a00f-68459c2dbd55") },
            //        { 2, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!113", 11942208, new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9081), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Shitty Beat", new Guid("8818e9c4-f3de-47d5-a927-4a7c6e1f4dc3") },
            //        { 3, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!111", 27545588, new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9094), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "We Ain't Makin It Out The Hood", new Guid("f02d8399-790d-47d2-9478-8c22958e3692") }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "Email", "Password", "PublicId", "Username" },
            //    values: new object[,]
            //    {
            //        { 1, "Clockvice@gmail.com", "TestPassword", new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Clockvice" },
            //        { 2, "testcollaborator@email.com", "TestPassword", new Guid("b95e3ecf-a882-4662-b4b1-6d1cd8259f9c"), "Vorso" }
            //    });
        }
    }
}
