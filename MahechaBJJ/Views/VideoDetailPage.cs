﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
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
#if __ANDROID__
#endif
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
            Padding = new Thickness(10, 30, 10, 10);
            Title = video.name;

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
                Source = video.pictures.sizes[4].link,
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
                    playVideo,
                }
            };
            //Events
            backBtn.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
#if __IOS__
            playVideo.Clicked += (sender, e) => MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
#endif
#if __ANDROID__
            playVideo.Clicked += (sender, args) =>
            {
                //Navigation.PushModalAsync(new NativeView(video));
                Navigation.PushModalAsync(new AndroidVideoViewPage(video));
            };
          /*  playVideo.Clicked += (sender, args) =>
			{
				var VideoPlayerService = DependencyService.Get<IVideoPlayerService>();
                VideoPlayerService.PlayVimeoVideo(videoUrl);
			}; */
#endif
        Content = layout;
        }
    }
}

