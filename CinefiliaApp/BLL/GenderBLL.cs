using CinefiliaApp.Interface;
using CinefiliaApp.Models;
using CinefiliaApp.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CinefiliaApp.BLL
{
    public class GenderBLL
    {
        private HttpClient Http { get; set; }
        public string Language { get; set; }
        public GenderBLL(HttpClient _http, string language)
        {
            Http = _http;
            Language = language;
        }


        public async Task<List<Genres>> GetListAsync()
        {
            Gender genders = null;

            genders = await Http.GetFromJsonAsync<Gender>($"{Host.TheMovieDBHost}genre/movie/list?api_key={Host.Key}&language={Language}");
            if (genders != null)
                return genders.Genres;

            return new List<Genres>();
        }

       
    }
}
