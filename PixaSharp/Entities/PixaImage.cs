using Newtonsoft.Json;

namespace PixaImagenes.Entities
{
    public class PixaImage
    {
        public int PreviewHeight { get; set; }
        public int Likes { get; set; }
        public int Favorites { get; set; }
        public string Tags { get; set; }
        public int WebFormatHeight { get; set; }
        public int Views { get; set; }
        public int WebFormatWidth { get; set; }
        public int PreviewWidth { get; set; }
        public int Comments { get; set; }
        public int Downloads { get; set; }
        public string PageUrl { get; set; }
        public string PreviewUrl { get; set; }
        public string WebformatUrl { get; set; }
        public int ImageWidth { get; set; }

        [JsonProperty(PropertyName = "UserId")]
        public int User_Id { get; set; }

        public string User { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public string UserImageUrl { get; set; }
        public int ImageHeight { get; set; }
    }
}