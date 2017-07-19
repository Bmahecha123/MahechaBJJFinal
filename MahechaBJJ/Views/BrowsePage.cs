﻿using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        //declare objects
        Grid grid;
        Button bottomBtn;
        Button topBtn;
        Button standUpBtn;

        public BrowsePage()
        {
			Title = "Browse";
            Padding = new Thickness(10,30,10,10);

            grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //view objects
            bottomBtn = new Button
            {
                Text = "Bottom Techniques",
                BackgroundColor = Color.Orange
            };
            topBtn = new Button
            {
				Text = "Top Techniques",
				BackgroundColor = Color.Orange

			};
            standUpBtn = new Button
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

