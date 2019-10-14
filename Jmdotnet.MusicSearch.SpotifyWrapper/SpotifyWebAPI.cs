﻿using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Jmdotnet.MusicSearch.SpotifyWrapper.Models;
using Jmdotnet.MusicSearch.SpotifyWrapper.Enums;
using System.Collections.Generic;

namespace Jmdotnet.MusicSearch.SpotifyWrapper
{
    public class SpotifyWebAPI
    {
        private string _token;
        private string _baseUrl = "https://api.spotify.com/v1/";

        public SpotifyWebAPI(string token)
        {
            _token = token;
        }

        public async Task<SearchItem> SearchAllTypes(string query, int limit = 20, int offset = 0)
        {
            return await _baseUrl.AppendPathSegment("search")
                    .WithOAuthBearerToken(_token)
                    .SetQueryParams(new { 
                                            q = query,
                                            type = $"{SearchType.album},{SearchType.artist},{SearchType.playlist},{SearchType.track}",
                                            limit = limit,
                                            offset = offset 
                                        }).GetJsonAsync<SearchItem>();

        }


    }
}
