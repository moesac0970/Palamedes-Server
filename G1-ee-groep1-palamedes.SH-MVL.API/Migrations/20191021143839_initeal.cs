using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class initeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 834, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 834, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 827, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Description", "ImageName", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4938), "messen", "messen.jpg", "messen" });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "Id", "ArtistId", "Category", "CategoryId", "Created", "Description", "ImageName", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { 6, 2, 0, 0, new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4942), "steinen", "stenen.jpg", "Stenen", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 0, 0, new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4950), "steinen", "abstract.jpg", "abstract", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 0, 0, new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4954), "steinen", "sloten.jpg", "sloten", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 0, 0, new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4957), "steinen", "boor.jpg", "boor", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 0, 0, new DateTime(2019, 10, 21, 16, 38, 38, 832, DateTimeKind.Local).AddTicks(4961), "steinen", "circle.jpg", "circle", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 566, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Dob",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 566, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 559, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 564, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 564, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 10, 21, 16, 19, 45, 564, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Description", "ImageName", "Name" },
                values: new object[] { new DateTime(2019, 10, 21, 16, 19, 45, 564, DateTimeKind.Local).AddTicks(3319), "steinen", "jennyvangimst1site.jpg", "Stenen" });
        }
    }
}
