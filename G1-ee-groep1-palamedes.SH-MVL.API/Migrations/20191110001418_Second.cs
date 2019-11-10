using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "AuthHistory",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthHistory",
                table: "AuthHistory",
                column: "Token");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 503, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 503, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 500, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 10, 1, 14, 18, 502, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.InsertData(
                table: "AuthHistory",
                columns: new[] { "Token", "UserName" },
                values: new object[] { "slmkqfùlqdsmlfqmdlkfmqsldkmlsfd.dspfkqsmùsfkdlùmlqsdfkmùsld.ùqsmldgfsùdflk", "VanGimst" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "754d59f1-3f81-40d6-abd8-8fd2a1c73bfb", "81580c47-d0e9-4f0f-a5c7-66676a9371a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33e50651-2f1f-42b9-8ea8-f24f823db9eb", "afc93260-79ea-4d91-854d-ef2a8e5e3aca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthHistory",
                table: "AuthHistory");

            migrationBuilder.DeleteData(
                table: "AuthHistory",
                keyColumn: "Token",
                keyValue: "slmkqfùlqdsmlfqmdlkfmqsldkmlsfd.dspfkqsmùsfkdlùmlqsdfkmùsld.ùqsmldgfsùdflk");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "AuthHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 612, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 612, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 608, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2019, 11, 10, 0, 54, 6, 611, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3190b7e5-c05f-42f1-83eb-cec3295be090", "d0dae5e2-4106-4161-baa3-c145aeec8606" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "045eba1a-c1cd-4076-86f8-719a77c9ba7e", "0d51506d-a28f-4256-84f5-a079b7fc8649" });
        }
    }
}
