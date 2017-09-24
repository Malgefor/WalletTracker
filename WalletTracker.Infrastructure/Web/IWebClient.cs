using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WalletTracker.Infrastructure.Web
{
    public interface IWebClient
    {
        Task<JObject> GetAsync(string url);
    }
}