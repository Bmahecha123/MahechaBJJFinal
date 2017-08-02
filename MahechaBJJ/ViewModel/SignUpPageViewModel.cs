using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.ViewModel
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        private Dictionary<String, string> secretQuestions;

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

        public SignUpPageViewModel()
        {
        }

        public async Task<User> CreateUser(string name, string email, string password, string secretQuestion1,
                               string secretQuestionAnswer1, string secretQuestion2, string secretQuestionAnswer2)
        {
            _user = new User();
            _user.Name = name;
            _user.Email = email;
            _user.password = password;
            secretQuestions = new Dictionary<string, string>();
            secretQuestions.Add(secretQuestion1, secretQuestionAnswer1);
            secretQuestions.Add(secretQuestion2, secretQuestionAnswer2);
            _user.SecretQuestions = secretQuestions;

            HttpClient client = new HttpClient();
            string jsonObject = JsonConvert.SerializeObject(_user);
            StringContent content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/user/create", content);

            _user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());

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

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
