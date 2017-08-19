﻿using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistViewPage : ContentPage
    {
        private PlaylistViewPageViewModel _playlistViewPageViewModel = new PlaylistViewPageViewModel();
        private BaseViewModel _baseViewModel = new BaseViewModel();
        private Label viewPlaylistLbl;
        private ListView playlistView;
        private Grid innerGrid;
        private Grid outerGrid;
        private Label playlistLbl;
        private Frame playlistFrame;
        private Button backBtn;
        private StackLayout layout;
        private Account account;
        private string id;

        public PlaylistViewPage()
        {
            Title = "User Playlists";
            Padding = new Thickness(10, 30, 10, 10);
            FindPlaylists();
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

			//View Objects
			innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection 
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(7, GridUnitType.Star)},
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

            viewPlaylistLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "View Playlists",
				FontSize = lblSize * 2,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            playlistView = new ListView
            {
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None
            };

            backBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Back",
                FontSize = btnSize * 2,
                BackgroundColor = Color.Orange,
                BorderWidth = 3,
                TextColor = Color.Black
			};
            //Events
            backBtn.Clicked += GoBack;
            playlistView.ItemSelected += LoadPlaylist;

            //building grid
            innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
            innerGrid.Children.Add(playlistView, 0, 1);
            innerGrid.Children.Add(backBtn, 0, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        //Functions
        public void GoBack(object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
            backBtn.IsEnabled = true;
        }
        public async void FindPlaylists()
        {
            account = _baseViewModel.GetAccountInformation();
            id = account.Properties["Id"];
            await _playlistViewPageViewModel.GetUserPlaylists(Constants.GETPLAYLIST, id);
            SetViewContents();
        }
        public void SetViewContents()
        {
            playlistView.ItemsSource = _playlistViewPageViewModel.Playlist;
            playlistView.ItemTemplate = new DataTemplate(() =>
            {
				playlistLbl = new Label();
                playlistLbl.SetBinding(Label.TextProperty, "Name");
                playlistLbl.VerticalTextAlignment = TextAlignment.Center;
                playlistLbl.HorizontalTextAlignment = TextAlignment.Center;
                playlistLbl.TextColor = Color.Black;
                playlistLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2;
                playlistLbl.LineBreakMode = LineBreakMode.WordWrap;
#if __IOS__
                playlistLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                playListLbl.FontFamily = "Roboto Bold";
#endif

				playlistFrame = new Frame();
                playlistFrame.BackgroundColor = Color.SeaGreen;
				playlistFrame.HasShadow = false;
				playlistFrame.OutlineColor = Color.Black;
				//playlistFrame.Padding = 3;
                playlistFrame.Content = playlistLbl;
                playlistFrame.Padding = new Thickness(10, 10, 10, 10);

                layout = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Spacing = 0,
                    Padding = new Thickness(0, 5, 0, 5),
                    Children = {
                            playlistFrame
                        }
                };

                ViewCell viewCell = new ViewCell();
                viewCell.View = layout;

                return viewCell;
            });
        }

        public void LoadPlaylist(object sender, SelectedItemChangedEventArgs e)
        {
            PlayList playlist = (PlayList)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null) 
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
            Navigation.PushModalAsync(new PlaylistDetailPage(playlist));
        }

		//page reloading
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await _playlistViewPageViewModel.GetUserPlaylists(Constants.GETPLAYLIST, id);
			SetViewContents();

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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
                innerGrid.Children.Add(backBtn, 0, 2);
                innerGrid.Children.Add(playlistView, 1, 0);
                Grid.SetRowSpan(playlistView, 3);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
                innerGrid.Children.Add(playlistView, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
			}
		}
    }
}
