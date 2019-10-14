using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.Domain
{
    public class SearchResult
    {
        public string ArtistName { get; private set; }

        public SearchResult(string artistName)
        {
            ArtistName = artistName;
        }
    }
}
