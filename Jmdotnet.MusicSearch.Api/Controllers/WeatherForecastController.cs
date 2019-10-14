using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jmdotnet.MusicSearch.SpotifyWrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Jmdotnet.MusicSearch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            var token = AuthenticationManager.GetToken(new AuthenticationConfig("5eb90c111ca843f8ab790569f39c077d", "3abeddabe063405db9280068cf8dee76", " https://accounts.spotify.com/api/token")).Result;

            var spotifyWebApi = new SpotifyWebAPI(token.access_token);

            var result = spotifyWebApi.SearchAllTypes("Mahler").Result;

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
