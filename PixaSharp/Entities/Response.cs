using System.Collections.Generic;

namespace PixaImagenes.Entities
{
    public class Response
    {
        public int TotalHits { get; set; }
        public List<PixaImage> Hits { get; set; }
        public int Total { get; set; }
    }
}