using GifsApp.Model;
using GifsApp.Service;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(GifsService))]
namespace GifsApp.Service
{
   public class GifsService
   {
      private const string url = "http://api.giphy.com/v1/gifs/search";
      private const string apiKey = "YOUR_API_KEY";

      HttpClient httpClient;

      HttpClient Client => httpClient ?? (httpClient = new HttpClient());

      public async Task<Gif> GetGifs(string value)
      {
         // var httpClient = new HttpClient();
         var songList = await Client.GetStringAsync(string.Format($"{ url }?api_key={ apiKey }&q={ value }&limit=10&offset=0&rating=g&lang=en"));
         return JsonConvert.DeserializeObject<Gif>(songList);
      }
   }
}
