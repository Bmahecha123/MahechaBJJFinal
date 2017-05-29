using System;
using System.Net.Http;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using Newtonsoft.Json;

namespace MahechaBJJ.Service
{
    public class VimeoAPIService
    {
        HttpClient client;

        public VimeoAPIService()
        {
            client = new HttpClient();
        }

        public async Task<BaseInfo> GetVimeoInfo(string url) {
            
            var videoJson = await client.GetStringAsync(url);
            var vimeoJson = JsonConvert.DeserializeObject<BaseInfo>(videoJson);
            return vimeoJson;
        }

    }
}
