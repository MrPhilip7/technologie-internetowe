using Microsoft.EntityFrameworkCore;
using technologieInternetowe.Models;

namespace technologieInternetowe.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Action", Description = "Action films" },
                new Category { Id = 2, Name = "Comedy", Description = "Comedy films" },
                new Category { Id = 3, Name = "Drama", Description = "Drama films" },
                new Category { Id = 4, Name = "Horror", Description = "Horror films" },
                new Category { Id = 5, Name = "Sci-Fi", Description = "Science Fiction films" },
                new Category { Id = 6, Name = "Romance", Description = "Romantic films" },
                new Category { Id = 7, Name = "Thriller", Description = "Thriller films" },
                new Category { Id = 8, Name = "Animation", Description = "Animated films" },
                new Category { Id = 9, Name = "Documentary", Description = "Documentary films" },
                new Category { Id = 10, Name = "Fantasy", Description = "Fantasy films" },
            };
            modelBuilder.Entity<Category>().HasData(categories);

            var films = new List<Film>
            {
                new Film { FilmId = 1, Title = "Inception", Director = "Christopher Nolan", Desc = "A mind-bending thriller", Price = 9.99m, CategoryId = 5 },
                new Film { FilmId = 2, Title = "The Dark Knight", Director = "Christopher Nolan", Desc = "A superhero crime film", Price = 9.99m, CategoryId = 1 },
                new Film { FilmId = 3, Title = "Pulp Fiction", Director = "Quentin Tarantino", Desc = "Crime anthology film", Price = 7.99m, CategoryId = 1 },
                new Film { FilmId = 4, Title = "The Godfather", Director = "Francis Ford Coppola", Desc = "A crime family saga", Price = 8.99m, CategoryId = 3 },
                new Film { FilmId = 5, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "A story of hope", Price = 8.99m, CategoryId = 3 },
                new Film { FilmId = 6, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Desc = "A sci-fi action film", Price = 9.99m, CategoryId = 5 },
                new Film { FilmId = 7, Title = "The Silence of the Lambs", Director = "Jonathan Demme", Desc = "A psychological thriller", Price = 7.99m, CategoryId = 7 },
                new Film { FilmId = 8, Title = "The Lion King", Director = "Roger Allers, Rob Minkoff", Desc = "An animated adventure", Price = 6.99m, CategoryId = 8 },
                new Film { FilmId = 9, Title = "Planet Earth II", Director = "David Attenborough", Desc = "A breathtaking nature documentary", Price = 5.99m, CategoryId = 9 },
                new Film { FilmId = 10, Title = "The Lord of the Rings", Director = "Peter Jackson", Desc = "An epic fantasy adventure", Price = 9.99m, CategoryId = 10 },
                new Film { FilmId = 111, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "A man with a low IQ has great accomplishments.", Price = 7.99m, CategoryId = 3 },
                new Film { FilmId = 112, Title = "Interstellar", Director = "Christopher Nolan", Desc = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", Price = 10.99m, CategoryId = 5 },
                new Film { FilmId = 113, Title = "Gladiator", Director = "Ridley Scott", Desc = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family.", Price = 8.99m, CategoryId = 1 },
                new Film { FilmId = 114, Title = "The Green Mile", Director = "Frank Darabont", Desc = "The lives of guards on Death Row are affected by one of their charges.", Price = 6.99m, CategoryId = 3 },
                new Film { FilmId = 115, Title = "The Avengers", Director = "Joss Whedon", Desc = "Earth's mightiest heroes must come together and learn to fight as a team.", Price = 11.99m, CategoryId = 1 },
            };
            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
