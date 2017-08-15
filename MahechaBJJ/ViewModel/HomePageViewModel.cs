﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel
{
    public class HomePageViewModel : INotifyPropertyChanged
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

        public HomePageViewModel()
        {
            _vimeoApiService = new VimeoAPIService();
        }

        public async Task GetVimeo(string url)
		{
			_baseInfo = await _vimeoApiService.GetVimeoInfo(url);
            if (_baseInfo == null)
            {
                _successful = false;
            } else {
                _successful = true;
            }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
