﻿using System;
using MahechaBJJ.Model;

using Xamarin.Forms;

namespace MahechaBJJ
{
    public class VideoDetailPage : ContentPage
    {
        public VideoDetailPage(VideoData video)
        {
            var testLabel = new Label
            {
                Text = video.name
            };

            var layout = new StackLayout
            {
                Children = {
                    testLabel
                }
            };

            Content = layout;
        }
    }
}

