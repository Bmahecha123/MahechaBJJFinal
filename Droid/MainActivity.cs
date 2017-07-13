using System;

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
			global::Xamarin.Auth.Presenters.XamarinAndroid.AuthenticationConfiguration.Init(this, bundle);

			//adding messsaging center
			MessagingCenter.Subscribe<VideoDetailPage, ShowVideoPlayerArguments>(this, "ShowVideoPlayer", HandleShowVideoPlayerMessage);

			LoadApplication(new App());
        }

		private void HandleShowVideoPlayerMessage(Page page, ShowVideoPlayerArguments arguments)
        {
            var videoView = FindViewById<VideoView>(Resource.Id.VideoPlayer);
            var uri = Android.Net.Uri.Parse(arguments.Url);
            videoView.SetVideoURI(uri);
            videoView.Start();
        }

        private Android.Widget.RelativeLayout Test(VideoView _videoView) {
            Android.Widget.RelativeLayout layout = new Android.Widget.RelativeLayout(this.BaseContext);
			layout.SetHorizontalGravity(Android.Views.GravityFlags.CenterHorizontal);
			layout.AddView(_videoView);

            return layout;
            
        }

	}
}
