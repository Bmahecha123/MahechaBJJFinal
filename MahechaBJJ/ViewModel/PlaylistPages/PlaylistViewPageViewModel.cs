using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel.PlaylistPages
{
    public class PlaylistViewPageViewModel : INotifyPropertyChanged
    {
        private UserService _userService;

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

        public PlaylistViewPageViewModel()
        {
            _successful = true;
            _userService = new UserService();
        }

        public async Task GetUserPlaylists(string url, string id)
        {
				_playlist = await _userService.GetPlaylists(url + id);
				if (_playlist == null)
				{
					_successful = false;
				}
				else
				{
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
