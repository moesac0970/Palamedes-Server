using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistName", "Dob", "UserId" },
                values: new object[,]
                {
                    { 1L, "Pablito", new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6298), "4abf7808-a9da-4d44-8de2-56c4e63871a4" },
                    { 2L, "Jenny", new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(7107), "4d14d68d-f101-49de-9e21-c8b1bbe3101b" },
                    { 3L, "Johnny", new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(7138), "f4cabddc-4b81-4a94-bdd4-a5ad3a06034c" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Schilderkunst" },
                    { 2L, "Fotografie" },
                    { 3L, "Grafiek" },
                    { 4L, "Beeldhouwkunst" },
                    { 5L, "ModerneMedia" },
                    { 6L, "Filmkunst" }
                });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "Id", "ArtistId", "CategoryId", "Created", "Description", "ImageName", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTime(2020, 1, 12, 17, 56, 6, 322, DateTimeKind.Local).AddTicks(5694), "Dit is een nachtegaal", "vogel.jpg", "Nachtegaal", 3759.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, 3L, 1L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6014), "een boor dit is", "boor.jpg", "Boor", 8432.34m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 1L, 2L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(5926), "dat was dit een", "vaas.jpg", "Vaas", 6739.93m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, 2L, 2L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6008), "abstract dit een zijn", "abstract.jpg", "Abstract", 9778.59m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, 3L, 2L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6017), "circle dat geweest een", "circle.jpg", "Circle", 5943.54m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 1L, 3L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(5991), "dit egel een was", "egel.jpg", "Egel", 6044.74m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, 3L, 3L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6011), "is sloten een dit", "sloten.jpg", "Sloten", 3305.63m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 1L, 4L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(5998), "dit is trap een", "trap.jpg", "Trap", 1236.66m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, 2L, 4L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6005), "een is stenen dit", "stenen.jpg", "Stenen", 2343.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 2L, 5L, new DateTime(2020, 1, 12, 17, 56, 6, 325, DateTimeKind.Local).AddTicks(6002), "messen dit is een ", "messen.jpg", "Messen", 9765.12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Arts",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
