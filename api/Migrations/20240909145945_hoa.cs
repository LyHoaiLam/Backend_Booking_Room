using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class hoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "b97ea0e5-a06d-41d2-a124-1f5fd4a9ec64", null, "User", "USER" },
                    { "babeba4a-b5c6-485f-a2e0-a0363ecdd29e", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b97ea0e5-a06d-41d2-a124-1f5fd4a9ec64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "babeba4a-b5c6-485f-a2e0-a0363ecdd29e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d727214-59ba-47f9-8038-a17160ec9f4b", null, "User", "USER" },
                    { "e83a499a-d27e-4bed-bd6f-b6fecbd6f8cb", null, "Admin", "ADMIN" }
                });
        }
    }
}
