﻿using System;
using MahechaBJJ.Model;
using Xamarin.Forms;
#if __ANDROID__
using Android.Widget;
using Xamarin.Forms.Platform.Android;
#endif
namespace MahechaBJJ.Views
{
    public class AndroidVideoPage : ContentPage
    {
#if __ANDROID__
		VideoView videoView;
		MediaController mediaController;
		ContentView portraitContentView;
        ContentView landscapeContentView;
		Android.Net.Uri uriHd;
        int currentPosition;

#endif
		public AndroidVideoPage(VideoData video)
        {
			BackgroundColor = Color.Black;
#if __ANDROID__
            SizeChanged += OnSizeChanged;
			videoView = new VideoView(Forms.Context);
			mediaController = new MediaController(Forms.Context, false);
			uriHd = Android.Net.Uri.Parse(video.files[1].link);

			mediaController.SetMediaPlayer(videoView);
			mediaController.SetAnchorView(videoView);
			mediaController.SetMinimumWidth(videoView.Width);

			videoView.SetMediaController(mediaController);
			videoView.SetFitsSystemWindows(false);
			videoView.SetVideoURI(uriHd);

            portraitContentView = new ContentView();
			portraitContentView.Content = videoView.ToView();
			portraitContentView.HorizontalOptions = LayoutOptions.FillAndExpand;
            portraitContentView.VerticalOptions = LayoutOptions.CenterAndExpand;

            landscapeContentView = new ContentView();
            landscapeContentView.Content = videoView.ToView();
            landscapeContentView.HorizontalOptions = LayoutOptions.FillAndExpand;
            landscapeContentView.VerticalOptions = LayoutOptions.FillAndExpand;

            void OnSizeChanged (object sender, EventArgs e) {
                currentPosition = videoView.CurrentPosition;
                Content = (Height > Width) ? portraitContentView : landscapeContentView;
                videoView.SeekTo(currentPosition);
                videoView.Start();
            }
			videoView.Start();
#endif
		}
    }
}

