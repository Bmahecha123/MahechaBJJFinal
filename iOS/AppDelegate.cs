﻿using System;
using System.Collections.Generic;
using System.Linq;
using AVFoundation;
using AVKit;
using Foundation;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
using MahechaBJJ.Views;
using UIKit;
using Xamarin.Forms;

namespace MahechaBJJ.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
			global::Xamarin.Auth.Presenters.XamarinIOS.AuthenticationConfiguration.Init();

			LoadApplication(new App());

            //adding messsaging center
            MessagingCenter.Subscribe<VideoDetailPage, ShowVideoPlayerArguments>(this, "ShowVideoPlayer", HandleShowVideoPlayerMessage);

            return base.FinishedLaunching(app, options);
        }

		public override bool OpenUrl
				(
					UIApplication application,
					NSUrl url,
					string sourceApplication,
					NSObject annotation
				)
		{
#if DEBUG
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.AppendLine("OpenURL Called");
			sb.Append("     url         = ").AppendLine(url.AbsoluteUrl.ToString());
			sb.Append("     application = ").AppendLine(sourceApplication);
			sb.Append("     annotation  = ").AppendLine(annotation?.ToString());
			System.Diagnostics.Debug.WriteLine(sb.ToString());
#endif

			// Convert iOS NSUrl to C#/netxf/BCL System.Uri - common API
			Uri uri_netfx = new Uri(url.AbsoluteString);

			// load redirect_url Page
			AuthenticationState.Authenticator.OnPageLoading(uri_netfx);

			return true;
		}

        //messaging center class
        private void HandleShowVideoPlayerMessage(Page page, ShowVideoPlayerArguments arguments)
        {
            var presentingViewController = GetMostPresentedViewController();
            var url = NSUrl.FromString(arguments.Url);
            var avp = new AVPlayer(url);
            var avpvc = new AVPlayerViewController();
            avpvc.Player = avp;
            avp.Play();

            presentingViewController.PresentViewController(avpvc, animated: true, completionHandler: null);
        }

        private UIViewController GetMostPresentedViewController()
        {
            var viewController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            while (viewController.PresentedViewController != null){
                viewController = viewController.PresentedViewController;
            }

            return viewController;
        }

    }
}
