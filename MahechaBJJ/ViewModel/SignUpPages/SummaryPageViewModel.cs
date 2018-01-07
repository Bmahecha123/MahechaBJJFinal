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

namespace MahechaBJJ.ViewModel.SignUpPages
{
    public class SummaryPageViewModel : INotifyPropertyChanged
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

        public SummaryPageViewModel()
        {
            _userService = new UserService();
            _accountService = new AccountService();
        }

        public async Task CreateUser(User user)
        {
            user.Email = user.Email.ToLower();
            user.SecretQuestionAnswer = user.SecretQuestionAnswer.ToLower();
            _user = await _userService.CreateUser(user);
        }

        public void SaveCredentials()
        {
            _account = new Account();
            _account.Username = _user.Email;
            _account.Properties.Add("Id", _user.Id);
            if (_user.Packages.GiJiuJitsu == true)
            {
                _account.Properties.Add("Package", "Gi");
            }
            else if (_user.Packages.NoGiJiuJitsu == true)
            {
                _account.Properties.Add("Package", "NoGi");
            }
            else 
            {
                _account.Properties.Add("Package", "GiAndNoGi");
            }

            _accountService.SaveCredentials(_account);
        }

        public bool UserExist(User user)
        {
            var userExist = _userService.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, user.Email, user.Password);

            if (userExist != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
