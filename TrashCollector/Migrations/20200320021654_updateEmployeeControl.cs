using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updateEmployeeControl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64228d5-3470-4d1b-b58e-f8b5b85ebc5f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "050423a4-9709-45b0-93a1-8fbbecc871ee", "ea914b56-49f6-442c-ac72-bf4b6d41d5e1", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11372e65-1edf-4765-b305-2eef3127ace5", "94f1b258-1169-4bd8-a210-ab1e7befc153", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "050423a4-9709-45b0-93a1-8fbbecc871ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11372e65-1edf-4765-b305-2eef3127ace5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f64228d5-3470-4d1b-b58e-f8b5b85ebc5f", "9ee45acb-f1ee-4cd8-aec4-328f4b7c9d6e", "Admin", "Admin" });
        }
    }
}
