using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreateAt", "CreateBy", "FirstName", "IsDeleted", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth1", false, "l", "0121155458" },
                    { 2, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth2", false, "l", "0121155458" },
                    { 3, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth3", false, "l", "0121155458" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreateAt", "CreateBy", "IsDeleted", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 12m, null, "book1" },
                    { 2, 1, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 12m, null, "book2" },
                    { 3, 1, new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 12m, null, "book3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
