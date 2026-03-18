namespace technologieInternetowe.Models
{
    public class HomeDashboardViewModel
    {
        public int FilmsCount { get; set; }
        public int CategoriesCount { get; set; }
        public List<Film> LatestFilms { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
    }
}
