using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a6241b-40dc-43ce-ae56-bc39474f3e8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eed5e33b-1f34-4d0c-b323-9ca7852d3e6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ab5fb02-b92b-47a0-99b4-5464d4f75db8", null, "Admin", "ADMIN" },
                    { "e1f61f8d-d911-4e0a-a8da-e0edba8eedc2", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ab5fb02-b92b-47a0-99b4-5464d4f75db8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1f61f8d-d911-4e0a-a8da-e0edba8eedc2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2a6241b-40dc-43ce-ae56-bc39474f3e8c", null, "User", "USER" },
                    { "eed5e33b-1f34-4d0c-b323-9ca7852d3e6e", null, "Admin", "ADMIN" }
                });
        }
    }
}
