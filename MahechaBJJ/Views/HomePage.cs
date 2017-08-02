﻿﻿﻿using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class HomePage : ContentPage
    {
        BaseViewModel _baseViewModel = new BaseViewModel();
        HomePageViewModel _homePageViewModel = new HomePageViewModel();
        private const String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        BaseInfo VimeoInfo;
        Grid grid;
        BoxView whatsNewBoxView;
        Image video1Btn;
        Image video2Btn;
        Label whatsNewLbl;
        Label playListLbl;
        Button playList1Btn;
        Button playList2Btn;
        Button playList3Btn;
        Button playList4Btn;
        Button playList5Btn;
        Button playList6Btn;
        Button addPlaylistBtn;
        StackLayout stackLayout;
        ScrollView playListScrollView;
        //Xam Auth
        Account account;

        public HomePage()
        {
            //TODO add loading screen to cover up main page while the login page loads. MAybe Mahecha bjj logo???
            LoadVimeo();
            Title = "Home";
            BackgroundColor = Color.Azure;
            Padding = new Thickness(10, 30, 10, 10);
        }
        private void LoadVimeo()
        {
            SetContent();
        }

        private async void SetContent()
        {
            await _homePageViewModel.GetVimeo(VIMEOURL);
			VimeoInfo = _homePageViewModel.VimeoInfo;
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
            whatsNewBoxView = new BoxView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Black,
                Opacity = .5

            };
            whatsNewLbl = new Label
            {
                Text = "What's New",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 50
            };
            video1Btn = new Image
            {
                Source = VimeoInfo.data[0].pictures.sizes[4].link,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            video2Btn = new Image
            {
                Source = VimeoInfo.data[1].pictures.sizes[4].link,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            playListLbl = new Label
            {
                Text = "Playlists",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 50
            };
            playList1Btn = new Button
            {
                Text = "Playlist1",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            playList2Btn = new Button
            {
                Text = "Playlist2",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            playList3Btn = new Button
            {
                Text = "Playlist3",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            playList4Btn = new Button
            {
                Text = "Playlist3",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            playList5Btn = new Button
            {
                Text = "Playlist3",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            playList6Btn = new Button
            {
                Text = "Playlist3",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            addPlaylistBtn = new Button
            {
                Text = "Add Playlist!",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BorderWidth = 2.5,
                BorderColor = Color.Black
            };
            stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { playList1Btn, playList2Btn, playList3Btn, playList4Btn, playList5Btn, playList6Btn, addPlaylistBtn }
            };
            playListScrollView = new ScrollView
            {
                Orientation = ScrollOrientation.Horizontal,
                Content = stackLayout
            };

            grid.Children.Add(whatsNewLbl, 0, 0);
            Grid.SetColumnSpan(whatsNewLbl, 2);
            grid.Children.Add(video1Btn, 0, 1);
            grid.Children.Add(video2Btn, 1, 1);
            grid.Children.Add(playListLbl, 0, 2);
            Grid.SetColumnSpan(playListLbl, 2);
            grid.Children.Add(playListScrollView, 0, 3);
            Grid.SetColumnSpan(playListScrollView, 2);


            Content = grid;
        }

        private async void LoggedIn()
        {
            account = _baseViewModel.GetAccountInformation();
            if (account == null){
                await DisplayAlert("Test", "You're not logged in!", "OK");
				await Navigation.PushModalAsync(new EntryPage());
			}
            else {
                await DisplayAlert("Welcome!", "Welcome : " + account.Username, "Hey!");
            }
		}
    }
}

