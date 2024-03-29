﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using Newtonsoft.Json;
using Xamarin.Auth;

namespace MahechaBJJ.Service
{
    public class UserService
    {
        private HttpClient client;
        private TimeSpan timeSpan;

        public UserService()
        {
            client = new HttpClient();
            //client.DefaultRequestHeaders.ConnectionClose = true;
            client.BaseAddress = new Uri(Constants.pivotalHost);
            //client.BaseAddress = new Uri(Constants.localHost);
            timeSpan = new TimeSpan(0, 0, 20);
            client.Timeout = timeSpan;
        }

		public async Task<User> FindUserByIdAsync(string url, string id)
		{
            try 
            {
                client.DefaultRequestHeaders.Add("X-Id", id);
				var userJson = await client.GetStringAsync(url);
				var user = JsonConvert.DeserializeObject<User>(userJson);
				return user;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
			
		}

		public async Task<User> FindUserByEmailAsync(string url, string email, string password)
		{
			client.DefaultRequestHeaders.Clear();
			try
			{
				client.DefaultRequestHeaders.Add("X-Email", email);
                client.DefaultRequestHeaders.Add("X-Password", password);
				var userJson = await client.GetStringAsync(url);
				var user = JsonConvert.DeserializeObject<User>(userJson);
                return user;
			}
			catch (HttpRequestException exception)
			{
				Console.WriteLine(exception.StackTrace);
				return null;
			}
		}

		public async Task<User> CreateUser(User user)
		{
			try 
            {
				string jsonObject = JsonConvert.SerializeObject(user);
				StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
				HttpResponseMessage response = await client.PostAsync(Constants.CREATEUSER, content);
				user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
				return user;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
		}

        public async Task<User> UpdateUser(User user)
        {
            try 
            {
                string jsonObject = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(Constants.EDITUSER, content);
                user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
                return user;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> AddPlaylist(PlayList playlist, string id)
        {
            try 
            {
				string jsonObject = JsonConvert.SerializeObject(playlist);
				StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
				var response = await client.PutAsync(Constants.ADDPLAYLIST + id, content);
                return response.IsSuccessStatusCode;
            }
            catch ( HttpRequestException ex)
            {
				Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<ObservableCollection<PlayList>> GetPlaylists(string url)
        {
                try
                {
                    var playListData = await client.GetStringAsync(url);
                    ObservableCollection<PlayList> playLists = JsonConvert.DeserializeObject<ObservableCollection<PlayList>>(playListData);
                    return playLists;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
        }

        public async Task<PlayList> GetPlaylist(string url, string playlistName)
        {
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Add("X-playlistName", playlistName);

            try
            {
				var playListData = await client.GetStringAsync(url);
				PlayList playlist = JsonConvert.DeserializeObject<PlayList>(playListData);
				return playlist;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public async Task<bool> UpdateUserPlaylists(string url, PlayList playlist)
        {
            string jsonObject = JsonConvert.SerializeObject(playlist);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

            try
            {
				var response = await client.PostAsync(url, content);
				return response.IsSuccessStatusCode;
			}
            catch (HttpRequestException ex)
            {
				Console.WriteLine(ex.Message);
				return false;
            }

        }

        public async Task<bool> DeleteVideoFromPlaylist(string url, PlayList playlist, string videoName)
        {
            string jsonObject = JsonConvert.SerializeObject(playlist);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Add("X-videoName", videoName);

            try 
            {
				var response = await client.PostAsync(url, content);
				return response.IsSuccessStatusCode;
            } 
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
		}

        public async Task<bool> ChangePassword(string id, string answer, string password)
        {
            client.DefaultRequestHeaders.Add("X-ID", id);
            client.DefaultRequestHeaders.Add("X-ANSWER", answer);
            client.DefaultRequestHeaders.Add("X-PASSWORD", password);
            try
            {
                var response = await client.PostAsync(Constants.CHANGEPASSWORD, null);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<User> GetUser(string email)
        {
            client.DefaultRequestHeaders.Add("X-EMAIL", email);

            try
            {
                var response = await client.GetStringAsync(Constants.GETUSER);
                var user = JsonConvert.DeserializeObject<User>(response);
                if (user != null)
                {
                    return user;
                } else {
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task DeleteUser(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("X-ID", user.Id);
                await client.DeleteAsync("user");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
	}
}
