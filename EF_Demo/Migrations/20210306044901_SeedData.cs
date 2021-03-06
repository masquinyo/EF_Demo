using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name" },
                values: new object[] { 1, "Emmanuel Toledo" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Cost", "Name", "OrderId" },
                values: new object[] { 1, 20m, "Mario Kart 8", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Cost", "Name", "OrderId" },
                values: new object[] { 2, 20m, "Mario 3D All Stars", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ChargeAmount", "CustomerId", "Number", "PayedAmount" },
                values: new object[] { 1, 40m, 1, "12345Fx", 40m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }
    }
}
