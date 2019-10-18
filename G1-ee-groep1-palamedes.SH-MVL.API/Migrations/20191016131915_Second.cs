using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashPasw",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 16, 15, 19, 14, 342, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 16, 15, 19, 14, 348, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 16, 15, 19, 14, 348, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 16, 15, 19, 14, 348, DateTimeKind.Local).AddTicks(9270));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashPasw",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 15, 15, 55, 7, 125, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 15, 15, 55, 7, 128, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 15, 15, 55, 7, 128, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 15, 15, 55, 7, 128, DateTimeKind.Local).AddTicks(8799));
        }
    }
}
