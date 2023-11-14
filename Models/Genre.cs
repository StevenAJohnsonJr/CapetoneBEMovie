namespace CapstoneBEMovie.Models
{
    public class Genre
    {
        public int? Id { get; set; }
        public string? GenreName { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
