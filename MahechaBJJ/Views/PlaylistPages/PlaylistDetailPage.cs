﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistDetailPage : ContentPage
    {
		private BaseViewModel _baseViewModel = new BaseViewModel();
        private PlaylistDetailPageViewModel _playListDetailPageViewModel = new PlaylistDetailPageViewModel();
        private Account account;
        private string id;
        private Label playlistNameLbl;
        private Label playlistDescriptionLbl;
        private ListView videosListView;
        private Button backBtn;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid videoGrid;
        private Frame videoFrame;
        private Image videoImage;
        private Label videoLbl;
        private Button deleteBtn;
        private PlayList userPlaylist;
        private ObservableCollection<Video> videos;

        public PlaylistDetailPage(PlayList playlist)
        {
            Title = playlist.Name;
            Padding = new Thickness(10, 30, 10, 10);
			userPlaylist = playlist;
			FindPlaylist();
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //View Objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection 
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(10, GridUnitType.Star)},
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

            playlistNameLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = playlist.Name,
				FontSize = lblSize * 2,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };

            playlistDescriptionLbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = playlist.Description,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            videosListView = new ListView
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

            deleteBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Delete",
				FontSize = btnSize * 2,
                BackgroundColor = Color.Red,
				BorderWidth = 3,
                TextColor = Color.White
            };

            //Events
            backBtn.Clicked += GoBack;
            deleteBtn.Clicked += DeletePlaylist;
            videosListView.ItemSelected += LoadVideo;

            //Building Grid
            innerGrid.Children.Add(playlistNameLbl, 0, 0);
            Grid.SetColumnSpan(playlistNameLbl, 2);
            innerGrid.Children.Add(videosListView, 0, 1);
            Grid.SetColumnSpan(videosListView, 2);
            innerGrid.Children.Add(backBtn, 0, 2);
            innerGrid.Children.Add(deleteBtn, 1, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
		}

        //Functions
        public void GoBack(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public async void DeletePlaylist(object sender, EventArgs e)
        {
            bool delete = await DisplayAlert("Delete Playlist", "Are you sure you want to delete " + userPlaylist.Name + "?", "Yes", "No");
            if (delete)
            {
                await _playListDetailPageViewModel.DeleteUserPlaylist(Constants.DELETEPLAYLIST, id, userPlaylist);
                if (_playListDetailPageViewModel.Successful)
                {
                    
					await DisplayAlert("Playlist Deleted", userPlaylist.Name + " has been deleted.", "Ok");
					await Navigation.PopModalAsync();
                } else {
					await DisplayAlert("Unable To Delete", userPlaylist.Name + " has not been deleted. Try again.", "Ok");
				}
            } else {
                return;
            }
        }

        public void LoadVideo(object sender, SelectedItemChangedEventArgs e)
        {
            Video video = (Video)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
			//VideoData videoData = new VideoData(video.Name, video.Description, video.Link, video.Image);
			((ListView)sender).SelectedItem = null;
            Navigation.PushModalAsync(new PlaylistVideoPage(video, userPlaylist));

		}

        public async void FindPlaylist()
        {
			account = _baseViewModel.GetAccountInformation();
			id = account.Properties["Id"];
			await _playListDetailPageViewModel.FindUserPlaylist(Constants.FINDPLAYLIST, id, userPlaylist.Name);
            videos = _playListDetailPageViewModel.Playlist.Videos;
			SetViewContents();
        }

        public void SetViewContents()
        {
            videosListView.ItemsSource = videos;

            videosListView.ItemTemplate = new DataTemplate(() =>
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                    videoImage = new Image();
                    videoImage.SetBinding(Image.SourceProperty, "Image");
                    videoImage.Aspect = Aspect.Fill;

                    videoLbl = new Label();
#if __IOS__
                    videoLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "Roboto Bold";
#endif
                    videoLbl.SetBinding(Label.TextProperty, "Name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.TextColor = Color.White;
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.OutlineColor = Color.Black;
                    videoFrame.BackgroundColor = Color.Black;
                    videoFrame.HasShadow = false;
                    videoFrame.Padding = 3;

                    videoGrid.Children.Add(videoFrame, 0, 0);
                    videoGrid.Children.Add(videoLbl, 0, 0);

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Spacing = 0,
                            Padding = new Thickness(0, 5, 0, 5),
                            Children = {
                                videoGrid
                            }
                        }
                    };
                });
		}


		//page reloading
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			account = _baseViewModel.GetAccountInformation();
			id = account.Properties["Id"];
            PlaylistDetailPageViewModel viewModel = new PlaylistDetailPageViewModel();
            await viewModel.FindUserPlaylist(Constants.FINDPLAYLIST, id, userPlaylist.Name);
            videosListView.ItemsSource = viewModel.Playlist.Videos;
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
                innerGrid.Children.Add(playlistNameLbl, 0, 0);
                innerGrid.Children.Add(deleteBtn, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
                innerGrid.Children.Add(videosListView, 1, 0);
                Grid.SetRowSpan(videosListView, 3);
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
				//Building Grid
				innerGrid.Children.Add(playlistNameLbl, 0, 0);
				Grid.SetColumnSpan(playlistNameLbl, 2);
                innerGrid.Children.Add(playlistDescriptionLbl, 0, 1);
                Grid.SetColumnSpan(playlistDescriptionLbl, 2);
				innerGrid.Children.Add(videosListView, 0, 2);
				Grid.SetColumnSpan(videosListView, 2);
				innerGrid.Children.Add(backBtn, 0, 3);
				innerGrid.Children.Add(deleteBtn, 1, 3);
            }
        }
    }
}
