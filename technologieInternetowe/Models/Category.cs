namespace technologieInternetowe.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Film> Films { get; set; } = new List<Film>();
    }
}
