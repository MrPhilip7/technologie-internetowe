using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace technologieInternetowe.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreFilms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "CoverImageUrl", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 111, 3, null, "A man with a low IQ has great accomplishments.", "Robert Zemeckis", 7.99m, "Forrest Gump" },
                    { 112, 5, null, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", 10.99m, "Interstellar" },
                    { 113, 1, null, "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family.", "Ridley Scott", 8.99m, "Gladiator" },
                    { 114, 3, null, "The lives of guards on Death Row are affected by one of their charges.", "Frank Darabont", 6.99m, "The Green Mile" },
                    { 115, 1, null, "Earth's mightiest heroes must come together and learn to fight as a team.", "Joss Whedon", 11.99m, "The Avengers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 115);
        }
    }
}
