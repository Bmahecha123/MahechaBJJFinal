using System;
using System.Collections.Generic;
#if __ANDROID__
using Android.Widget;
#endif
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public partial class AndroidViewPage : ContentPage
    {

        public AndroidViewPage(VideoData video)
        {
            BackgroundColor = Color.Black;
            Padding = 0;
            InitializeComponent();
#if __ANDROID__
            relativeLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;
            relativeLayout.VerticalOptions = LayoutOptions.CenterAndExpand;
            relativeLayout.Padding = 0;
            contentViewVideoView.Padding = 0;
            MediaController mediaController = new MediaController(Forms.Context, false);
            var wrapper = (Xamarin.Forms.Platform.Android.NativeViewWrapper)contentViewVideoView.Content;
            var videoView = (Android.Widget.VideoView)wrapper.NativeView;
            var videoUriHd = Android.Net.Uri.Parse(video.files[1].link);
            var videoUriSd = Android.Net.Uri.Parse(video.files[0].link);
            mediaController.SetMediaPlayer(videoView);
            mediaController.SetAnchorView(videoView);
            mediaController.SetMinimumWidth(videoView.Width);
            //associate the video view with the media controller
            videoView.SetMediaController(mediaController);
            videoView.SetVideoURI(videoUriHd);
            videoView.SetFitsSystemWindows(true);
            videoView.Start();
#endif
        }
    }
}
