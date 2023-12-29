using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebRestaurant.DataAccess.Migrations
{
    public partial class UpdateAllYeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Name", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6034), "Món khai vị", new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Description", "Name", "Price", "ShortDescription", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6218), "Khai vị khai vị", "Khai vị 1", 100000.0, "Khai vị", new DateTime(2023, 12, 29, 19, 43, 55, 380, DateTimeKind.Local).AddTicks(6215) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Name", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 8, 43, 19, 300, DateTimeKind.Local).AddTicks(2835), "Câu lạc bộ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Description", "Name", "Price", "ShortDescription", "UpdateAt" },
                values: new object[] { new DateTime(2023, 12, 29, 8, 43, 19, 300, DateTimeKind.Local).AddTicks(2923), "Barcelona Barcelona", "Barcelona", 30000.0, "Barcelona", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
