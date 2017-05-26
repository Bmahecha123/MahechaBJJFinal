using Xamarin.Forms;

namespace MahechaBJJ
{
	public class ShowVideoPlayerArguments
	{
		public string Url { get; private set; }

		public ShowVideoPlayerArguments(string url)
		{
			Url = url;
		}
	}

    public partial class App : Application
    {
        public App()
        {
			 InitializeComponent();

			 MainPage = new NavigationPage(new Views.EntryPage());

			/*const string VideoUrl = "https://fpdl.vimeocdn.com/vimeo-prod-skyfire-std-us/01/3434/6/167173062/533657867.mp4?token=1495844636-0xe76ba1f640c9fb5918fed58140f6c0f47f658440";

			var button3 = new Button { Text = "MessagingCenter" };
			button3.Clicked += (sender, e) => MessagingCenter.Send(MainPage, "ShowVideoPlayer", new ShowVideoPlayerArguments(VideoUrl));

			MainPage = new NavigationPage(new ContentPage { Content = new StackLayout { Children = { button3 } } }); */
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
