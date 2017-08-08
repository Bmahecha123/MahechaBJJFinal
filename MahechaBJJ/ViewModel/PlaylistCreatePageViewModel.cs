using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel
{
    public class PlaylistCreatePageViewModel : INotifyPropertyChanged
    {
        private UserService _userService;

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

        public PlaylistCreatePageViewModel()
        {
            _userService = new UserService();
        }

        public void CreatePlaylist(PlayList playlist, string id)
        {
            _userService.AddPlaylist(playlist, id);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
