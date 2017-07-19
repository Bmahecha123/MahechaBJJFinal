using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MahechaBJJ.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
		private bool _isBusy;
		public bool IsBusy
		{
			get { return _isBusy; }
			set
			{
				_isBusy = value;
				OnPropertyChanged();
			}
		}

        public BaseViewModel()
        {
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
