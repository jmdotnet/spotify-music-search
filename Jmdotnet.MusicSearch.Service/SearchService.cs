using Jmdotnet.MusicSearch.Domain;
using Jmdotnet.MusicSearch.SpotifyWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jmdotnet.MusicSearch.Service
{
    public class SearchService : ISearchService
    {
        private readonly ISpotifyWebAPI _spotifyWebAPI;
        private readonly string _token;

        public SearchService(ISpotifyWebAPI spotifyWebAPI)
        {
            _spotifyWebAPI = spotifyWebAPI;
        }

        public async Task<IEnumerable<SearchResult>> Search(string query) {

            var spotifySearchResult = await _spotifyWebAPI.SearchAllTypes(query);

            return spotifySearchResult.Artists.Items.Select(x => new SearchResult(x.Name)).ToList();
        }
    }
}
