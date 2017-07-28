﻿﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using MahechaBJJ.Views;
using MahechaBJJ.Service;

namespace MahechaBJJ.Droid
{
    [Activity(Label = "MahechaBJJ.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
        }

		private void HandleShowVideoPlayerMessage(Page page, ShowVideoPlayerArguments arguments)
        {
            var videoView = FindViewById<VideoView>(Resource.Id.VideoPlayer);
            var uri = Android.Net.Uri.Parse(arguments.Url);
            videoView.SetVideoURI(uri);
            videoView.Start();
        }
	}
}
