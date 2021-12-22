using System.Collections.Generic;

namespace CinefiliaApp.Models
{
    public class MoviePage
    {
        public int Page { get; set; }
        public List<Movie> Results { get; set; } = new();
        public Dates Dates { get; set; }
    }
}
