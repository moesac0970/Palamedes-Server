using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    TelNr = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    HashPasw = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arts_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dob", "Email", "FirstName", "HashPasw", "LastName", "TelNr", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "jos", null, "doenikni", 48484848, null },
                    { 2, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "carlos", null, "taco", 48484848, null },
                    { 3, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "donald", null, "cunk", 48484848, null },
                    { 4, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "Leoplod", null, "II", 48484848, null },
                    { 5, new DateTime(1960, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "manu09ice@gmail.com", "Jenny", null, "VanGimst", 491080115, null },
                    { 6, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "Pablito", null, "escobar", 48484848, null }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistName", "Dob", "UserId" },
                values: new object[] { 2, "Jenny", new DateTime(2019, 10, 22, 11, 41, 48, 567, DateTimeKind.Local).AddTicks(2285), 5 });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistName", "Dob", "UserId" },
                values: new object[] { 1, "Pablito", new DateTime(2019, 10, 22, 11, 41, 48, 566, DateTimeKind.Local).AddTicks(6898), 6 });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "Id", "ArtistId", "Category", "CategoryId", "Created", "Description", "ImageName", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { 5, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8294), "messen", "messen.jpg", "Messen", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8310), "steinen", "stenen.jpg", "Stenen", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8325), "steinen", "abstract.jpg", "Abstract", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8340), "steinen", "sloten.jpg", "Sloten", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8355), "steinen", "boor.jpg", "Boor", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, 0, 0, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8371), "steinen", "circle.jpg", "Circle", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 0, 1, new DateTime(2019, 10, 22, 11, 41, 48, 543, DateTimeKind.Local).AddTicks(4420), "Een schilderij van een vogel.", "vogel.jpg", "Nachtegaal", 300m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 0, 2, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(7909), "Een schilderij van een Vaas.", "vaas.jpg", "Vaas", 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 0, 2, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8247), "Een schilderij van een Egel.", "egel.jpg", "Egel", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 0, 2, new DateTime(2019, 10, 22, 11, 41, 48, 560, DateTimeKind.Local).AddTicks(8277), "Een schilderij van een trap.", "trap.jpg", "Trap", 150m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_UserId",
                table: "Artists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Arts_ArtistId",
                table: "Arts",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
