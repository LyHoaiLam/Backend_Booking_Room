using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class add_init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39b7b0b5-39e5-4fcf-b74f-21facb3d47de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b224fb2-9162-468e-8657-4156288f0e66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2312649d-271f-476d-a6c2-955f64ee65ee", null, "User", "USER" },
                    { "b19a8f40-a900-436b-9f0e-856ec7928f72", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2312649d-271f-476d-a6c2-955f64ee65ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b19a8f40-a900-436b-9f0e-856ec7928f72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39b7b0b5-39e5-4fcf-b74f-21facb3d47de", null, "Admin", "ADMIN" },
                    { "8b224fb2-9162-468e-8657-4156288f0e66", null, "User", "USER" }
                });
        }
    }
}
