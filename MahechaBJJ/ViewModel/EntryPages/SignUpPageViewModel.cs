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

        public async Task<User> CreateUser(string name, string email, string password, string secretQuestion,
                               string secretQuestionAnswer, string beltColor)
        {
            _user = new User();
            _user.Name = name;
            _user.Email = email;
            _user.password = password;
            _user.SecretQuestion = 
            _user.Belt = beltColor;
            _user.SecretQuestion = secretQuestion;
            _user.SecretQuestionAnswer = secretQuestionAnswer;
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
