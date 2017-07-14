using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.ViewModel
{
    public class EntryPageViewModel : INotifyPropertyChanged
    {
		private VimeoAPIService _vimeoApiService;
		
        private BaseInfo _baseInfo;
		public BaseInfo VimeoInfo
		{
			get
			{
				return _baseInfo;
			}
			set
			{
				_baseInfo = value;
				OnPropertyChanged();
			}
		}

        private User _user;
        public User User
        {
			get
			{
				return _user;
			}
			set
			{
                _user = value;
				OnPropertyChanged();
			}
        }

        public EntryPageViewModel()
		{
            _vimeoApiService = new VimeoAPIService();
		}

		public async Task GetVimeo(string url)
		{
			_baseInfo = await _vimeoApiService.GetVimeoInfo(url);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

        public async Task GetGoogleInfo (OAuth2Request request) {
			var response = await request.GetResponseAsync();
			if (response != null)
			{
				// Deserialize the data and store it in the account store
				// The users email address will be used to identify data in SimpleDB
				string userJson = await response.GetResponseTextAsync();
				_user = JsonConvert.DeserializeObject<User>(userJson);
			}
        }
    }
}
