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
using Plugin.InAppBilling;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MahechaBJJ.Droid
{
    [Activity(Label = "MahechaBJJ.Droid", Icon = "@mipmap/mahechabjj", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, WindowSoftInputMode = SoftInput.AdjustResize)]
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

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            InAppBillingImplementation.HandleActivityResult(requestCode, resultCode, data);
        }
	}
}
