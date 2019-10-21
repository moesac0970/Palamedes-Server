using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 587, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtistName", "Dob" },
                values: new object[] { "Jenny", new DateTime(2019, 10, 21, 21, 17, 5, 587, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 581, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9570), "Messen" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9578), "Abstract" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9582), "Sloten" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9797), "Boor" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 21, 17, 5, 585, DateTimeKind.Local).AddTicks(9804), "Circle" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 493, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtistName", "Dob" },
                values: new object[] { "jenny", new DateTime(2019, 10, 21, 18, 45, 17, 493, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 487, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8514), "messen" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8521), "abstract" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8529), "sloten" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8533), "boor" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 18, 45, 17, 491, DateTimeKind.Local).AddTicks(8536), "circle" });
        }
    }
}
