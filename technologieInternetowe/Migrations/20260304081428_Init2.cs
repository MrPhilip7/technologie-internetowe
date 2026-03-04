using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace technologieInternetowe.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Action films", "Action" },
                    { 2, "Comedy films", "Comedy" },
                    { 3, "Drama films", "Drama" },
                    { 4, "Horror films", "Horror" },
                    { 5, "Science Fiction films", "Sci-Fi" },
                    { 6, "Romantic films", "Romance" },
                    { 7, "Thriller films", "Thriller" },
                    { 8, "Animated films", "Animation" },
                    { 9, "Documentary films", "Documentary" },
                    { 10, "Fantasy films", "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 5, "A mind-bending thriller", "Christopher Nolan", 9.99m, "Inception" },
                    { 2, 1, "A superhero crime film", "Christopher Nolan", 9.99m, "The Dark Knight" },
                    { 3, 1, "Crime anthology film", "Quentin Tarantino", 7.99m, "Pulp Fiction" },
                    { 4, 3, "A crime family saga", "Francis Ford Coppola", 8.99m, "The Godfather" },
                    { 5, 3, "A story of hope", "Frank Darabont", 8.99m, "The Shawshank Redemption" },
                    { 6, 5, "A sci-fi action film", "Lana Wachowski, Lilly Wachowski", 9.99m, "The Matrix" },
                    { 7, 7, "A psychological thriller", "Jonathan Demme", 7.99m, "The Silence of the Lambs" },
                    { 8, 8, "An animated adventure", "Roger Allers, Rob Minkoff", 6.99m, "The Lion King" },
                    { 9, 9, "A breathtaking nature documentary", "David Attenborough", 5.99m, "Planet Earth II" },
                    { 10, 10, "An epic fantasy adventure", "Peter Jackson", 9.99m, "The Lord of the Rings" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
