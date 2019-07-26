using Xamarin.Forms;
using MahechaBJJ.Resources;

#if __ANDROID__
using MahechaBJJ.Droid;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace MahechaBJJ.Views
{
    public class AndroidVideoPage : ContentPage
    {

		private VideoView videoView;
		private MediaController mediaController;
        private ContentView contentView;
		private Android.Net.Uri uriHd;

        //added string link instead of passing whole video
		public AndroidVideoPage(string url)
        {
            BackgroundColor = Theme.Black;
            SetContent(url);
		}

        public void SetContent(string url)
        {
            // https://stackoverflow.com/questions/47353986/xamarin-forms-forms-context-is-obsolete
            //SOLVED BY REFERENCING LOCAL ANDROID CONTEXT IN MAIN APPLICATION 
            //REPLACED FORMS.CONTEXT
            videoView = new VideoView(MainApplication.ActivityContext);
            mediaController = new MediaController(MainApplication.ActivityContext, false);
            uriHd = Android.Net.Uri.Parse(url);

            mediaController.SetMediaPlayer(videoView);
            mediaController.SetAnchorView(videoView);

            videoView.SetMediaController(mediaController);
            videoView.SetFitsSystemWindows(true);
            videoView.SetVideoURI(uriHd);

            contentView = new ContentView();
            //contentView.BackgroundColor = Color.Black;
            contentView.Content = videoView.ToView();
            contentView.HorizontalOptions = LayoutOptions.FillAndExpand;
            contentView.VerticalOptions = LayoutOptions.CenterAndExpand;

            Content = contentView;

            videoView.Start();
		}

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                contentView.HorizontalOptions = LayoutOptions.FillAndExpand;
                contentView.VerticalOptions = LayoutOptions.FillAndExpand;
            }
            else
            {
                contentView.HorizontalOptions = LayoutOptions.FillAndExpand;
                contentView.VerticalOptions = LayoutOptions.CenterAndExpand;
            }
        }
	}
}

#endif