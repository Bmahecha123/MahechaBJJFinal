using System;
using System.Net.Http;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using Newtonsoft.Json;

namespace MahechaBJJ.Services
{
    public class VimeoAPIService
    {
        public VimeoAPIService()
        {
        }

        public async Task<BaseInfo> GetVimeoInfo(string url) {
            HttpClient client = new HttpClient();
            var videoJson = await client.GetStringAsync(url);
            var vimeoJson = JsonConvert.DeserializeObject<BaseInfo>(videoJson);
            return vimeoJson;
        }


    }
}
