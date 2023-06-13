using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerPublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriveItemId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
