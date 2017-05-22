﻿﻿using System;
using MahechaBJJ.Model;

using Xamarin.Forms;

namespace MahechaBJJ
{
    public class VideoDetailPage : ContentPage
    {
        public VideoDetailPage(VideoData video)
        {
            Padding = 30;
            Title = video.name;

            var backBtn = new Button
            {
                Text = "Back",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };
            var testLabel = new Label
            {
                Text = video.name
            };

            var image = new Image
            {
                Source = video.pictures.sizes[3].link,
                Aspect = Aspect.AspectFit
            };

            var layout = new StackLayout
            {
                Children = {
                    backBtn,
                    testLabel,
                    image
                }
            };

            //Events
            backBtn.Clicked += (sender, e) => {
                Navigation.PopModalAsync();
            };

            Content = layout;
        }
    }
}

