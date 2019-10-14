using Newtonsoft.Json;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class PlaylistTrackCollection
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

}