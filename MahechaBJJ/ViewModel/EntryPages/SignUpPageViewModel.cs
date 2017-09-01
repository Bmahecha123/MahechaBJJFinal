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
using MahechaBJJ.Service;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.ViewModel.EntryPages
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        private Dictionary<String, string> secretQuestions;
        private UserService _userService;
        private AccountService _accountService;

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
            _userService = new UserService();
            _accountService = new AccountService();
        }

        public async Task<User> CreateUser(string name, string email, string password, string secretQuestion1,
                               string secretQuestionAnswer1, string secretQuestion2, string secretQuestionAnswer2, string beltColor)
        {
            _user = new User();
            _user.Name = name;
            _user.Email = email;
            _user.password = password;
            secretQuestions = new Dictionary<string, string>();
            secretQuestions.Add(secretQuestion1, secretQuestionAnswer1);
            secretQuestions.Add(secretQuestion2, secretQuestionAnswer2);
            _user.SecretQuestions = secretQuestions;
            _user.Belt = beltColor;

            _user = await _userService.CreateUser(_user);

            return User;
        }

        public void SaveCredentials(string userName, string password, string id)
        {
            _account = new Account();
            _account.Username = userName;
            _account.Properties.Add("Id", id);

            _accountService.SaveCredentials(_account);
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
