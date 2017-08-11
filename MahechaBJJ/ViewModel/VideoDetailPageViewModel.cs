using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel
{
    public class VideoDetailPageViewModel : INotifyPropertyChanged
    {
		private UserService _userService;
		private AccountService _accountService;

		private ObservableCollection<PlayList> _playlist;
		public ObservableCollection<PlayList> Playlist
		{
			get
			{
				return _playlist;
			}
			set
			{
				_playlist = value;
				OnPropertyChanged();
			}
		}

        public VideoDetailPageViewModel()
        {
			_userService = new UserService();
			_accountService = new AccountService();
        }

		public async Task GetUserPlaylists(string url, string id)
		{
			_playlist = await _userService.GetPlaylists(url + id);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
