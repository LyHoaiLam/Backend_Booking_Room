using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0d727214-59ba-47f9-8038-a17160ec9f4b", null, "User", "USER" },
                    { "e83a499a-d27e-4bed-bd6f-b6fecbd6f8cb", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d727214-59ba-47f9-8038-a17160ec9f4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e83a499a-d27e-4bed-bd6f-b6fecbd6f8cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2312649d-271f-476d-a6c2-955f64ee65ee", null, "User", "USER" },
                    { "b19a8f40-a900-436b-9f0e-856ec7928f72", null, "Admin", "ADMIN" }
                });
        }
    }
}
