using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Services;

namespace MahechaBJJ.ViewModel
{
    public class SearchPageViewModel
    {
		private VimeoAPIService _vimeoApiService;
		private BaseInfo _searchedVideos;

        public BaseInfo Videos {
            get {
                return _searchedVideos;
            }
            set {
                _searchedVideos = value;
                OnPropertyChanged();
            }
        }
        public SearchPageViewModel()
        {
            _vimeoApiService = new VimeoAPIService();
        }

        public async Task<bool> IsNextPageNullOrNot(String nextPage) {
            bool nextPageNull;
            _searchedVideos = await _vimeoApiService.GetVimeoInfo(nextPage);
            if (_searchedVideos == null) {
                nextPageNull = true;
            }
            else {
                nextPageNull = false;
            }
            return nextPageNull;
            
        }

        public async Task SearchVideo(String query) {

            _searchedVideos = await _vimeoApiService.GetVimeoInfo(query);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
