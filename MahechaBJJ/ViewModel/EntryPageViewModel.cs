using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

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
    }
}
