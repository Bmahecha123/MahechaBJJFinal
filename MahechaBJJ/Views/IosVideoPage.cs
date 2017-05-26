using System;

using Xamarin.Forms;
#if __IOS__
using Xamarin.Forms.Platform.iOS;
using UIKit;
using AVFoundation;
using Foundation;
using MediaPlayer;
#endif

namespace MahechaBJJ.Views
{
    public class IosVideoPage : UIViewController
    {

        AVPlayer player;
        AVPlayerLayer playerLayer;
        AVAsset asset;
        AVPlayerItem playerItem;

        public IosVideoPage()
        {
            
        }
    }
}

