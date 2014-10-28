using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CommonLib
{
    public class WebFetcher
    {

        public async Task<string> GetWord()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("http://api.wordnik.com:80/v4/words.json/wordOfTheDay?api_key=06d5af30ca8a8fc0190080bb1da0a46e2718a483a4cf1cda9");
            var root = JObject.Parse(json);
            var word = root.GetValue("word").ToString();
            return word;
        }
    }
}
