using Microsoft.EntityFrameworkCore.Migrations;

namespace Songlist.Migrations
{
    public partial class genredetails1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    GenreId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "M", "Metal" },
                    { "R", "Rap" },
                    { "H", "Hip Hop" },
                    { "RC", "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 1, "M", "Master of Puppets", 5, 1980 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 3, "R", "Lose Yourself", 1, 2005 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 2, "RC", "Wonderwall", 4, 1990 });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
