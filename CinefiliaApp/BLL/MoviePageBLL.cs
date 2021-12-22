using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CinefiliaApp.Models;
using CinefiliaApp.Utils;

namespace CinefiliaApp.BLL
{
    public class MoviePageBLL
    {
        private HttpClient Http { get; set; }
        public string Language { get; set; }
        public MoviePageBLL(HttpClient _http, string language)
        {
            Http = _http;
            Language = language;
        }


        public async Task<MoviePage> GetMoviesByPage(int pageNumber)
        {
            MoviePage page = null;

            page = await Http.GetFromJsonAsync<MoviePage>($"{Host.TheMovieDBHost}movie/popular?api_key={Host.Key}&language={Language}&page={pageNumber}");
            if (page != null)
                return page;

            return new MoviePage();
        }
        public async Task<MoviePage> GetMoviesByPageAndGenre(int pageNumber, int genreId)
        {
            MoviePage page = null;
            page = await Http.GetFromJsonAsync<MoviePage>($"{Host.TheMovieDBHost}discover/movie?api_key={Host.Key}&with_genres={genreId}&page={pageNumber}&language={Language}");
            if (page != null)
                return page;

            return new MoviePage();
        }
        
        public async Task<MoviePage> GetMoviesInTheathersByPage(int pageNumber)
        {
            MoviePage page = null;
            page = await Http.GetFromJsonAsync<MoviePage>($"{Host.TheMovieDBHost}movie/now_playing?api_key={Host.Key}&language={Language}&page={pageNumber}");
            if (page != null)
                return page;

            return new MoviePage();
        }
        
        public async Task<MoviePage> GetMoviesUpComingByPage(int pageNumber)
        {
       
            MoviePage page = null;
            page = await Http.GetFromJsonAsync<MoviePage>($"{Host.TheMovieDBHost}movie/upcoming?api_key={Host.Key}&language={Language}&page={pageNumber}");
            if (page != null)
                return page;

            return new MoviePage();
        }

        public async Task GetImage(string path)
        {

            var resul = await Http.GetAsync("http://image.tmdb.org/t/p/w500/"+path);
            var aux = resul.Content.ReadAsStringAsync();
            int a = 2;
        }
    }
}
