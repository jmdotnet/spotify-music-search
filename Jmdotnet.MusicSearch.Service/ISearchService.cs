using Jmdotnet.MusicSearch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jmdotnet.MusicSearch.Service
{
    public interface ISearchService
    {
        Task<IEnumerable<SearchResult>> Search(string query);
    }
}
