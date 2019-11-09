using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class Authmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthHistories",
                columns: table => new
                {
                    Token = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 836, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 837, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 831, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 9, 18, 54, 22, 835, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b607cb0-4cd3-4c64-9267-71eb2e431e27", "259da4b0-852e-4d72-95e1-80850a18c170" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a86962b2-a33e-4a05-9d45-bf16c0ed1d94", "394bd66c-cf5b-4a8d-969b-3525f52aa703" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthHistories");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 202, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 202, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 197, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 8, 16, 9, 23, 201, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0293a07-ca0b-4492-9dea-aec0a3c54043", "e13315b9-2bd4-4992-8603-b0428d3b9907" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c38d5f9-71ea-46d2-9562-f609f24d0b62", "54b2971e-8464-4e9c-a913-dd9f947b3772" });
        }
    }
}
