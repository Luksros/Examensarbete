using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examensarbete.Migrations
{
    /// <inheritdoc />
    public partial class settingsLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6043), new Guid("18bd71f7-fbe5-4d9c-8e4d-605ec32b021a") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6058), new Guid("1ffdf9af-a270-42ec-9225-05fa8a0f34c5") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 12, 13, 36, 36, 581, DateTimeKind.Local).AddTicks(6072), new Guid("2462d10e-b1d2-44b9-a808-e92f892c82e9") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: new Guid("9fbb9ae5-b9e8-4ea8-918d-b01a64f2285c"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7342), new Guid("dd9b789c-8e44-4631-a90c-e8c395d55b2d") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7357), new Guid("cb0d03a4-d8fe-4cb4-a8b2-9740afdf9be2") });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastEditedDate", "PublicId" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 6, 11, 19, 28, 38, 206, DateTimeKind.Local).AddTicks(7370), new Guid("8beb75d6-a970-4e57-afe4-81c0e85abb2c") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicId",
                value: new Guid("6b0c85b4-f847-43b8-bc81-09020a215ab8"));
        }
    }
}
