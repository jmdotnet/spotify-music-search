using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper
{
    public class AuthenticationConfig
    {
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public string AccessTokenUrl { get; private set; }


        public AuthenticationConfig(string clientId, string clientSecret, string accessTokenUrl) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AccessTokenUrl = accessTokenUrl;
        }

    }
}
