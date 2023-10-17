using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRDbApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", precision: 2, scale: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Duration", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Frank Darabont", 142, "Drama", 9.3m, "The Shawshank Redemption", 1994 },
                    { 2, "Francis Ford Coppola", 175, "Crime, Drama", 9.2m, "The Godfather", 1972 },
                    { 3, "Christopher Nolan", 152, "Action, Crime, Drama", 9.0m, "The Dark Knight", 2008 },
                    { 4, "Quentin Tarantino", 154, "Crime, Drama", 8.9m, "Pulp Fiction", 1994 },
                    { 5, "David Fincher", 139, "Drama", 8.8m, "Fight Club", 1999 },
                    { 6, "Robert Zemeckis", 142, "Drama, Romance", 8.8m, "Forrest Gump", 1994 },
                    { 7, "Christopher Nolan", 148, "Action, Adventure, Sci-Fi", 8.7m, "Inception", 2010 },
                    { 8, "Lana Wachowski, Lilly Wachowski", 136, "Action, Sci-Fi", 8.7m, "The Matrix", 1999 },
                    { 9, "Christopher Nolan", 169, "Adventure, Drama, Sci-Fi", 8.6m, "Interstellar", 2014 },
                    { 10, "Peter Jackson", 178, "Adventure, Drama, Fantasy", 8.8m, "The Lord of the Rings: The Fellowship of the Ring", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
