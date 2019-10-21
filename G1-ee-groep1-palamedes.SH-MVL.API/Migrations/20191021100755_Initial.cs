using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                });

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
                name: "UserArt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserArt_Arts_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Arts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserArt_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Arts",
                columns: new[] { "Id", "Artist", "Category", "Created", "Description", "ImageName", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { 1, "pablito", "barock", new DateTime(2019, 10, 21, 12, 7, 55, 260, DateTimeKind.Local).AddTicks(9321), "Een schilderij van een vogel.", "devogel.jpg", "De Nachtegaal", 300m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "pablito", "gothiek", new DateTime(2019, 10, 21, 12, 7, 55, 265, DateTimeKind.Local).AddTicks(4661), "Een schilderij van een Vaas.", "devaas.jpg", "De Vaas", 1m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "pablito", "abstracte kunst", new DateTime(2019, 10, 21, 12, 7, 55, 265, DateTimeKind.Local).AddTicks(4766), "Een schilderij van een Egel.", "deegel.jpg", "De Egel", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "pablito", "Moderne Kunst", new DateTime(2019, 10, 21, 12, 7, 55, 265, DateTimeKind.Local).AddTicks(4778), "Een schilderij van een trap.", "trap.jpg", "De Trap", 150m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dob", "Email", "FirstName", "HashPasw", "LastName", "TelNr", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "jos", null, "doenikni", 48484848, null },
                    { 2, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "carlos", null, "taco", 48484848, null },
                    { 3, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "donald", null, "cunk", 48484848, null },
                    { 4, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "random@mailinator.com", "Leoplod", null, "II", 48484848, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserArt_ArtId",
                table: "UserArt",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_UserArt_UserId",
                table: "UserArt",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArt");

            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
