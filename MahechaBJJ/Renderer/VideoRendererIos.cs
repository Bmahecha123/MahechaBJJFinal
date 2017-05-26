using System;
using System.IO;
using Foundation;
using MahechaBJJ.Renderer;
using MediaPlayer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Video), typeof(VideoRendererIos))]
namespace MahechaBJJ.Renderer
{
    public class VideoRendererIos : ViewRenderer<Video, UIView>
    {
        MPMoviePlayerController videoPlayer;
        NSObject notification = null;

        public VideoRendererIos()
        {
        }

        //TODO.. Implement passing url to make video run.
        public void InitVideoPlayer()
        {
            var path = Path.Combine(NSBundle.MainBundle.BundlePath, Element.Source);

            if (!NSFileManager.DefaultManager.FileExists(path))
            {
                Console.WriteLine("Video doesn't exist");
                videoPlayer = new MPMoviePlayerController();
                videoPlayer.ControlStyle = MPMovieControlStyle.None;
                videoPlayer.ScalingMode = MPMovieScalingMode.AspectFill;
                videoPlayer.RepeatMode = MPMovieRepeatMode.One;
                videoPlayer.View.BackgroundColor = UIColor.Clear;
                SetNativeControl(videoPlayer.View);
                return;
            }

            //Load the video from the app bundle.
            NSUrl videoURL = new NSUrl(path, false);

            //create and configure the movie player.
            videoPlayer = new MPMoviePlayerController(videoURL);

            videoPlayer.ControlStyle = MPMovieControlStyle.None;
            videoPlayer.ScalingMode = MPMovieScalingMode.AspectFill;
            videoPlayer.RepeatMode = Element.Loop ? MPMovieRepeatMode.One : MPMovieRepeatMode.None;
            videoPlayer.View.BackgroundColor = UIColor.Clear;
            foreach (UIView subView in videoPlayer.View.Subviews)
            {
                subView.BackgroundColor = UIColor.Clear;
            }

            videoPlayer.PrepareToPlay();
            SetNativeControl(videoPlayer.View);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Video> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                InitVideoPlayer();
            }
            if (e.OldElement != null)
            {
                //Unsubscribe
                notification?.Dispose();
            }
            if (e.NewElement != null)
            {
                //subscribe
                notification = MPMoviePlayerController.Notifications.ObservePlaybackDidFinish((sender, args) =>
                {
                    //Access strpmg ty[ed args
                    Console.WriteLine("Notification: {0}", args.Notification);
                    Console.WriteLine("FinishReason: {0}", args.FinishReason);

                    Element?.OnFinishedPlaying?.Invoke();
                });
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Element == null || Control == null) {
                return;
            }

            if (e.PropertyName == Video.SourceProperty.PropertyName)
            {
                InitVideoPlayer();
            }

            else if (e.PropertyName == Video.LoopProperty.PropertyName)
            {
                var liveImage = Element as Video;
                if (videoPlayer != null){
                    videoPlayer.RepeatMode = Element.Loop ? MPMovieRepeatMode.One : MPMovieRepeatMode.None;
                }
            }
        }
    }
}

