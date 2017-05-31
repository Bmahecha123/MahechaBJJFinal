﻿using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class HomePage : ContentPage
    {
        Grid grid;
        Label whatsNewLbl;
        Image video1;
        Image video2;
        Label playListLbl;
        Label playList1;
        Label playList2;
        Label playList3;
        StackLayout stackLayout;
        ScrollView playListScrollView;

        public HomePage(BaseInfo VimeoInfo)
        {
            Title = "Home";
            Padding = new Thickness(10, 30, 10, 10);

            grid = new Grid
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
            whatsNewLbl = new Label
            {
                Text = "What's New"
            };
            video1 = new Image
            {
				Source = VimeoInfo.data[0].pictures.sizes[2].link
			};
            video2 = new Image
            {
                Source = VimeoInfo.data[1].pictures.sizes[2].link
            };
            playListLbl = new Label
            {
                Text = "Playlists"
            };
            playList1 = new Label
            {
                Text = "Playlist1"
            };
            playList2 = new Label
            {
                Text = "Playlist2"
            };
            playList3 = new Label
            {
                Text = "Playlist3"
            };
            stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { playList1, playList2, playList3 }
            };
			playListScrollView = new ScrollView
			{
				Orientation = ScrollOrientation.Horizontal,
                Content = stackLayout
			};

            grid.Children.Add(whatsNewLbl, 0, 0);
            Grid.SetColumnSpan(whatsNewLbl, 2);
            grid.Children.Add(video1, 0, 1);
            grid.Children.Add(video2, 1, 1);
            grid.Children.Add(playListLbl, 0, 2);
            Grid.SetColumnSpan(playListLbl, 2);
            grid.Children.Add(playListScrollView, 0, 3);
            Grid.SetColumnSpan(playListScrollView, 2);

            Content = grid;

        }
    }
}

