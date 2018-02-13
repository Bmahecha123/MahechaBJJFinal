using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.ViewModel.EntryPages
{
    public class EntryPageViewModel : INotifyPropertyChanged
    {
        private PurchaseService _purchaseService;

        private bool _hasGiAndNoGiPackage;
        public bool HasGiAndNoGiPackage 
        {
            get {
                return _hasGiAndNoGiPackage;
            } set {
                _hasGiAndNoGiPackage = value;
                OnPropertyChanged();
            }
        }

        private bool _hasGiPackage;
        public bool HasGiPackage
        {
            get {
                return _hasGiPackage;
            } set {
                _hasGiPackage = value;
                OnPropertyChanged();
            }
        }

        private bool _hasNoGiPackage;
        public bool HasNoGiPackage
        {
            get {
                return _hasNoGiPackage;
            } set {
                _hasNoGiPackage = value;
                OnPropertyChanged();
            }
        }

        public EntryPageViewModel()
		{
            _purchaseService = new PurchaseService();
		}

        public async Task CheckIfUserHasPackage()
        {
            _hasGiAndNoGiPackage = await _purchaseService.WasPackagePurchased(Constants.GIANDNOGIPACKAGE);
            _hasGiPackage = await _purchaseService.WasPackagePurchased(Constants.GIPACKAGE);
            _hasNoGiPackage = await _purchaseService.WasPackagePurchased(Constants.NOGIPACKAGE);
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
