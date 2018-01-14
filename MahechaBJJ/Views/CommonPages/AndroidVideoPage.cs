﻿﻿using System;
using MahechaBJJ.Model;
using Xamarin.Forms;
using Android.Content;
using Android.App;
using Android.Views;
using MahechaBJJ.Droid;
#if __ANDROID__
using Android.Widget;
using Xamarin.Forms.Platform.Android;
#endif
namespace MahechaBJJ.Views
{
    #if __ANDROID__
    [Activity]
    public class AndroidVideoPage : ContentPage
    {

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
            contentView.BackgroundColor = Color.Red;
            contentView.Content = videoView.ToView();
            contentView.HorizontalOptions = LayoutOptions.FillAndExpand;
            contentView.VerticalOptions = LayoutOptions.CenterAndExpand;

            Content = contentView;

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

