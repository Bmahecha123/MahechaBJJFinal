﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;

using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistCreatePage : ContentPage
    {
        private BaseViewModel _baseViewModel = new BaseViewModel();
        private PlaylistCreatePageViewModel _playlistCreatePageViewModel = new PlaylistCreatePageViewModel();
        private string FINDUSER = Constants.FINDUSER;
        private Grid outerGrid;
        private Grid innerGrid;
        private Label playListNameLbl;
        private Entry playListNameEntry;
        private Label playListDescriptionLbl;
        private Editor playListDescriptionEditor;
        private Frame editorFrame;
        private Button backBtn;
        private Button createBtn;
        private Account account;
        private User user;
        private PlayList playlist;

        public PlaylistCreatePage()
        {
			
			//View objects
			Title = "Create Playlist";
			Padding = new Thickness(10, 30, 10, 10);

            SetContent();
        }

        //functions
        public void SetContent()
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

			//Layout
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}



				},
				ColumnDefinitions = new ColumnDefinitionCollection
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};
			outerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};

			//View objects
			playListNameLbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Name:",
				FontSize = lblSize * 2
			};
			playListNameEntry = new Entry
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Placeholder = "Leg Lasso List",
				FontSize = lblSize,

			};
			playListDescriptionLbl = new Label
			{
				Text = "Description:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize * 2

			};
			playListDescriptionEditor = new Editor
			{
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Editor)),
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif

			};
			editorFrame = new Frame
			{
				Content = playListDescriptionEditor,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
			};
			backBtn = new Button
			{
				Text = "Back",
				BorderWidth = 3,
				BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};
			createBtn = new Button
			{
				Text = "Create",
				BorderWidth = 3,
				BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};

			//events
			backBtn.Clicked += GoBack;
			createBtn.Clicked += CreatePlaylist;

			//building grid
			innerGrid.Children.Add(playListNameLbl, 0, 0);
			playListNameLbl.VerticalTextAlignment = TextAlignment.Center;
			playListNameLbl.HorizontalTextAlignment = TextAlignment.Center;
			Grid.SetColumnSpan(playListNameLbl, 2);
			innerGrid.Children.Add(playListNameEntry, 0, 1);
			Grid.SetColumnSpan(playListNameEntry, 2);
			innerGrid.Children.Add(playListDescriptionLbl, 0, 2);
			Grid.SetColumnSpan(playListDescriptionLbl, 2);
			playListDescriptionLbl.VerticalTextAlignment = TextAlignment.Center;
			playListDescriptionLbl.HorizontalTextAlignment = TextAlignment.Center;
			innerGrid.Children.Add(editorFrame, 0, 3);
			Grid.SetRowSpan(editorFrame, 3);
			Grid.SetColumnSpan(editorFrame, 2);
			innerGrid.Children.Add(backBtn, 0, 7);
			innerGrid.Children.Add(createBtn, 1, 7);

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        public void GoBack(object sender, EventArgs e) 
        {
            Navigation.PopModalAsync();
        }

        public async void CreatePlaylist(object sender, EventArgs e)
        {
            if (playListNameEntry.Text != null){
				playlist = new PlayList();
				playlist.Name = playListNameEntry.Text;
				playlist.Description = playListDescriptionEditor.Text;
				account = _baseViewModel.GetAccountInformation();
				user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
				await _playlistCreatePageViewModel.CreatePlaylist(playlist, user.Id);
                if (_playlistCreatePageViewModel.Successful)
                {
					await DisplayAlert("Playlist Added", playlist.Name + " has been successfully added!", "Ok");
					await Navigation.PopModalAsync();
                } else {
                    await DisplayAlert("Playlist Not Added", playlist.Name + " has not been added. Check your network connectivity!", "Ok");
                }
            }
            else {
                await DisplayAlert("Error", "Name cannot be empty, fill it in!", "Ok");
                playListNameEntry.Focus();
            }
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
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(playListNameLbl, 0, 0);
                innerGrid.Children.Add(playListNameEntry, 1, 0);
                innerGrid.Children.Add(playListDescriptionLbl, 0, 1);
                innerGrid.Children.Add(editorFrame, 1, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
                innerGrid.Children.Add(createBtn, 1, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				//building grid
				innerGrid.Children.Add(playListNameLbl, 0, 0);
				playListNameLbl.VerticalTextAlignment = TextAlignment.Center;
				playListNameLbl.HorizontalTextAlignment = TextAlignment.Center;
				Grid.SetColumnSpan(playListNameLbl, 2);
				innerGrid.Children.Add(playListNameEntry, 0, 1);
				Grid.SetColumnSpan(playListNameEntry, 2);
				innerGrid.Children.Add(playListDescriptionLbl, 0, 2);
				Grid.SetColumnSpan(playListDescriptionLbl, 2);
				playListDescriptionLbl.VerticalTextAlignment = TextAlignment.Center;
				playListDescriptionLbl.HorizontalTextAlignment = TextAlignment.Center;
				innerGrid.Children.Add(editorFrame, 0, 3);
				Grid.SetRowSpan(editorFrame, 3);
				Grid.SetColumnSpan(editorFrame, 2);
				innerGrid.Children.Add(backBtn, 0, 7);
				innerGrid.Children.Add(createBtn, 1, 7);
			}
		}
    }
}

