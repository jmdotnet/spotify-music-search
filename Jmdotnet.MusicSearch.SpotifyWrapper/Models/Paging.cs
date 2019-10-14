using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class Paging<T> : Base
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        public bool HasNextPage()
        {
            return Next != null;
        }

        public bool HasPreviousPage()
        {
            return Previous != null;
        }
    }
}
