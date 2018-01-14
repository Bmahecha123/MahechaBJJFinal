using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
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
        private Button qualityBtn;
        private Grid innerGrid;
        private Grid outerGrid;
        private Video videoTechnique;
        private PlayList userPlaylist;

        public PlaylistVideoPage(Video video, PlayList playlist)
        {
            _baseViewModel = new BaseViewModel();
            _playListVideoPageViewModel = new PlaylistVideoPageViewModel();
            videoUrl = video.Link;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
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
                    #if __ANDROID__
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
                    #endif
#if __IOS__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
#endif
                    new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
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
                BackgroundColor = Color.FromRgb(124, 37, 41)
            };
            videoNameLbl = new Label
            {
                Text = video.Name,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
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
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };
            deleteBtn = new Button
            {
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.White,
#if __IOS__
                Text = "Delete From Playlist",
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                Text = "D",
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
                Margin = -5,
#endif
                BackgroundColor = Color.Red
            };

            qualityBtn = new Button
            {
                Text = "SD",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };


            //Events
            backBtn.Clicked += GoBack;
            deleteBtn.Clicked += DeleteFromPlaylist;
            qualityBtn.Clicked += ChangeVideoQuality;
#if __IOS__
            playBtn.Clicked += PlayIOSVideo;
#endif
#if __ANDROID__
            playBtn.Clicked += PlayAndroidVideo;
#endif
            //building grid
            innerGrid.Children.Add(videoFrame, 0, 0);
            Grid.SetColumnSpan(videoFrame, 4);
            innerGrid.Children.Add(videoNameLbl, 0, 0);
            Grid.SetColumnSpan(videoNameLbl, 4);
            innerGrid.Children.Add(playBtn, 0, 1);
            innerGrid.Children.Add(qualityBtn, 3, 1);
            innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
            Grid.SetColumnSpan(videoDescriptionScrollView, 4);

#if __ANDROID__
            Grid.SetRowSpan(videoDescriptionScrollView, 3);
            Grid.SetColumnSpan(playBtn, 2);
            innerGrid.Children.Add(deleteBtn, 2, 1);
#endif
#if __IOS__
            Grid.SetColumnSpan(playBtn, 3);

            innerGrid.Children.Add(deleteBtn, 0, 3);
            Grid.SetColumnSpan(deleteBtn, 4);
            innerGrid.Children.Add(backBtn, 0, 4);
            Grid.SetColumnSpan(backBtn, 4);
#endif
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public void PlayIOSVideo(object sender, EventArgs e)
        {
            ToggleButtons();
            MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
            ToggleButtons();
        }

        public async void PlayAndroidVideo(object sender, EventArgs e)
        {
            ToggleButtons();
#if __ANDROID__
            await Navigation.PushModalAsync(new AndroidVideoPage(videoUrl));
#endif
            ToggleButtons();
        }

        public void GoBack(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PopModalAsync();
        }

        public async void DeleteFromPlaylist(object sender, EventArgs e)
        {
            ToggleButtons();
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
                    ToggleButtons();
                }
                else
                {
                    await DisplayAlert("Video Not Deleted From Playlist", videoTechnique.Name + " has not been deleted from " + userPlaylist.Name + ". Try again!", "Ok");
                    ToggleButtons();
                }
            }
            else
            {
                ToggleButtons();
                return;
            }

        }

        public void ToggleButtons()
        {
            deleteBtn.IsEnabled = !deleteBtn.IsEnabled;
            backBtn.IsEnabled = !backBtn.IsEnabled;
            qualityBtn.IsEnabled = !qualityBtn.IsEnabled;
            playBtn.IsEnabled = !playBtn.IsEnabled;
        }

        public async void ChangeVideoQuality(object sender, EventArgs e)
        {
            ToggleButtons();
            string result;
            if (qualityBtn.Text == "SD")
            {
                string[] videoQuality = { "HD" };
                result = await DisplayActionSheet("Video Quality", "Cancel", null, videoQuality);

            }
            else
            {
                string[] videoQuality = { "SD" };
                result = await DisplayActionSheet("Video Quality", "Cancel", null, videoQuality);
            }

            if (result == "SD")
            {
                videoUrl = videoTechnique.Link;
                qualityBtn.Text = "SD";
            }
            else if (result == "HD")
            {
                videoUrl = videoTechnique.LinkHD;
                qualityBtn.Text = "HD";
            }
            ToggleButtons();
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                deleteBtn.Text = "D";

                innerGrid.Children.Clear();
                innerGrid.Children.Add(videoFrame, 0, 0);
                Grid.SetRowSpan(videoFrame, 2);
                Grid.SetColumnSpan(videoFrame, 2);
                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetRowSpan(videoNameLbl, 2);
                Grid.SetColumnSpan(videoNameLbl, 2);
                innerGrid.Children.Add(backBtn, 2, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 2, 0);
                Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                innerGrid.Children.Add(playBtn, 3, 1);
                innerGrid.Children.Add(deleteBtn, 4, 1);
                innerGrid.Children.Add(qualityBtn, 5, 1);
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                deleteBtn.Text = "Delete From Playlist";

                innerGrid.Children.Clear();
                //building grid
                innerGrid.Children.Add(videoFrame, 0, 0);
                Grid.SetColumnSpan(videoFrame, 4);
                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetColumnSpan(videoNameLbl, 4);
                innerGrid.Children.Add(playBtn, 0, 1);
                Grid.SetColumnSpan(playBtn, 3);
                innerGrid.Children.Add(qualityBtn, 3, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                innerGrid.Children.Add(deleteBtn, 0, 3);
                Grid.SetColumnSpan(deleteBtn, 4);
                innerGrid.Children.Add(backBtn, 0, 4);
                Grid.SetColumnSpan(backBtn, 4);
            }
        }
#endif
    }
}

