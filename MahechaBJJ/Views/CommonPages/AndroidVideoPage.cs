﻿﻿using System;
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
		private VideoView videoView;
		private MediaController mediaController;
        private ContentView contentView;
        private ContentView landscapeContentView;
		private Android.Net.Uri uriHd;
        private int currentPosition;

#endif
        //added string link instead of passing whole video
		public AndroidVideoPage(string url)
        {
			BackgroundColor = Color.Black;
            SetContent(url);
		}

        public void SetContent(string url)
        {
#if __ANDROID__
            videoView = new VideoView(Forms.Context);
            mediaController = new MediaController(Forms.Context, false);
            uriHd = Android.Net.Uri.Parse(url);

            mediaController.SetMediaPlayer(videoView);
            mediaController.SetAnchorView(videoView);
            mediaController.SetMinimumWidth(videoView.Width);

            videoView.SetMediaController(mediaController);
            videoView.SetFitsSystemWindows(false);
            videoView.SetVideoURI(uriHd);

            contentView = new ContentView();
            contentView.Content = videoView.ToView();
            contentView.HorizontalOptions = LayoutOptions.FillAndExpand;
            contentView.VerticalOptions = LayoutOptions.CenterAndExpand;

            videoView.Start();
#endif
		}
#if __ANDROID__
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
#endif

	}
}

