﻿using System;

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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

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

			Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);

			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Window.DecorView.SystemUiVisibility = 0;
				var statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("_statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
				statusBarHeightInfo.SetValue(this, 0);
				Window.SetStatusBarColor(new Android.Graphics.Color(0, 0, 0, 255)); // Change color as required.
			}
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
