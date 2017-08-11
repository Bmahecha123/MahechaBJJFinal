using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using Newtonsoft.Json;
using Xamarin.Auth;

namespace MahechaBJJ.Service
{
    public class UserService
    {
        HttpClient client;

        public UserService()
        {
            client = new HttpClient();
        }

		public async Task<User> FindUserByIdAsync(string url, string id)
		{
			var userJson = await client.GetStringAsync(url + id);
			var user = JsonConvert.DeserializeObject<User>(userJson);

            return user;
		}

		public async Task<User> FindUserByEmailAsync(string url, string email)
		{
            User user = null;
			client.DefaultRequestHeaders.Add("X-Email", email);
			try
			{
				var userJson = await client.GetStringAsync(url);
				user = JsonConvert.DeserializeObject<User>(userJson);
			}
			catch (HttpRequestException exception)
			{
				Console.WriteLine(exception.StackTrace);
			}
			return user;
		}

		public async Task<User> CreateUser(User user)
		{
			
 			string jsonObject = JsonConvert.SerializeObject(user);
			StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

			HttpResponseMessage response = await client.PostAsync(Constants.CREATEUSER, content);

			user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());

			return user;
		}

        public async void AddPlaylist(PlayList playlist, string id)
        {
            string jsonObject = JsonConvert.SerializeObject(playlist);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

            await client.PutAsync(Constants.ADDPLAYLIST + id, content);
        }

        public async Task<ObservableCollection<PlayList>> GetPlaylists(string url)
        {
            var playListData = await client.GetStringAsync(url);
            ObservableCollection<PlayList> playLists = JsonConvert.DeserializeObject<ObservableCollection<PlayList>>(playListData);

            return playLists;
        }

        public async Task<bool> UpdateUserPlaylists(string url, PlayList playlist)
        {
            string jsonObject = JsonConvert.SerializeObject(playlist);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            return response.IsSuccessStatusCode;
            //add a status code value to view model
        }
	}
}
