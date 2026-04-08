    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace technologieInternetowe.Models
    {
        public class Film
        {
            [Key]
            public int FilmId { get; set; }

            [Required(ErrorMessage = "Nie podano tytułu")]
            public string Title { get; set; } = string.Empty;

            public string Director { get; set; } = string.Empty;

            public string Desc { get; set; } = string.Empty;

        [Display(Name = "Okładka (URL)")]
        [Url(ErrorMessage = "Podaj poprawny adres URL")]
        public string? CoverImageUrl { get; set; }

            public decimal? Price { get; set; }

            [ForeignKey("Category")]
            public int CategoryId { get; set; }

            public Category? Category { get; set; }
        }
    }

