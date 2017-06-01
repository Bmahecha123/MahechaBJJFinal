using MahechaBJJ.Views;
using Xamarin.Forms;

namespace MahechaBJJ
{
    public partial class App : Application
    {
        public App()
        {
			 InitializeComponent();

            MainPage = new NavigationPage(new FacebookPage());
			 //MainPage = new NavigationPage(new Views.EntryPage());
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
