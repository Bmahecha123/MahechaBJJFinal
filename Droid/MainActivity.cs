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
using MahechaBJJ.Model;

namespace MahechaBJJ.Droid
{
    [Activity(Label = "MahechaBJJ.Droid", Icon = "@drawable/mahechabjj", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, WindowSoftInputMode = SoftInput.AdjustResize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());

            //MessagingCenter.Subscribe<ProfilePage, EmailMessage>(this, "Send EMail", SendEmail);

		}

		private void HandleShowVideoPlayerMessage(Page page, ShowVideoPlayerArguments arguments)
        {
            var videoView = FindViewById<VideoView>(Resource.Id.VideoPlayer);
            var uri = Android.Net.Uri.Parse(arguments.Url);
            videoView.SetVideoURI(uri);
            videoView.Start();
        }

        private void SendEmail(Page page, EmailMessage emailMessage) 
        {
            var email = new Intent(Forms.Context, typeof(Android.Content.Intent));
            //var email = new Intent(Android.Content.Intent.ActionSend);
            //var email = Forms.Context(new Intent(Android.Content.Intent.ActionSend));
            email.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { "admin@mahechabjj.com" });
            email.PutExtra(Android.Content.Intent.ExtraSubject, emailMessage.Subject);
            email.PutExtra(Android.Content.Intent.ExtraText, emailMessage.Body);
            email.SetType("message/rfc822");
            Forms.Context.StartActivity(email);
        }
	}
}
