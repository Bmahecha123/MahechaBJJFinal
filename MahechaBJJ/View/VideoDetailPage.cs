﻿﻿using System;
using MahechaBJJ.Model;

using Xamarin.Forms;

namespace MahechaBJJ
{
    public class VideoDetailPage : ContentPage
    {
        //declare objects
        Button backBtn;
        Label testLabel;
        Image image;
        StackLayout layout;

        public VideoDetailPage(VideoData video)
        {
            Padding = 30;
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
                Source = video.pictures.sizes[3].link,
                Aspect = Aspect.AspectFit
            };

            layout = new StackLayout
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

