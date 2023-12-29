using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebRestaurant.DataAccess.Migrations
{
    public partial class WebRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 21, 43, 32, 376, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 12, 29, 21, 43, 32, 376, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 21, 43, 32, 376, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 12, 29, 21, 43, 32, 376, DateTimeKind.Local).AddTicks(909) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6215) });
        }
    }
}
