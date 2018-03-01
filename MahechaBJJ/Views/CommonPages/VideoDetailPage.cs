using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;
#if __ANDROID__
using MahechaBJJ.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
#endif

namespace MahechaBJJ.Views
{
    public class VideoDetailPage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private VideoDetailPageViewModel _videoDetailPageViewModel;
        private ObservableCollection<PlayList> userPlaylists;
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
        private Button qualityBtn;
        private Grid innerGrid;
        private Grid outerGrid;
        private VideoData videoTechnique;
        private bool userHasAccount;
#if __ANDROID__
        private Grid buttonGrid;
        private Android.Widget.TextView androidVideoNameLbl;
        private Android.Widget.TextView androidVideoDescriptionLbl;
        private Android.Widget.Button androidPlayBtn;
        private Android.Widget.Button androidAddBtn;
        private Android.Widget.Button androidQualityBtn;

        private ContentView contentViewNameLbl;
        private ContentView contentViewDescriptionLbl;
        private ContentView contentViewPlayBtn;
        private ContentView contentViewAddBtn;
        private ContentView contentViewQualityBtn;
#endif

        public VideoDetailPage(VideoData video)
        {
            _baseViewModel = new BaseViewModel();
            _videoDetailPageViewModel = new VideoDetailPageViewModel();
            userPlaylists = new ObservableCollection<PlayList>();
            videoUrl = video.files[0].link;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif

            Title = video.name;
            videoTechnique = video;
            DoesUserHaveAccount();
            SetContent();
        }

        //Functions

        private void DoesUserHaveAccount()
        {
            account = _baseViewModel.GetAccountInformation();
            if (account.Username == "NO_ACCOUNT")
            {
                userHasAccount = false;
            }
            else
            {
                userHasAccount = true;
            }

        }

        public void SetContent()
        {

            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            //view objects
#if __IOS__
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
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}

                }
            };
#endif
#if __ANDROID__
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            if (userHasAccount)
            {
                buttonGrid = new Grid
                {
                    ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
                };
            }
            else
            {
                buttonGrid = new Grid
                {
                    ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
                };
            }

#endif

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidVideoNameLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidVideoNameLbl.Text = videoTechnique.name;
            androidVideoNameLbl.Typeface = Constants.COMMONFONT;
            androidVideoNameLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidVideoNameLbl.SetTextColor(Android.Graphics.Color.AntiqueWhite);
            androidVideoNameLbl.Gravity = Android.Views.GravityFlags.Center;
            androidVideoNameLbl.SetTypeface(androidVideoNameLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidVideoDescriptionLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidVideoDescriptionLbl.Text = videoTechnique.description;
            androidVideoDescriptionLbl.Typeface = Constants.COMMONFONT;
            androidVideoDescriptionLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 50);
            androidVideoDescriptionLbl.SetTextColor(Android.Graphics.Color.Black);
            androidVideoDescriptionLbl.Gravity = Android.Views.GravityFlags.Start;

            androidPlayBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidPlayBtn.Text = "Play";
            androidPlayBtn.Typeface = Constants.COMMONFONT;
            androidPlayBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidPlayBtn.SetTextColor(Android.Graphics.Color.Black);
            androidPlayBtn.SetBackground(pd);
            androidPlayBtn.Gravity = Android.Views.GravityFlags.Center;
            androidPlayBtn.SetAllCaps(false);
            androidPlayBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await PlayAndroidVideo(sender, e);
                ToggleButtons();
            };

            androidAddBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidAddBtn.Text = "+";
            androidAddBtn.Typeface = Constants.COMMONFONT;
            androidAddBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidAddBtn.SetTextColor(Android.Graphics.Color.Black);
            androidAddBtn.SetBackground(pd);
            androidAddBtn.Gravity = Android.Views.GravityFlags.Center;
            androidAddBtn.SetAllCaps(false);
            androidAddBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await AddVideoToPlaylist(sender, e);
                ToggleButtons();
            };

            androidQualityBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidQualityBtn.Text = "SD";
            androidQualityBtn.Typeface = Constants.COMMONFONT;
            androidQualityBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidQualityBtn.SetTextColor(Android.Graphics.Color.Black);
            androidQualityBtn.SetBackground(pd);
            androidQualityBtn.Gravity = Android.Views.GravityFlags.Center;
            androidQualityBtn.SetAllCaps(false);
            androidQualityBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await ChangeVideoQuality(sender, e);
                ToggleButtons();
            };

            contentViewNameLbl = new ContentView();
            contentViewNameLbl.Content = androidVideoNameLbl.ToView();
            contentViewDescriptionLbl = new ContentView();
            contentViewDescriptionLbl.Content = androidVideoDescriptionLbl.ToView();
            contentViewPlayBtn = new ContentView();
            contentViewPlayBtn.Content = androidPlayBtn.ToView();
            contentViewAddBtn = new ContentView();
            contentViewAddBtn.Content = androidAddBtn.ToView();
            contentViewQualityBtn = new ContentView();
            contentViewQualityBtn.Content = androidQualityBtn.ToView();
#endif

            backBtn = new Button
            {
                Text = "Back",
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
#endif
                BackgroundColor = Color.FromRgb(124, 37, 41)
            };
            videoNameLbl = new Label
            {
                Text = videoTechnique.name,
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
                Text = videoTechnique.description,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Black,

#endif
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalTextAlignment = TextAlignment.Start,
                LineBreakMode = LineBreakMode.WordWrap,

            };

            videoDescriptionScrollView = new ScrollView
            {
                Padding = 0,
#if __ANDROID__
                Content = contentViewDescriptionLbl,
                IsClippedToBounds = true,
#endif
#if __IOS__
                Content = videoDescription,

#endif
                Orientation = ScrollOrientation.Vertical
            };

            videoImage = new Image
            {
                Source = videoTechnique.pictures.sizes[4].link,
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
            addBtn = new Button
            {
                Text = "+",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 3,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174)
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
            backBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            addBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await AddVideoToPlaylist(sender, e);
                ToggleButtons();
            };
            qualityBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await ChangeVideoQuality(sender, e);
                ToggleButtons();
            };
#if __IOS__
            playBtn.Clicked += PlayIOSVideo;
#endif
#if __ANDROID__
            playBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await PlayAndroidVideo(sender, e);
                ToggleButtons();
            };
#endif

            if (userHasAccount)
            {
                //building grid
                innerGrid.Children.Add(videoFrame, 0, 0);
#if __IOS__
                Grid.SetColumnSpan(videoFrame, 4);

                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetColumnSpan(videoNameLbl, 4);
                innerGrid.Children.Add(playBtn, 0, 1);
                Grid.SetColumnSpan(playBtn, 2);
                innerGrid.Children.Add(addBtn, 2, 1);
                innerGrid.Children.Add(qualityBtn, 3, 1);

                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                innerGrid.Children.Add(backBtn, 0, 3);
                Grid.SetColumnSpan(backBtn, 4);
#endif
#if __ANDROID__
                buttonGrid.Children.Add(contentViewPlayBtn, 0, 0);
                buttonGrid.Children.Add(contentViewAddBtn, 1, 0);
                buttonGrid.Children.Add(contentViewQualityBtn, 2, 0);

                innerGrid.Children.Add(contentViewNameLbl, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                Grid.SetRowSpan(videoDescriptionScrollView, 2);
#endif
            }
            else
            {
                //building grid
#if __ANDROID__
                buttonGrid.Children.Add(contentViewPlayBtn, 0, 0);
                buttonGrid.Children.Add(contentViewQualityBtn, 1, 0);

                innerGrid.Children.Add(videoFrame, 0, 0);
                innerGrid.Children.Add(contentViewNameLbl, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
#endif
#if __IOS__
                innerGrid.Children.Add(videoFrame, 0, 0);
                Grid.SetColumnSpan(videoFrame, 4);
                innerGrid.Children.Add(videoNameLbl, 0, 0);
                Grid.SetColumnSpan(videoNameLbl, 4);
                innerGrid.Children.Add(playBtn, 0, 1);
                Grid.SetColumnSpan(playBtn, 2);
                innerGrid.Children.Add(qualityBtn, 2, 1);
                Grid.SetColumnSpan(qualityBtn, 2);
                innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                Grid.SetColumnSpan(videoDescriptionScrollView, 4);
#endif
#if __ANDROID__
                Grid.SetRowSpan(videoDescriptionScrollView, 2);
#endif
#if __IOS__
                innerGrid.Children.Add(backBtn, 0, 3);
                Grid.SetColumnSpan(backBtn, 4);
#endif
            }



            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public void PlayIOSVideo(object sender, EventArgs e)
        {
            ToggleButtons();
            MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
            ToggleButtons();
        }

        public async Task PlayAndroidVideo(object sender, EventArgs e)
        {
#if __ANDROID__
            await Navigation.PushModalAsync(new AndroidVideoPage(videoTechnique.files[1].link));
#endif
        }

        public void ToggleButtons()
        {
#if __ANDROID__
            androidAddBtn.Clickable = !androidAddBtn.Clickable;
            androidPlayBtn.Clickable = !androidPlayBtn.Clickable;
            androidQualityBtn.Clickable = !androidQualityBtn.Clickable;
#endif
            backBtn.IsEnabled = !backBtn.IsEnabled;
            addBtn.IsEnabled = !addBtn.IsEnabled;
            playBtn.IsEnabled = !playBtn.IsEnabled;
            qualityBtn.IsEnabled = !qualityBtn.IsEnabled;
        }

        public async Task AddVideoToPlaylist(object sender, EventArgs e)
        {
            //get user info
            //Get playlist information
            await _videoDetailPageViewModel.GetUserPlaylists(Constants.GETPLAYLIST, account.Properties["Id"]);
            userPlaylists = _videoDetailPageViewModel.Playlist;

            List<string> playlistNames = GetPlaylistNames(userPlaylists);
            string answer = await DisplayActionSheet("Add to Playlist", "Cancel", null, playlistNames.ToArray());
            if (answer == playlistNames[0])
            {
                await Navigation.PushModalAsync(new PlaylistCreatePage());
            }
#if __ANDROID__
            else if (answer != "Cancel" && answer != null)
#endif
#if __IOS__
            else if (answer != "Cancel")
#endif
            {
                await UpdatePlaylist(userPlaylists, answer);
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

        public async Task UpdatePlaylist(ObservableCollection<PlayList> playlists, string playlistName)
        {
            Video videoToBeAdded = new Video(videoTechnique.name, videoTechnique.pictures.sizes[3].link, videoTechnique.files[0].link, videoTechnique.files[1].link, videoTechnique.description);
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

        public async Task ChangeVideoQuality(object sender, EventArgs e)
        {
            string result;
#if __ANDROID__
            if (androidQualityBtn.Text == "SD")
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
                videoUrl = videoTechnique.files[0].link;
                androidQualityBtn.Text = "SD";
            }
            else if (result == "HD")
            {
                videoUrl = videoTechnique.files[1].link;
                androidQualityBtn.Text = "HD";
            }
#endif
#if __IOS__
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
                videoUrl = videoTechnique.files[0].link;
                qualityBtn.Text = "SD";
            }
            else if (result == "HD")
            {
                videoUrl = videoTechnique.files[1].link;
                qualityBtn.Text = "HD";
            }
#endif
        }

#if __IOS__
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
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                if (userHasAccount)
                {
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(videoFrame, 0, 0);
                    Grid.SetRowSpan(videoFrame, 2);
                    Grid.SetColumnSpan(videoFrame, 2);
                    innerGrid.Children.Add(videoNameLbl, 0, 0);
                    Grid.SetRowSpan(videoNameLbl, 2);
                    Grid.SetColumnSpan(videoNameLbl, 2);
                    innerGrid.Children.Add(backBtn, 2, 1);
                    innerGrid.Children.Add(playBtn, 3, 1);
                    innerGrid.Children.Add(addBtn, 4, 1);
                    innerGrid.Children.Add(qualityBtn, 5, 1);
                    innerGrid.Children.Add(videoDescriptionScrollView, 2, 0);
                    Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                }
                else
                {
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(videoFrame, 0, 0);
                    Grid.SetRowSpan(videoFrame, 2);
                    Grid.SetColumnSpan(videoFrame, 2);
                    innerGrid.Children.Add(videoNameLbl, 0, 0);
                    Grid.SetRowSpan(videoNameLbl, 2);
                    Grid.SetColumnSpan(videoNameLbl, 2);

                    innerGrid.Children.Add(backBtn, 2, 1);
                    innerGrid.Children.Add(playBtn, 3, 1);
                    innerGrid.Children.Add(qualityBtn, 4, 1);
                    Grid.SetColumnSpan(qualityBtn, 2);
                    innerGrid.Children.Add(videoDescriptionScrollView, 2, 0);
                    Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                }
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
                if (userHasAccount)
                {
                    //building grid
                    innerGrid.Children.Add(videoFrame, 0, 0);
                    Grid.SetColumnSpan(videoFrame, 4);
                    innerGrid.Children.Add(videoNameLbl, 0, 0);
                    Grid.SetColumnSpan(videoNameLbl, 4);
                    innerGrid.Children.Add(playBtn, 0, 1);
                    Grid.SetColumnSpan(playBtn, 2);
                    innerGrid.Children.Add(addBtn, 2, 1);
                    innerGrid.Children.Add(qualityBtn, 3, 1);
                    innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                    Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                    innerGrid.Children.Add(backBtn, 0, 3);
                    Grid.SetColumnSpan(backBtn, 4);
                }
                else
                {
                    //building grid
                    innerGrid.Children.Add(videoFrame, 0, 0);
                    Grid.SetColumnSpan(videoFrame, 4);
                    innerGrid.Children.Add(videoNameLbl, 0, 0);
                    Grid.SetColumnSpan(videoNameLbl, 4);
                    innerGrid.Children.Add(playBtn, 0, 1);
                    Grid.SetColumnSpan(playBtn, 2);
                    innerGrid.Children.Add(qualityBtn, 2, 1);
                    Grid.SetColumnSpan(qualityBtn, 2);
                    innerGrid.Children.Add(videoDescriptionScrollView, 0, 2);
                    Grid.SetColumnSpan(videoDescriptionScrollView, 4);
                    innerGrid.Children.Add(backBtn, 0, 3);
                    Grid.SetColumnSpan(backBtn, 4);
                }
            }
        }
#endif
    }
}

