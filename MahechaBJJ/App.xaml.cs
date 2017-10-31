using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views;
using MahechaBJJ.Views.EntryPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ
{
    public partial class App : Application
    {
		private BaseViewModel _baseViewModel = new BaseViewModel();
        private Account account;

        public App()
        {
            InitializeComponent();
            //_baseViewModel.DeleteCredentials();
            if (LoginCheck())
            {
                MainPage = new MainTabbedPage();
            }
            if (!LoginCheck())
            {
                var entryPage = new NavigationPage(new EntryPage());
                NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
                MainPage = entryPage;
            }
        }

        protected bool LoginCheck(){
            
			account = _baseViewModel.GetAccountInformation();

            if(account == null){
                return false;
            }
            else {
                return true;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes

        }
    }
}
