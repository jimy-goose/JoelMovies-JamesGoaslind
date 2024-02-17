using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoelMovies_JamesGoaslind.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewMovies",
                columns: table => new
                {
                    NewMovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Edited = table.Column<bool>(type: "INTEGER", nullable: true),// Can be null
                    Lent_To = table.Column<string>(type: "TEXT", nullable: true), // Can be null
                    Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true) // can be null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewMovies", x => x.NewMovieID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewMovies");
        }
    }
}
