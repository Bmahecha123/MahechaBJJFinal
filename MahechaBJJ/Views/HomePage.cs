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
        ActivityIndicator activityIndicator;
        Grid outerGrid;
        Grid innerGrid;
        BoxView whatsNewBoxView;
        Frame video1Frame;
        Frame video2Frame;
        Image video1Image;
        Image video2Image;
        Label video1Lbl;
        Label video2Lbl;
        Label whatsNewLbl;
        Label playListLbl;
        Button addPlaylistBtn;
        Button viewPlaylistBtn;

        public HomePage()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            //View objects
			LoadVimeo();
            Title = "Home";
            Padding = new Thickness(10, 10, 10, 10);

			
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				},
                ColumnDefinitions = new ColumnDefinitionCollection {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
				    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
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
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize * 2,
                VerticalTextAlignment = TextAlignment.End,
				HorizontalTextAlignment = TextAlignment.Center
			};
			video1Image = new Image
			{
                Aspect = Aspect.AspectFill
			};
			video1Frame = new Frame
			{
                Content = video1Image,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3
                 
			};
            video1Lbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Spider Guard Stuff!",
                FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White
			};
			video2Lbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Spider Guard Stuff!",
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White
			};
			video2Image = new Image
			{
				Aspect = Aspect.AspectFill
			};
            video2Frame = new Frame
            {
                Content = video2Image,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
				Padding = 3
            };
			playListLbl = new Label
			{
				Text = "Playlists",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
                FontSize = lblSize * 2
			};
			addPlaylistBtn = new Button
			{
				Text = "Create",
				BorderWidth = 3,
				BorderColor = Color.Black,
				TextColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.Orange
			};
            viewPlaylistBtn = new Button
            {
                Text = "View",
				BorderWidth = 3,
				BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
			};

			innerGrid.Children.Add(whatsNewLbl, 0, 0);
            Grid.SetColumnSpan(whatsNewLbl, 2);
			innerGrid.Children.Add(video1Frame, 0, 1);
            Grid.SetColumnSpan(video1Frame, 2);
            innerGrid.Children.Add(video1Lbl, 0, 1);
            Grid.SetColumnSpan(video1Lbl, 2);
			innerGrid.Children.Add(video2Frame, 0, 2);
            Grid.SetColumnSpan(video2Frame, 2);
            innerGrid.Children.Add(video2Lbl, 0, 2);
            Grid.SetColumnSpan(video2Lbl, 2);
			innerGrid.Children.Add(playListLbl, 0, 3);
            Grid.SetColumnSpan(playListLbl, 2);
            innerGrid.Children.Add(viewPlaylistBtn, 0, 4);
			innerGrid.Children.Add(addPlaylistBtn, 1, 4);

			outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }
        private void LoadVimeo()
        {
            SetContent();
        }

        private async void SetContent()
        {
			activityIndicator = new ActivityIndicator();
            activityIndicator.IsRunning = true;
            Content = activityIndicator;
			await _homePageViewModel.GetVimeo(VIMEOURL);
			VimeoInfo = _homePageViewModel.VimeoInfo;

            video1Image.Source = VimeoInfo.data[0].pictures.sizes[4].link;
            video2Image.Source = VimeoInfo.data[1].pictures.sizes[4].link;
            video1Lbl.Text = VimeoInfo.data[0].name;
            video2Lbl.Text = VimeoInfo.data[1].name;
            activityIndicator.IsRunning = false;
            Content = outerGrid;
        }

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
				Padding = new Thickness(10, 10, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(whatsNewLbl, 0, 0);
                Grid.SetColumnSpan(whatsNewLbl, 2);
                innerGrid.Children.Add(video1Frame, 0, 1);
                innerGrid.Children.Add(video1Lbl, 0, 1);
                innerGrid.Children.Add(video2Frame, 1, 1);
                innerGrid.Children.Add(video2Lbl, 1, 1);
                innerGrid.Children.Add(playListLbl, 0, 2);
                Grid.SetColumnSpan(playListLbl, 2);
                innerGrid.Children.Add(viewPlaylistBtn, 0, 3);
                innerGrid.Children.Add(addPlaylistBtn, 1, 3);
			}
			else
			{
				Padding = new Thickness(10, 10, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Add(whatsNewLbl, 0, 0);
				Grid.SetColumnSpan(whatsNewLbl, 2);
				innerGrid.Children.Add(video1Frame, 0, 1);
				Grid.SetColumnSpan(video1Frame, 2);
				innerGrid.Children.Add(video1Lbl, 0, 1);
				Grid.SetColumnSpan(video1Lbl, 2);
				innerGrid.Children.Add(video2Frame, 0, 2);
				Grid.SetColumnSpan(video2Frame, 2);
				innerGrid.Children.Add(video2Lbl, 0, 2);
				Grid.SetColumnSpan(video2Lbl, 2);
				innerGrid.Children.Add(playListLbl, 0, 3);
				Grid.SetColumnSpan(playListLbl, 2);
				innerGrid.Children.Add(viewPlaylistBtn, 0, 4);
				innerGrid.Children.Add(addPlaylistBtn, 1, 4);
			}
		}
    }
}

