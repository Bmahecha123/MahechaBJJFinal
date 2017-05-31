using System;
using System.Collections.Generic;
#if __ANDROID__
using Android.Widget;
#endif
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public partial class NativeView : ContentPage
    {
        

        public NativeView(VideoData video)
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
            var uri = Android.Net.Uri.Parse("https://fpdl.vimeocdn.com/vimeo-prod-skyfire-std-us/01/3434/6/167173062/533657867.mp4?token=1496104564-0x1d0ed9301adc2bc798b85507d9f3596d8a2f9d7f");
            var urihd = Android.Net.Uri.Parse("http://player.vimeo.com/external/167173062.hd.mp4?s=808e6626e49b9b7a7654ae5810718e6cc1952d8b&profile_id=174&oauth2_token_id=962266005");
            var videoUri = Android.Net.Uri.Parse(video.files[1].link);
            mediaController.SetMediaPlayer(videoView);
            mediaController.SetAnchorView(videoView);
            mediaController.SetMinimumWidth(videoView.Width);
            //associate the video view with the media controller
			videoView.SetMediaController(mediaController);
            videoView.SetVideoURI(videoUri);
            videoView.SetFitsSystemWindows(false);
            videoView.Start();
#endif
        }
    }
}
