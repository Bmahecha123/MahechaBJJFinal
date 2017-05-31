using System;
using System.Collections.Generic;
using MahechaBJJ.Model;
using Xamarin.Forms;
#if __ANDROID__
using Android.Widget;

#endif

namespace MahechaBJJ
{
    public partial class AndroidVideoViewPage : ContentPage
    {
#if __ANDROID__
        MediaController mediaController;
#endif
		public AndroidVideoViewPage(VideoData video)
        {
            //BackgroundColor = Color.Black;
            InitializeComponent();
#if __ANDROID__
            //TODO figure out how to use content view to make video fit properly in landscape and portrait..
            relativeLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;
            relativeLayout.VerticalOptions = LayoutOptions.CenterAndExpand;
            mediaController = new MediaController(Forms.Context, true);
			var wrapper = (Xamarin.Forms.Platform.Android.NativeViewWrapper)contentViewVideoView.Content;
			var videoView = (Android.Widget.VideoView)wrapper.NativeView;
            var videoUri = Android.Net.Uri.Parse(video.files[3].link);
            contentViewVideoView.HorizontalOptions = LayoutOptions.Fill;
            contentViewVideoView.VerticalOptions = LayoutOptions.Fill;
            mediaController.SetMediaPlayer(videoView);
            mediaController.SetAnchorView(videoView);
            mediaController.SetMinimumWidth(videoView.Width);
            //associate video view with media controller
            videoView.SetMediaController(mediaController);
            videoView.SetVideoURI(videoUri);
            videoView.SetFitsSystemWindows(true);
            videoView.Start();
#endif
        }
    }
}
