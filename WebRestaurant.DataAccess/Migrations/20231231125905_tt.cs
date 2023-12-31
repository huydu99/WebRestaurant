using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebRestaurant.DataAccess.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 59, 4, 778, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 12, 31, 19, 59, 4, 778, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 59, 4, 778, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 12, 31, 19, 59, 4, 778, DateTimeKind.Local).AddTicks(7283) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 31, 9, 33, 15, 979, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 12, 31, 9, 33, 15, 979, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 31, 9, 33, 15, 979, DateTimeKind.Local).AddTicks(3894), new DateTime(2023, 12, 31, 9, 33, 15, 979, DateTimeKind.Local).AddTicks(3890) });
        }
    }
}
