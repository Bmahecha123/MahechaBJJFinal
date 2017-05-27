using System;
using MahechaBJJ.Model;
using MahechaBJJ.Renderer;
using MahechaBJJ.Services;
/*#if __IOS__
using Xamarin.Forms.Platform.iOS;
using UIKit;
using AVFoundation;
using Foundation;
using MediaPlayer;
#endif */
#if __ANDROID__

#endif

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class VideoDetailPage : ContentPage
    {
        //renderer stuff..

        //declare objects
        //video objects
        /*#if __IOS__
                private MPMoviePlayerController moviePlayer;
                private AVPlayer player;
                private AVPlayerLayer playerLayer;
                private AVAsset asset;
                private AVPlayerItem playerItem;
        #endif */
        string videoUrl;
        Button backBtn;
        Label testLabel;
        Image image;
        StackLayout layout;
        Button playVideo;
        //UIViewController uiView;
        //UIWindow window;

        public VideoDetailPage(VideoData video)
        {
            videoUrl = video.files[0].link;
            Padding = 30;
            Title = video.name;
/*#if __IOS__
            var playMovie = new UIButton();
            playMovie.SetTitle("Video Test", UIControlState.Normal);
            playMovie.BackgroundColor = UIColor.Blue;
#endif */

            backBtn = new Button
            {
                Text = "Back",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };
            testLabel = new Label
            {
                Text = video.name
            };

            image = new Image
            {
                Source = video.pictures.sizes[3].link,
                Aspect = Aspect.AspectFit
            };
            playVideo = new Button
            {
                Text = "Play Vimeo Video"
            };

            layout = new StackLayout
            {
                Children = {
                    backBtn,
                    testLabel,
                    image,
                    playVideo
                }
            };
            //Events
            backBtn.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
            playVideo.Clicked += (sender, e) => MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));

			//button3.Clicked += (sender, e) => MessagingCenter.Send(MainPage, "ShowVideoPlayer", new ShowVideoPlayerArguments(VideoUrl));



			/* #if __IOS__
						playMovie.TouchUpInside += delegate
						{
							/*uiView = new UIViewController();
							window = new UIWindow(UIScreen.MainScreen.Bounds);
							moviePlayer = new MPMoviePlayerController(NSUrl.FromFilename("spider.mp4"));
							window.RootViewController = uiView;
							uiView.ShowViewController(uiView, null);


							//moviePlayer.SetFullscreen(true, true);
							window.MakeKeyAndVisible();
							moviePlayer.Play(); */

			/*   asset = AVAsset.FromUrl(NSUrl.FromFilename("spider.mp4"));
			   playerItem = new AVPlayerItem(asset);

			   player = new AVPlayer(playerItem);

			   playerLayer = AVPlayerLayer.FromPlayer(player);
			   uiView = new UIViewController();
			   playerLayer.Frame = uiView.View.Frame;
			   uiView.View.Layer.AddSublayer(playerLayer);

			   player.Play();
		   };
#endif */


			Content = layout;
        }
    }
}

