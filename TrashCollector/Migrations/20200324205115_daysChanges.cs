using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class daysChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9b2533ab-147c-44e3-96f5-dce6a98f869c", "9896bd4e-3ca4-4006-9b56-e3804f14227a", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe7d3249-0c04-4077-a94e-bcd52fa4a6ef", "039a6ebd-2596-4c68-8105-9e440bc5063c", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b2533ab-147c-44e3-96f5-dce6a98f869c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe7d3249-0c04-4077-a94e-bcd52fa4a6ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81fa6edd-8fa8-4e5a-b9ef-71c1db2544c6", "6984aed1-59ff-4ab3-9e26-f974b7b6505d", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27e5cff9-6e6e-4c9c-a1eb-cf9e9550511d", "d444ab40-e6f4-49b0-b184-938958ac1e80", "Employee", "Employee" });
        }
    }
}
