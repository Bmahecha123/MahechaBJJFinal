using System;
using Android.Widget;
using MahechaBJJ.Model;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MahechaBJJ.Views
{
    public class WebViewPage : ContentPage
    {
#if __ANDROID__
		VideoView videoView;
		MediaController mediaController;
        ContentView contentView;
        Android.Net.Uri uriHd;

#endif

		public WebViewPage(VideoData video)
        {
            BackgroundColor = Color.Black;
#if __ANDROID__
            videoView = new VideoView(Forms.Context);
            contentView = new ContentView();
            mediaController = new MediaController(Forms.Context, false);
            uriHd = Android.Net.Uri.Parse(video.files[1].link);

			mediaController.SetMediaPlayer(videoView);
			mediaController.SetAnchorView(videoView);
			mediaController.SetMinimumWidth(videoView.Width);

			videoView.SetMediaController(mediaController);
			videoView.SetFitsSystemWindows(false);
            videoView.SetVideoURI(uriHd);

            contentView.Content = videoView.ToView();
            contentView.HorizontalOptions = LayoutOptions.CenterAndExpand;
            contentView.VerticalOptions = LayoutOptions.CenterAndExpand;

            Content = contentView;
            videoView.Start();
#endif
        }
    }
}

