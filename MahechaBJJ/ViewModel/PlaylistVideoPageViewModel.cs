using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel
{
    public class PlaylistVideoPageViewModel : INotifyPropertyChanged
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

        public PlaylistVideoPageViewModel()
        {
			_userService = new UserService();
			_accountService = new AccountService();
        }

        public async Task DeleteVideoFromPlaylist(string url, string id, PlayList playlist, string videoName)
        {
            _successful = await _userService.DeleteVideoFromPlaylist(url + id, playlist, videoName);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
