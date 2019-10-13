using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Infrastructure.Auth
{
    public class ClientCredentialAuth
    {
        public string ClientSecret { get; private set; }
        public string ClientId { get; private set; }

        public ClientCredentialAuth(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }


    }
}
