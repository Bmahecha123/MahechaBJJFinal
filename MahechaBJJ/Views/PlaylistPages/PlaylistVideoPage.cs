using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistVideoPage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private PlaylistVideoPageViewModel _playListVideoPageViewModel;
		private Account account;
        private string id;
		private string videoUrl;
		private Button backBtn;
		private Label videoNameLbl;
		private Label videoDescription;
		private ScrollView videoDescriptionScrollView;
		private Image videoImage;
		private Frame videoFrame;
		private Button playBtn;
        private Button deleteBtn;
		private Grid innerGrid;
		private Grid outerGrid;
		private Video videoTechnique;
        private PlayList userPlaylist;

        public PlaylistVideoPage(Video video, PlayList playlist)
        {
            _baseViewModel = new BaseViewModel();
            _playListVideoPageViewModel = new PlaylistVideoPageViewModel();
            videoUrl = video.Link;
			Padding = new Thickness(10, 30, 10, 10);
            Title = video.Name;
			videoTechnique = video;
            userPlaylist = playlist;
            SetContent(video, playlist);
			
        }

		//Functions
        public void SetContent(Video video, PlayList playlist)
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

			//view objects
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
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
				Text = video.Name,
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
				Text = video.Description,
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
				Source = video.Image,
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
			deleteBtn = new Button
			{
				Text = "Delete From Playlist",
				BorderWidth = 3,
				BorderColor = Color.Black,
				TextColor = Color.White,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 1.5,
				BackgroundColor = Color.Red
			};

			//Events
			backBtn.Clicked += GoBack;
			deleteBtn.Clicked += DeleteFromPlaylist;
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
			Grid.SetColumnSpan(playBtn, 2);
			innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
			Grid.SetColumnSpan(videoDescriptionScrollView, 2);
			innerGrid.Children.Add(deleteBtn, 0, 3);
			Grid.SetColumnSpan(deleteBtn, 2);
			innerGrid.Children.Add(backBtn, 0, 4);
			Grid.SetColumnSpan(backBtn, 2);

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

		public void PlayIOSVideo(object sender, EventArgs e)
		{
			playBtn.IsEnabled = false;
			MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
			playBtn.IsEnabled = true;
		}

		public async void PlayAndroidVideo(object sender, EventArgs e)
		{
			playBtn.IsEnabled = false;
            await Navigation.PushModalAsync(new AndroidVideoPage(videoUrl));
			playBtn.IsEnabled = true;
		}

		public void GoBack(object sender, EventArgs e)
		{
			backBtn.IsEnabled = false;
			Navigation.PopModalAsync();
		}

        public async void DeleteFromPlaylist(object sender, EventArgs e)
        {
            bool deleteVideo = await DisplayAlert("Delete Video From Playlist", "Remove " + videoTechnique.Name + " from " + userPlaylist.Name + "?", "Yes", "No");

            if (deleteVideo)
            {
				account = _baseViewModel.GetAccountInformation();
                id = account.Properties["Id"];
                await _playListVideoPageViewModel.DeleteVideoFromPlaylist(Constants.DELETEVIDEOFROMPLAYLIST, id, userPlaylist, videoTechnique.Name);
                if (_playListVideoPageViewModel.Successful)
                {
                    await DisplayAlert("Video Deleted From Playlist", videoTechnique.Name + " has been successfully deleted from " + userPlaylist.Name + ".", "Ok");
                    await Navigation.PopModalAsync();
                } else {
					await DisplayAlert("Video Not Deleted From Playlist", videoTechnique.Name + " has not been deleted from " + userPlaylist.Name + ". Try again!", "Ok");
				}
            } else {
                return;
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
				innerGrid.Children.Add(deleteBtn, 4, 1);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				innerGrid.Children.Add(videoFrame, 0, 0);
				Grid.SetColumnSpan(videoFrame, 2);
				innerGrid.Children.Add(videoNameLbl, 0, 0);
				Grid.SetColumnSpan(videoNameLbl, 2);
				innerGrid.Children.Add(playBtn, 0, 1);
				Grid.SetColumnSpan(playBtn, 2);
				innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
				Grid.SetColumnSpan(videoDescriptionScrollView, 2);
				innerGrid.Children.Add(deleteBtn, 0, 3);
				Grid.SetColumnSpan(deleteBtn, 2);
				innerGrid.Children.Add(backBtn, 0, 4);
				Grid.SetColumnSpan(backBtn, 2);
			}
		}
    }
}

