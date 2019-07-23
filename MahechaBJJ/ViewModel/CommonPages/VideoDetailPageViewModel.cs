using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel.CommonPages
{
    public class VideoDetailPageViewModel : INotifyPropertyChanged
    {
		private UserService _userService;

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

        public VideoDetailPageViewModel()
        {
			_userService = new UserService();
        }

		public async Task GetUserPlaylists(string url, string id)
		{
			_playlist = await _userService.GetPlaylists(url + id);
		}

        public async Task UpdateUserPlaylist(string url, string id, PlayList playlist)
        {
            _successful = await _userService.UpdateUserPlaylists(url + id, playlist);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
