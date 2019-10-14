

using System.Net;

namespace Jmdotnet.MusicSearch.SpotifyWrapper.Models
{
    public class ResponseInfo
    {
        public WebHeaderCollection Headers { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public static readonly ResponseInfo Empty = new ResponseInfo();
    }
}
