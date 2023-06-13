using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class projectCollaborators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Projects_ProjectId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProjectId",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "ProjectCollaborators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectPublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCollaborators", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectCollaborators");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedDate", "DriveItemId", "FileSize", "LastEditedDate", "OwnerPublicId", "ProjectFileName", "PublicId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!116", 28778828, new DateTime(2023, 6, 11, 18, 22, 55, 119, DateTimeKind.Local).AddTicks(4488), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Dubstep Heater v12", new Guid("12a1369c-b61b-4059-a4f9-e04520f5f96e") },
                    { 2, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!113", 11942208, new DateTime(2023, 6, 11, 18, 22, 55, 119, DateTimeKind.Local).AddTicks(4507), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "Shitty Beat", new Guid("4806b9d4-a84f-4a9d-987b-3c9c56ec9983") },
                    { 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "FFAE75F410E7D5E9!111", 27545588, new DateTime(2023, 6, 11, 18, 22, 55, 119, DateTimeKind.Local).AddTicks(4523), new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "We Ain't Makin It Out The Hood", new Guid("b1317e51-5c4d-4174-9165-79565b59acce") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProjectId", "PublicId", "Username" },
                values: new object[,]
                {
                    { 1, "testuser@email.com", "TestPassword", null, new Guid("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), "TestUser" },
                    { 2, "testcollaborator@email.com", "TestPassword", null, new Guid("c1514c79-5845-424f-9213-11343baf5b1c"), "TestCollaborator" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProjectId",
                table: "Users",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Projects_ProjectId",
                table: "Users",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
