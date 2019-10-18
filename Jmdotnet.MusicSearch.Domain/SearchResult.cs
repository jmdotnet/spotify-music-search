using System;
using System.Collections.Generic;
using Jmdotnet.MusicSearch.Domain.Enums;


namespace Jmdotnet.MusicSearch.Domain
{
    public class SearchResult
    {
        public string Name { get; private set; }
        public List<Image> Images {get; private set; }

        public SearchType Type { get; private set; }


        public SearchResult(string name, List<Image> images, SearchType type)
        {
            Name = name;
            Images = images;
            Type = type;
        }
    }
}
