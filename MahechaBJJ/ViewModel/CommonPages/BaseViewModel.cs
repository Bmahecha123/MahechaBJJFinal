﻿using System;
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

namespace MahechaBJJ.ViewModel.CommonPages
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //members
		private VimeoAPIService _vimeoApiService;
        private UserService _userService;
        private AccountService _accountService;

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

        private bool _successful;
        public bool Successful
        {
            get 
            {
                return _successful;
            }
            set
            {
                _successful = value;
                OnPropertyChanged();
            }
        }

        public BaseViewModel()
        {
            _vimeoApiService = new VimeoAPIService();
            _userService = new UserService();
            _accountService = new AccountService();
        }

        //methods
		public async Task GetVimeo(string url)
		{
			_baseInfo = await _vimeoApiService.GetVimeoInfo(url);

            if (_baseInfo != null)
            {
                _successful = true;
            } else {
                _successful = false;
            }
		}

        public Account GetAccountInformation()
        {
            _account = _accountService.GetAccountInformation();

            return Account;
        }

        public void DeleteCredentials()
        {
            _accountService.DeleteCredentials();
        }

        public async Task<User> FindUserByIdAsync(string url, string id)
        {
            _user = await _userService.FindUserByIdAsync(url, id);

			if (_user != null)
			{
				_successful = true;
			}
			else
			{
				_successful = false;
			}

            return User;
        }

		public void SaveCredentials(string userName, string password, string id)
		{
			_account = new Account();
			_account.Username = userName;
			_account.Properties.Add("Id", id);

            _accountService.SaveCredentials(_account);
		}

        public async Task<User> FindUserByEmailAsync(string url, string email, string password)
        {
            _user = await _userService.FindUserByEmailAsync(url, email, password);

			if (_user != null)
			{
				_successful = true;
			}
			else
			{
				_successful = false;
			}

            return User;
        }

        public async Task<bool> ChangePassword(string url, User user)
        {
            bool success = await _userService.ChangePassword(url, user);
            return success;
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
