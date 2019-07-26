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
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;

        private VideoData videoTechnique;
        private bool userHasAccount;

        public VideoDetailPage(VideoData video)
        {
            _baseViewModel = new BaseViewModel();
            _videoDetailPageViewModel = new VideoDetailPageViewModel();
            userPlaylists = new ObservableCollection<PlayList>();

            BackgroundColor = Theme.White;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            videoUrl = video.files[1].link_secure;

            Title = video.name;
            videoTechnique = video;
            DoesUserHaveAccount();

            SetContent();

            Content = flexLayout;
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
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            backBtn = new Button
            {
                ImageSource = "back.png",
                Style = Theme.RedButton
            };
            videoNameLbl = new Label
            {
                Text = videoTechnique.name,
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.WordWrap,
                HorizontalTextAlignment = TextAlignment.Center
            };

            videoDescription = new Label
            {
                Text = videoTechnique.description,
                TextColor = Theme.Black,
                FontFamily = Theme.Font,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                LineBreakMode = LineBreakMode.WordWrap,
            };

            videoDescriptionScrollView = new ScrollView
            {
                Padding = 0,
#if __ANDROID__
                IsClippedToBounds = true,
#endif
                Content = videoDescription,
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
                BorderColor = Theme.Black,
                BackgroundColor = Theme.Black,
                HasShadow = false,
                Padding = 3
            };
            playBtn = new Button
            {
                Style = Theme.BlueButton,
                ImageSource = "play.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            addBtn = new Button
            {
                Style = Theme.BlueButton,
                ImageSource = "plus.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            qualityBtn = new Button
            {
                Style = Theme.BlueButton,
                ImageSource = "gear.png",
                Text = "SD",
                HorizontalOptions = LayoutOptions.CenterAndExpand
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

            FlexLayout.SetAlignSelf(videoNameLbl, FlexAlignSelf.Center);

            FlexLayout.SetBasis(videoFrame, 3);
            FlexLayout.SetBasis(videoDescriptionScrollView, 3);

            FlexLayout.SetGrow(videoFrame, 3);
            FlexLayout.SetGrow(videoDescriptionScrollView, 3);

            if (userHasAccount)
            {
                buttonStackLayout.Children.Clear();
                buttonStackLayout.Children.Add(playBtn);
                buttonStackLayout.Children.Add(addBtn);
                buttonStackLayout.Children.Add(qualityBtn);

                flexLayout.Children.Clear();
                flexLayout.Children.Add(videoFrame);
                flexLayout.Children.Add(videoNameLbl);
                flexLayout.Children.Add(buttonStackLayout);
                flexLayout.Children.Add(videoDescriptionScrollView);
#if __IOS__
                flexLayout.Children.Add(backBtn);
#endif
            }
            else
            {
                buttonStackLayout.Children.Clear();
                buttonStackLayout.Children.Add(playBtn);
                buttonStackLayout.Children.Add(qualityBtn);

                flexLayout.Children.Clear();
                flexLayout.Children.Add(videoFrame);
                flexLayout.Children.Add(videoNameLbl);
                flexLayout.Children.Add(buttonStackLayout);
                flexLayout.Children.Add(videoDescriptionScrollView);
#if __IOS__
                flexLayout.Children.Add(backBtn);
#endif
            }
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
            await Navigation.PushModalAsync(new AndroidVideoPage(videoUrl));
#endif
        }

        public void ToggleButtons()
        {
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
            Video videoToBeAdded = new Video(videoTechnique.name, videoTechnique.pictures.sizes[3].link, videoTechnique.files[1].link, videoTechnique.files[0].link, videoTechnique.description);
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
            string[] videoQuality = { "SD", "HD" };
            string result = await DisplayActionSheet("Video Quality", "Cancel", null, videoQuality);
             
            if (result == "SD")
            {
                videoUrl = videoTechnique.files[1].link_secure;
                qualityBtn.Text = "SD";
            }
            else if (result == "HD")
            {
                videoUrl = videoTechnique.files[0].link_secure;
                qualityBtn.Text = "HD";
            }
        }
    }
}

