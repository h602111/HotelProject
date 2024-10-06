using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CustomerWebApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Roomnr = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numberofbeds = table.Column<int>(nullable: false),
                    Roomsize = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Roomnr);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Usernr = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Usernr);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Roomnr = table.Column<int>(nullable: true),
                    Usernr = table.Column<int>(nullable: true),
                    RoomnrNavigationRoomnr = table.Column<int>(nullable: true),
                    UsernrNavigationUsernr = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomnrNavigationRoomnr",
                        column: x => x.RoomnrNavigationRoomnr,
                        principalTable: "Rooms",
                        principalColumn: "Roomnr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UsernrNavigationUsernr",
                        column: x => x.UsernrNavigationUsernr,
                        principalTable: "Users",
                        principalColumn: "Usernr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Roomnr", "Available", "Numberofbeds", "Price", "Roomsize" },
                values: new object[,]
                {
                    { 1, true, 3, 1000, 10 },
                    { 2, true, 2, 800, 6 },
                    { 3, true, 4, 1500, 15 },
                    { 4, true, 2, 900, 8 },
                    { 5, true, 3, 3000, 20 },
                    { 6, true, 1, 600, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomnrNavigationRoomnr",
                table: "Reservations",
                column: "RoomnrNavigationRoomnr");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UsernrNavigationUsernr",
                table: "Reservations",
                column: "UsernrNavigationUsernr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
