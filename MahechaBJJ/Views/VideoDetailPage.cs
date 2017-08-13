﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
/*#if __IOS__
using Xamarin.Forms.Platform.iOS;
using UIKit;
using AVFoundation;
using Foundation;
using MediaPlayer;
#endif */

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class VideoDetailPage : ContentPage
    {
        private BaseViewModel _baseViewModel = new BaseViewModel();
        private VideoDetailPageViewModel _videoDetailPageViewModel = new VideoDetailPageViewModel();
		private ObservableCollection<PlayList> userPlaylists = new ObservableCollection<PlayList>();
        private ObservableCollection<Video> videos;
        private Account account;
		private string videoUrl;
        private Button backBtn;
        private Label videoNameLbl;
        private Label videoDescription;
        private ScrollView videoDescriptionScrollView;
        private Image videoImage;
        private Frame videoFrame;
        private Button playBtn;
        private Button addBtn;
        private Grid innerGrid;
        private Grid outerGrid;
        private VideoData videoTechnique;
        //UIViewController uiView;
        //UIWindow window;

        public VideoDetailPage(VideoData video)
        {
            videoUrl = video.files[0].link;
            Padding = new Thickness(10, 30, 10, 10);
            Title = video.name;
            videoTechnique = video;

            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            //view objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
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

            backBtn = new Button
            {
                Text = "Back",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
                BackgroundColor = Color.Orange
            };
            videoNameLbl = new Label
            {
                Text = video.name,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = lblSize,
                TextColor = Color.White
            };

            videoDescription = new Label
            {
                Text = video.description,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalTextAlignment = TextAlignment.Start,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                LineBreakMode = LineBreakMode.WordWrap,

            };

            videoDescriptionScrollView = new ScrollView
            {
                Padding = 0,
                Content = videoDescription,
                Orientation = ScrollOrientation.Vertical
            };

            videoImage = new Image
            {
                Source = video.pictures.sizes[4].link,
                Aspect = Aspect.AspectFill
            };
            videoFrame = new Frame
            {
                Content = videoImage,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3

            };
            playBtn = new Button
            {
                Text = "Play",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
                BackgroundColor = Color.Orange
            };
            addBtn = new Button
            {
                Text = "Add",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
                BackgroundColor = Color.Orange
            };

            //Events
            backBtn.Clicked += GoBack;
            addBtn.Clicked += AddVideoToPlaylist;
#if __IOS__
            playBtn.Clicked += PlayIOSVideo;
#endif
#if __ANDROID__
            playVideo.Clicked += PlayAndroidVideo;
#endif
            //building grid
            innerGrid.Children.Add(videoFrame, 0, 0);
            Grid.SetColumnSpan(videoFrame, 2);
            innerGrid.Children.Add(videoNameLbl, 0, 0);
            Grid.SetColumnSpan(videoNameLbl, 2);
            innerGrid.Children.Add(playBtn, 0, 1);
            innerGrid.Children.Add(addBtn, 1, 1);
            innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
            Grid.SetColumnSpan(videoDescriptionScrollView, 2);
            innerGrid.Children.Add(backBtn, 0, 3);
            Grid.SetColumnSpan(backBtn, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        //Functions
        public void PlayIOSVideo(object sender, EventArgs e)
        {
            playBtn.IsEnabled = false;
            MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
            playBtn.IsEnabled = true;
        }

        public async void PlayAndroidVideo(object sender, EventArgs e)
        {
            playBtn.IsEnabled = false;
            await Navigation.PushModalAsync(new AndroidVideoPage(videoTechnique.files[1].link));
            playBtn.IsEnabled = true;
        }

        public void GoBack(object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
        }

        public async void AddVideoToPlaylist(object sender, EventArgs e)
        {
            //get user info
            account = _baseViewModel.GetAccountInformation();
            //Get playlist information
            await _videoDetailPageViewModel.GetUserPlaylists(Constants.GETPLAYLIST, account.Properties["Id"]);
            userPlaylists = _videoDetailPageViewModel.Playlist;

            List<string> playlistNames = GetPlaylistNames(userPlaylists);
            string answer = await DisplayActionSheet("Add to Playlist", "Cancel", null, playlistNames.ToArray());
            if (answer == playlistNames[0])
            {
                await Navigation.PushModalAsync(new PlaylistCreatePage());
            } else if (answer != "Cancel")
            {
                UpdatePlaylist(userPlaylists, answer);
			}
        }

        public List<string> GetPlaylistNames(ObservableCollection<PlayList> playlists)
        {
            List<string> playlistNames = new List<string>();
            playlistNames.Add("Create New Playlist");
            foreach (PlayList playlist in playlists)
            {
                playlistNames.Add(playlist.Name);
            }
            return playlistNames;
        }

        public async void UpdatePlaylist(ObservableCollection<PlayList> playlists, string playlistName)
        {
			Video videoToBeAdded = new Video(videoTechnique.name, videoTechnique.pictures.sizes[3].link, videoTechnique.files[0].link, videoTechnique.description);
			PlayList playlist = playlists.FirstOrDefault(x => x.Name == playlistName);

            foreach (Video userVideo in playlist.Videos)
            {
                if (userVideo.Name.Contains(videoToBeAdded.Name))
				{
                    await DisplayAlert("Video Already in Playlist", videoToBeAdded.Name + " already part of " + playlist.Name, "Ok");
                    return;
				}
            }

			if (playlist.Videos == null)
			{
				videos = new ObservableCollection<Video>();
			}
			else
			{
				videos = playlist.Videos;
			}
			videos.Add(videoToBeAdded);
			playlist.Videos = videos;

			await _videoDetailPageViewModel.UpdateUserPlaylist(Constants.UPDATEPLAYLIST, account.Properties["Id"], playlist);
			if (_videoDetailPageViewModel.Successful == true)
			{
				await DisplayAlert("Video Added", videoTechnique.name + " has been added to " + playlist.Name, "Ok");
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

				innerGrid.Children.Clear();
                innerGrid.Children.Add(videoFrame, 0, 0);
                Grid.SetRowSpan(videoFrame, 2);
                Grid.SetColumnSpan(videoFrame, 2);
                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetRowSpan(videoNameLbl, 2);
                Grid.SetColumnSpan(videoNameLbl, 2);
                innerGrid.Children.Add(backBtn, 2, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 2, 0);
                Grid.SetColumnSpan(videoDescriptionScrollView, 3);
                innerGrid.Children.Add(playBtn, 3, 1);
                innerGrid.Children.Add(addBtn, 4, 1);
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(videoFrame, 0, 0);
                Grid.SetColumnSpan(videoFrame, 2);
                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetColumnSpan(videoNameLbl, 2);
                innerGrid.Children.Add(playBtn, 0, 1);
                innerGrid.Children.Add(addBtn, 1, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                Grid.SetColumnSpan(videoDescriptionScrollView, 2);
                innerGrid.Children.Add(backBtn, 0, 3);
                Grid.SetColumnSpan(backBtn, 2);
            }
        }
    }
}

