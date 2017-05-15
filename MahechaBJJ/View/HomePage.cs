﻿using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Home";
            Padding = 30;

            var grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };
            //View objects
            var whatsNewLbl = new Label
            {
                Text = "What's New"
            };
            var video1 = new Label
            {
                Text = "Video 1"
            };
            var video2 = new Label
            {
                Text = "Video 2"
            };
            var playlistLbl = new Label
            {
                Text = "Playlists"
            };
            var playList1 = new Label
            {
                Text = "Playlist1"
            };
            var playList2 = new Label
            {
                Text = "Playlist2"
            };
            var playList3 = new Label
            {
                Text = "Playlist3"
            };
            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { playList1, playList2, playList3 }
            };
			var playListScrollView = new ScrollView
			{
				Orientation = ScrollOrientation.Horizontal,
                Content = stackLayout
			};

            grid.Children.Add(whatsNewLbl, 0, 0);
            Grid.SetColumnSpan(whatsNewLbl, 2);
            grid.Children.Add(video1, 0, 1);
            grid.Children.Add(video2, 1, 1);
            grid.Children.Add(playlistLbl, 0, 2);
            Grid.SetColumnSpan(playlistLbl, 2);
            grid.Children.Add(playListScrollView, 0, 3);
            Grid.SetColumnSpan(playListScrollView, 2);

            Content = grid;

        }
    }
}
