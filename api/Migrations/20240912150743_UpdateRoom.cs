using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "dae9fc50-3246-426b-8633-69c69795a497", null, "Admin", "ADMIN" },
                    { "e27e1e73-2a02-411a-9a5b-466ed7729bc9", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dae9fc50-3246-426b-8633-69c69795a497");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e27e1e73-2a02-411a-9a5b-466ed7729bc9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b97ea0e5-a06d-41d2-a124-1f5fd4a9ec64", null, "User", "USER" },
                    { "babeba4a-b5c6-485f-a2e0-a0363ecdd29e", null, "Admin", "ADMIN" }
                });
        }
    }
}
