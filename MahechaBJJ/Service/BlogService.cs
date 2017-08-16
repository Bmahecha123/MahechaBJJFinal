using System;
using System.Net.Http;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using Newtonsoft.Json;
using static MahechaBJJ.Model.BlogPosts;

namespace MahechaBJJ.Service
{
    public class BlogService
    {
        HttpClient client;

        public BlogService()
        {
            client = new HttpClient();
        }

        public async Task<RootObject> GetBlogPosts(string url)
        {
			try
			{
				var responseJson = await client.GetStringAsync(url);
                var blogJson = JsonConvert.DeserializeObject<RootObject>(responseJson);
                return blogJson;
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
        }
    }
}
