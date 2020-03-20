using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updateroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "912754f0-81dd-4703-8a73-7582e3da4da0", "3f122e2f-3919-4597-a36b-1c964fa7f814", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2855915-da69-414b-bfa3-50e26612565b", "361ac62d-9b2f-4c1e-bf34-5e12f1242721", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "912754f0-81dd-4703-8a73-7582e3da4da0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2855915-da69-414b-bfa3-50e26612565b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "050423a4-9709-45b0-93a1-8fbbecc871ee", "ea914b56-49f6-442c-ac72-bf4b6d41d5e1", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11372e65-1edf-4765-b305-2eef3127ace5", "94f1b258-1169-4bd8-a210-ab1e7befc153", "Employee", "Employee" });
        }
    }
}
