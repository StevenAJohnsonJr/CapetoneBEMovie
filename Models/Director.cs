namespace CapstoneBEMovie.Models
{
    public class Director
    {
        public int? Id { get; set; }
        public string? DirectorName { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
