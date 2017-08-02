using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using MahechaBJJ.Views;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ
{
    public partial class App : Application
    {
		private const string VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
		private const string FINDUSER = "http://localhost:8080/user/findByEmail/";
		BaseViewModel _baseViewModel = new BaseViewModel();
        Account account;

        public App()
        {
            InitializeComponent();

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
