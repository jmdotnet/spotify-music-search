using System;
using System.Collections.Generic;
using System.Text;

namespace Jmdotnet.MusicSearch.Domain
{
    public class Image
    {
      
        public string Url { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Image(string url, int width, int height)
        {
            Url = url;
            Width = width;
            Height = height;
        }
    }

}
