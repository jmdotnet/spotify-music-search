using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class Error
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
