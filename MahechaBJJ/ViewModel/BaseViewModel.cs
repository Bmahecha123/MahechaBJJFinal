using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //members
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

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
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
        private Account _account;
        public Account Account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
                OnPropertyChanged();
            }
        }

        public BaseViewModel()
        {
            _vimeoApiService = new VimeoAPIService();
        }

        //methods
		public async Task GetVimeo(string url)
		{
			_baseInfo = await _vimeoApiService.GetVimeoInfo(url);
		}

        public Account GetAccountInformation()
        {
#if __IOS__
            _account = AccountStore.Create().FindAccountsForService(Constants.AppName).FirstOrDefault();
#endif
#if __ANDROID__
            _account = AccountStore.Create(Forms.Context).FindAccountsForService(Constants.AppName).FirstOrDefault();
#endif
            return Account;
        }

        public void DeleteCredentials()
        {
#if __IOS__
            _account = AccountStore.Create().FindAccountsForService(Constants.AppName).FirstOrDefault();
            if (_account != null)
            {
                AccountStore.Create().Delete(_account, Constants.AppName);
            }
#endif
#if __ANDROID__
            _account = AccountStore.Create(Forms.Context).FindAccountsForService(Constants.AppName).FirstOrDefault();
            if (_account != null)
            {
                AccountStore.Create(Forms.Context).Delete(_account, Constants.AppName);
            }
#endif
        }

        public async Task<User> FindUserByIdAsync(string url, string id)
        {
            HttpClient client = new HttpClient();
            var userJson = await client.GetStringAsync(url + id);
            _user = JsonConvert.DeserializeObject<User>(userJson);

            return User;
        }

		public void SaveCredentials(string userName, string password, string id)
		{
			_account = new Account();
			_account.Username = userName;
			_account.Properties.Add("Id", id);
#if __IOS__
			AccountStore.Create().Save(_account, Constants.AppName);
#endif
#if __ANDROID__
            AccountStore.Create(Forms.Context).Save(_account, Constants.AppName);
#endif
		}

        public async Task<User> FindUserByEmailAsync(string url, string email)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Email", email);
            try{
				var userJson = await client.GetStringAsync(url);
				_user = JsonConvert.DeserializeObject<User>(userJson);
			}
            catch(HttpRequestException exception){
                Console.WriteLine(exception.StackTrace); 
            }
            return User;
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
