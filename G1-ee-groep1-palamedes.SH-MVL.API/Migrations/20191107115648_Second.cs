using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 286, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 286, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 279, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 7, 12, 56, 48, 284, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0dc3dffd-0b54-4ad5-8fd2-f328f347d0bf", "205f48b5-f4b8-46e3-b8c5-8e3f03d9746c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13698852-09e1-4efc-b06a-73eff16b51b9", "fe0c42fd-49e1-4d84-b4d2-74cb4c5613ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 519, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 519, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 514, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 6, 15, 12, 19, 518, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fbe146d-a583-478d-b7ed-662b5a21b52a", "4d57836f-38c2-4dfc-8fec-6bc48e8a7b0c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afee4d1b-b2e2-4adf-85eb-5f11d4b751bd", "50078f97-f54b-46a2-9557-ab178f6e5e12" });
        }
    }
}
