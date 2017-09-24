using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace WalletTracker.Infrastructure.Web
{
    public class WebClient : IWebClient
    {
        private HttpClient httpClient;

        public WebClient()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<JObject> GetAsync(string url)
        {
            var result = await this.httpClient.GetStringAsync(url);

            return JObject.Parse(result);
        }
    }
}