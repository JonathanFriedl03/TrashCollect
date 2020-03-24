using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "81fa6edd-8fa8-4e5a-b9ef-71c1db2544c6", "6984aed1-59ff-4ab3-9e26-f974b7b6505d", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27e5cff9-6e6e-4c9c-a1eb-cf9e9550511d", "d444ab40-e6f4-49b0-b184-938958ac1e80", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27e5cff9-6e6e-4c9c-a1eb-cf9e9550511d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fa6edd-8fa8-4e5a-b9ef-71c1db2544c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "912754f0-81dd-4703-8a73-7582e3da4da0", "3f122e2f-3919-4597-a36b-1c964fa7f814", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2855915-da69-414b-bfa3-50e26612565b", "361ac62d-9b2f-4c1e-bf34-5e12f1242721", "Employee", "Employee" });
        }
    }
}
