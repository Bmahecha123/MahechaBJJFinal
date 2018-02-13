using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views;
using MahechaBJJ.Views.EntryPages;
using Xamarin.Auth;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace MahechaBJJ
{
    public partial class App : Application
    {
        private BaseViewModel _baseViewModel;
        private Account account;

        public App()
        {
            InitializeComponent();
            _baseViewModel = new BaseViewModel();
            if (LoginCheck())
            {
                if (account.Username == "NO_ACCOUNT")
                {
                    MainPage = new MainTabbedPage(false);
                }
                else 
                {
                    MainPage = new MainTabbedPage(true);
                }
            }
            if (!LoginCheck())
            {
                var entryPage = new NavigationPage(new EntryPage());
                NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
                MainPage = entryPage;
            }
        }

        protected bool LoginCheck()
        {
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
            AppCenter.Start("ios=9b3870a4-b554-44a6-9fc3-26ae2354c956;" + "uwp={Your UWP App secret here};" +
                            "android=89e42d8d-063a-4f4c-ab30-7151b11e7395;",
                   typeof(Analytics), typeof(Crashes));
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
