using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PixaImagenes.Entities;

namespace PixaImagenes
{
    public class PixaClient
    {
        public PixaClient(string key)
        {
            Key = key;
            Client = new HttpClient();
        }

        public PixaClient(string key, HttpClientHandler handler)
        {
            Key = key;
            Client = new HttpClient(handler);
        }

        public string Key { get; private set; }
        public HttpClient Client { get; }

        public async Task<Response> GetPhotos(string searchTerms)
        {
            var url =
                "https://pixabay.com/api/" +
                "?key=" + Key +
                "&q=" + System.Uri.EscapeDataString(searchTerms) +
                "&image_type=photo&per_page=60";
            var stringResponse = await Client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<Response>(stringResponse);
        }
    }
}