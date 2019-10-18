using Jmdotnet.MusicSearch.Domain;
using Jmdotnet.MusicSearch.SpotifyWrapper;
using Jmdotnet.MusicSearch.SpotifyWrapper.Models;
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

            return spotifySearchResult.Albums.Items.Select(x => new SearchResult(x.Name, mapToDomainImage(x.Images), Domain.Enums.SearchType.artist)).OrderBy(c => c.Name).ToList();
        }

        private List<Domain.Image> mapToDomainImage(List<SpotifyWrapper.Models.Image> images)
        {
            var mapped = new List<Domain.Image>();

            images.ForEach(image => {

                mapped.Add(new Domain.Image(image.Url, image.Width, image.Height));

            });

            return mapped;
        }
    }
}
