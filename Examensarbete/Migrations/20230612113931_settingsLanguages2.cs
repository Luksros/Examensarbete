using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class settingsLanguages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPublicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    DarkMode = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9064), new Guid("e1aed9e5-15bf-4831-a00f-68459c2dbd55") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9081), new Guid("8818e9c4-f3de-47d5-a927-4a7c6e1f4dc3") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 39, 31, 180, DateTimeKind.Local).AddTicks(9094), new Guid("f02d8399-790d-47d2-9478-8c22958e3692") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: new Guid("b95e3ecf-a882-4662-b4b1-6d1cd8259f9c"));

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_LanguageId",
                table: "UserSettings",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6043), new Guid("18bd71f7-fbe5-4d9c-8e4d-605ec32b021a") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6058), new Guid("1ffdf9af-a270-42ec-9225-05fa8a0f34c5") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6072), new Guid("2462d10e-b1d2-44b9-a808-e92f892c82e9") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: new Guid("9fbb9ae5-b9e8-4ea8-918d-b01a64f2285c"));
        }
    }
}
