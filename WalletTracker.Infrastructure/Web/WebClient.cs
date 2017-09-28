using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace WalletTracker.Infrastructure.Web
{
    public class WebClient : IWebClient
    {
        private readonly HttpClient httpClient;

        public WebClient()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<JObject> GetJObjectAsync(string url)
        {
            var result = await this.httpClient.GetStringAsync(url);

            return JObject.Parse(SanitizeJsonString(result));
        }

        public async Task<JArray> GetJArrayAsync(string url)
        {
            var result = await this.httpClient.GetStringAsync(url);

            return JArray.Parse(SanitizeJsonString(result));
        }

        private static string SanitizeJsonString(string value)
        {
            const string BannedCharacters = "\\\t\n\r";
            return BannedCharacters.ToCharArray().Aggregate(value, (current, bannedChar) => current.Replace(bannedChar.ToString(), string.Empty));
        }
    }
}
