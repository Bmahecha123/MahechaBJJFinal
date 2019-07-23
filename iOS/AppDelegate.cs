﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using AVFoundation;
using AVKit;
using Foundation;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
using MahechaBJJ.Views;
using MahechaBJJ.Views.PlaylistPages;
using MessageUI;
using UIKit;
using Xamarin.Forms;

namespace MahechaBJJ.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        private MFMailComposeViewController mailController;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            FormsMaterial.Init();

			LoadApplication(new App());

            //adding messsaging center
            MessagingCenter.Subscribe<VideoDetailPage, ShowVideoPlayerArguments>(this, "ShowVideoPlayer", HandleShowVideoPlayerMessage);
            MessagingCenter.Subscribe<PlaylistVideoPage, ShowVideoPlayerArguments>(this, "ShowVideoPlayer", HandleShowVideoPlayerMessage);
            MessagingCenter.Subscribe<ProfilePage, EmailMessage>(this, "Send EMail", SendEmail);

            return base.FinishedLaunching(app, options);
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

        private void SendEmail(Page page, EmailMessage emailMessage)
        {
            var presentingViewController = GetMostPresentedViewController();

            if (MFMailComposeViewController.CanSendMail)
            {
                mailController = new MFMailComposeViewController();
                mailController.SetToRecipients(new string[]{"admin@mahechabjj.com"});
                mailController.SetSubject(emailMessage.Subject);
                mailController.Finished += (object s, MFComposeResultEventArgs args) =>
                {
                    Console.WriteLine("result: " + args.Result.ToString());
                    BeginInvokeOnMainThread(() => {
                        args.Controller.DismissViewController(true, null);
                    });
                };

                presentingViewController.PresentViewController(mailController, animated: true, completionHandler: null);

            } else {
                Console.WriteLine("E-Mail is not supported on this device.");
            }
        }
    }
}
