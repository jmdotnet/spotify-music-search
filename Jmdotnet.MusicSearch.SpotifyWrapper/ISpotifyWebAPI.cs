using Jmdotnet.MusicSearch.SpotifyWrapper.Models;
using System.Threading.Tasks;

namespace Jmdotnet.MusicSearch.SpotifyWrapper
{
    public interface ISpotifyWebAPI
    {
        Task<SearchItem> SearchAllTypes(string query, int limit = 20, int offset = 0);
    }
}