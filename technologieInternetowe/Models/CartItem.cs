namespace technologieInternetowe.Models
{
    public class CartItem
    {
        public int FilmId { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? CoverImageUrl { get; set; }
    }
}
