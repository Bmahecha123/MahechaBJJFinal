using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel.PlaylistPages
{
    public class PlaylistDetailPageViewModel : INotifyPropertyChanged
    {
		private UserService _userService;
		private AccountService _accountService;

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

        private PlayList _playlist;
        public PlayList Playlist
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

        public PlaylistDetailPageViewModel()
		{
			_userService = new UserService();
			_accountService = new AccountService();
		}

        public async Task DeleteUserPlaylist(string url, string id, PlayList playlist)
        {
            _successful = await _userService.UpdateUserPlaylists(url + id, playlist);
        }

        public async Task FindUserPlaylist(string url, string id, string playListName)
        {
            _playlist = await _userService.GetPlaylist(url + id, playListName);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
