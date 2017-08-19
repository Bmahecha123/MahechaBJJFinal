using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel
{
    public class SearchPageViewModel
    {
		private VimeoAPIService _vimeoApiService;

		private BaseInfo _searchedVideos;
        public BaseInfo Videos {
            get 
            {
                return _searchedVideos;
            }
            set 
            {
                _searchedVideos = value;
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

        public SearchPageViewModel()
        {
            _vimeoApiService = new VimeoAPIService();
        }

        public async Task SearchVideo(String query) {

            _searchedVideos = await _vimeoApiService.GetVimeoInfo(query);

			if (_searchedVideos != null)
			{
				_successful = true;
			}
			else
			{
				_successful = false;
			}
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
