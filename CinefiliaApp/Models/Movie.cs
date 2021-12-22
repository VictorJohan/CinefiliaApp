using System.Collections.Generic;

namespace CinefiliaApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string title { get; set; }
        public bool Video { get; set; }
        public float Vote_average { get; set; }
        public int Vote_count { get; set; }
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public List<int> Genre_ids { get; set; }
        public string OriginalTitle { 
            get {
                if (Original_title.Length > 25)
                    return Original_title.Substring(0, 23) + "...";
                else
                    return Original_title;
                
            } set {; } }
    }
}
