using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class ApiMovieController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]

        public async Task<IActionResult> Index()
        {

            List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/top32"),
                Headers =
    {
        { "X-RapidAPI-Key", "d1c776d265msh036710a77b82f9ep18a140jsnc813f6bd9f8b" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                //apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                ApiMovieViewModel apiMovie = JsonConvert.DeserializeObject<ApiMovieViewModel>(body);
                apiMovies.Add(apiMovie); 

                return View(apiMovies);
            }
        }
    }
}
