using Newtonsoft.Json;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}