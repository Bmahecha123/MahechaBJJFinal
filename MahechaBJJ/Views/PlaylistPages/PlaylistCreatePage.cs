﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;

using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistCreatePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private PlaylistCreatePageViewModel _playlistCreatePageViewModel;
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
            _baseViewModel = new BaseViewModel();
            _playlistCreatePageViewModel = new PlaylistCreatePageViewModel();
            //View objects
            Title = "Create Playlist";
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif

            BuildPageObjects();
        }

        //functions
        public void BuildPageObjects()
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
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
                Text = "Name:"
            };
            playListNameEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Placeholder = "Leg Lasso List"

            };
            playListDescriptionLbl = new Label
            {
                Text = "Description:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
            };
            playListDescriptionEditor = new Editor
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Editor)),
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                BackgroundColor = Color.White
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
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black
            };
            createBtn = new Button
            {
                Text = "Create",
                BorderWidth = 3,
                BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize * 1.25,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
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
#if __IOS__
            innerGrid.Children.Add(backBtn, 0, 7);
            innerGrid.Children.Add(createBtn, 1, 7);
#endif
#if __ANDROID__
            innerGrid.Children.Add(createBtn, 0, 6);
            Grid.SetRowSpan(createBtn, 2);
            Grid.SetColumnSpan(createBtn, 2);
#endif

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public void GoBack(object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
        }

        public async void CreatePlaylist(object sender, EventArgs e)
        {
            createBtn.IsEnabled = false;
            backBtn.IsEnabled = false;
            if (playListNameEntry.Text != null)
            {
                playlist = new PlayList();
                playlist.Name = playListNameEntry.Text;
                playlist.Description = playListDescriptionEditor.Text;
                account = _baseViewModel.GetAccountInformation();
                user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
                await _playlistCreatePageViewModel.CreatePlaylist(playlist, user.Id);
                if (_playlistCreatePageViewModel.Successful)
                {
                    await Navigation.PopModalAsync();
                }
                else
                {
                    await DisplayAlert("Playlist Not Added", playlist.Name + " has not been added. Check your network connectivity!", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Error", "Name cannot be empty, fill it in!", "Ok");
                playListNameEntry.Focus();
            }
            createBtn.IsEnabled = true;
            backBtn.IsEnabled = true;
        }

        //Orientation
#if __IOS__
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 10, 10, 10);
#endif
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
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 30, 10, 10);
#endif
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
#endif
    }
}

