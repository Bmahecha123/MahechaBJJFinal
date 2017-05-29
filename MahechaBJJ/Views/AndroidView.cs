using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class AndroidView : ContentPage
    {
        VideoPlayer androidPlayer;
        public AndroidView(VideoData video)
        {
            androidPlayer = new VideoPlayer
            {
                IsVisible = true,
                FileSource = video.files[0].link,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //var videoHeightRequest = displayService.PercentageToHeightRequest(25);


            //create a rel layout to hold the video
            var videoLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            //add video to the relative layout 
            videoLayout.Children.Add(
                androidPlayer,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => parent.Width),
                Constraint.RelativeToParent((parent) => parent.Height)
            );

            Content = videoLayout;
        }
    
    }
}

