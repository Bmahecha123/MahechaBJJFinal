using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel.PlaylistPages
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

        public PlaylistCreatePageViewModel()
        {
            _userService = new UserService();
        }

        public async Task CreatePlaylist(PlayList playlist, string id)
        {
            _successful = await _userService.AddPlaylist(playlist, id);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
