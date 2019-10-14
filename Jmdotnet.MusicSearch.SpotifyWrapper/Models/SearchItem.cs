using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class SearchItem : Base
    {
        [JsonProperty("artists")]
        public Paging<FullArtist> Artists { get; set; }

        [JsonProperty("albums")]
        public Paging<SimpleAlbum> Albums { get; set; }

       /* [JsonProperty("tracks")]
        public Paging<FullTrack> Tracks { get; set; }

        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }*/
    }
}
