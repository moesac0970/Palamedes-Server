using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class NewdbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Dob",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Dob",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 381, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 19, 49, 2, 385, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d601019-58d9-4428-ab4a-ce2546509634", "2c23fe37-7cad-4bd2-bd81-b8e2d5b7f252" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d1f6107-dc52-40a9-abfe-ecd6b6c490aa", "edc38cb5-a64a-45c9-ae62-f33c4013e3bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bd7e4e9-5c40-4eb8-a994-ec7a5a3c359a", "c3cba4f2-bbad-4700-8f35-848463bb0958" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Dob",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 303, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Dob",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 303, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 299, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Created",
                value: new DateTime(2019, 11, 28, 13, 10, 7, 302, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72a60604-c461-4fc9-88ff-19de61f7d069", "17c1eb11-8724-4d21-be84-91a1c746e998" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2270e608-ac6a-4d3b-92e1-c3c9ae9bcef1", "257aa52f-4937-4adb-b9ab-c67403f3a3c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3413d25f-b3b6-434a-bc8a-798c758a021b", "9984768f-392a-4644-b03d-8071015afa9c" });
        }
    }
}
