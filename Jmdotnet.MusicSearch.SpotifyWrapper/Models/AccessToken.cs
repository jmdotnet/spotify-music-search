﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public string token_type  { get; set; }
        public long expires_in { get; set; }
    }
}
