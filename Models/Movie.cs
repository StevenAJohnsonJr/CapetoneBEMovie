namespace CapetoneBEMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        public string Rating { get; set; }
        public bool IsForeign { get; set; }
        public string Rated { get; set; }
        public string SteamingOn { get; set; }
        public string ImgUrl { get; set; }
        public User? User { get; set; }
        public List<Director> Director { get; set;}

    }
}
