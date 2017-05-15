using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class BrowsePage : ContentPage
    {
        public BrowsePage()
        {
            Title = "Browse";
            Padding = 30;

            var grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //view objects
            var bottomBtn = new Button
            {
                Text = "Bottom Techniques",
                BackgroundColor = Color.Orange
            };
            var topBtn = new Button
            {
				Text = "Top Techniques",
				BackgroundColor = Color.Orange

			};
            var standUpBtn = new Button
            {
				Text = "Stand Up Techniques",
				BackgroundColor = Color.Orange

			};

            //Events
            //TODO Add search query with Vimeo API
            bottomBtn.Clicked += (sender, e) => {
                bottomBtn.Text = "Clicked!";
            };
            topBtn.Clicked += (sender, e) => {
                topBtn.Text = "Clicked!";
            };
            standUpBtn.Clicked += (sender, e) => {
                standUpBtn.Text = "Clicked!";
            };

            //adding children
            grid.Children.Add(bottomBtn, 0, 0);
            grid.Children.Add(topBtn, 0, 1);
            grid.Children.Add(standUpBtn, 0, 2);

            Content = grid;
        }
    }
}

