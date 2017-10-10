﻿﻿﻿using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using MahechaBJJ.Views.PlaylistPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class HomePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private HomePageViewModel _homePageViewModel;
        private const String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        private BaseInfo VimeoInfo;
        private Grid outerGrid;
        private Grid innerGrid;
        private BoxView whatsNewBoxView;
        private Frame video1Frame;
        private Frame video2Frame;
        private Image video1Image;
        private Image video2Image;
        private Label video1Lbl;
        private Label video2Lbl;
        private TapGestureRecognizer video1Tap;
        private TapGestureRecognizer video2Tap;
        private Label whatsNewLbl;
        private Label playListLbl;
        private Button addPlaylistBtn;
        private Button viewPlaylistBtn;
        private Label timeOutLbl;
        private Frame timeOutFrame;
        private TapGestureRecognizer timeOutTap;
        private ActivityIndicator activityIndicator;
        public HomePage()
        {
            _baseViewModel = new BaseViewModel();
            _homePageViewModel = new HomePageViewModel();
            Title = "Home";
            Icon = "005-construction.png";
			Padding = new Thickness(10, 10, 10, 10);
			BuildPageObjects();
            SetContent();
        }

        //functions

        private void BuildPageObjects()
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));


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
            video1Tap = new TapGestureRecognizer();
            video1Tap.Tapped += (sender, e) =>
            {
                VideoData video = VimeoInfo.data[0];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
			video1Lbl.GestureRecognizers.Add(video1Tap);
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
            video2Tap = new TapGestureRecognizer();
            video2Tap.Tapped += (sender, e) =>
            {
                VideoData video = VimeoInfo.data[1];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
			video2Lbl.GestureRecognizers.Add(video2Tap);

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
                BackgroundColor = Color.FromRgb(58, 93, 174)
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
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black
            };
            timeOutLbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Network Has Timed Out! \n Click To Try Again!",
                LineBreakMode = LineBreakMode.WordWrap,
				FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.White
			};
            timeOutFrame = new Frame
			{
                Content = timeOutLbl,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
			};
            timeOutTap = new TapGestureRecognizer();
			timeOutTap.Tapped += (sender, e) =>
			{
                SetContent();
			};
            timeOutLbl.GestureRecognizers.Add(timeOutTap);
            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                IsEnabled = true,
                IsVisible = true
            };

			//events
			addPlaylistBtn.Clicked += CreatePlaylist;
			viewPlaylistBtn.Clicked += ViewPlaylists;

			outerGrid.Children.Add(innerGrid, 0, 0);
			Content = outerGrid;
        }

        private async void SetContent()
        {
            //add activity indicator while contents load
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 5);
            Grid.SetColumnSpan(activityIndicator, 2);
            if (_homePageViewModel.VimeoInfo == null)
            {
				await _homePageViewModel.GetVimeo(VIMEOURL);
			}
            if (_homePageViewModel.Successful)
            {
                activityIndicator.IsRunning = false;
				VimeoInfo = _homePageViewModel.VimeoInfo;
				video1Image.Source = VimeoInfo.data[0].pictures.sizes[4].link;
				video2Image.Source = VimeoInfo.data[1].pictures.sizes[4].link;
				video1Lbl.Text = VimeoInfo.data[0].name;
				video2Lbl.Text = VimeoInfo.data[1].name;

				innerGrid.Children.Clear();
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

			} else {
				innerGrid.Children.Clear();
                innerGrid.Children.Add(timeOutFrame, 0, 0);
                Grid.SetRowSpan(timeOutFrame, 5);
                Grid.SetRowSpan(timeOutLbl, 5);
                Grid.SetColumnSpan(timeOutFrame, 2);
                Grid.SetColumnSpan(timeOutLbl, 2);
            }
			
        }

        private void CreatePlaylist(object sender, EventArgs e)
        {
            addPlaylistBtn.IsEnabled = false;
            Navigation.PushModalAsync(new PlaylistCreatePage());
            addPlaylistBtn.IsEnabled = true;
        }
        private void ViewPlaylists(object sender, EventArgs e)
        {
            viewPlaylistBtn.IsEnabled = false;
            Navigation.PushModalAsync(new PlaylistViewPage());
            viewPlaylistBtn.IsEnabled = true;
        }

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
                if (_homePageViewModel.VimeoInfo != null){
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
			}
			else
			{
                if (_homePageViewModel.VimeoInfo != null)
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
					innerGrid.Children.Clear();
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
}

