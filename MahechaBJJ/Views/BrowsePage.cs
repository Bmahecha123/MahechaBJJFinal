﻿using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        //declare objects
        Grid outerGrid;
        Grid innerGrid;
        private Frame bottomFrame;
        private Label bottomLbl;
        private Image buttomImage;
        private Frame topFrame;
        private Label topLbl;
        private Image topImage;
        private Frame standUpFrame;
        private Label standUpLbl;
        private Image standUpImage;
        Button bottomBtn;
        Button topBtn;
        Button standUpBtn;


        public BrowsePage()
        {
			Title = "Browse";
            Icon = "002-open-book.png";
            Padding = new Thickness(10,30,10,10);

			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            topLbl = new Label
            {
				Text = "Top",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize * 2,
                TextColor = Color.White,
                VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };
            topImage = new Image
            {
                Aspect = Aspect.AspectFill,
                Source = ImageSource.FromFile("kevin.JPG")
			};
			topFrame = new Frame
			{
                Content = topImage,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
			};

            //Events

            //adding children
            innerGrid.Children.Add(topFrame, 0, 0);
            innerGrid.Children.Add(topLbl, 0, 0);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = innerGrid;
        }
    }
}

