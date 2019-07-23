using System;
using System.Threading.Tasks;
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
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private StackLayout bottomButtonStackLayout;
        private Video videoTechnique;
        private PlayList userPlaylist;

        public PlaylistVideoPage(Video video, PlayList playlist)
        {
            _baseViewModel = new BaseViewModel();
            _playListVideoPageViewModel = new PlaylistVideoPageViewModel();
            BackgroundColor = Theme.White;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            videoUrl = video.Link;

            Title = video.Name;
            videoTechnique = video;
            userPlaylist = playlist;
            SetContent(video, playlist);

            Content = flexLayout;
        }

        //Functions
        public void SetContent(Video video, PlayList playlist)
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            //view objects
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            bottomButtonStackLayout = new StackLayout();
            bottomButtonStackLayout.Orientation = StackOrientation.Horizontal;
           
            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            deleteBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "trash.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            videoNameLbl = new Label
            {
                Text = video.Name,
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            videoDescription = new Label
            {
                Text = video.Description,
                TextColor = Theme.Black,
                FontFamily = Theme.Font,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                LineBreakMode = LineBreakMode.WordWrap,
            };

            videoDescriptionScrollView = new ScrollView
            {
                Padding = 0,
                Orientation = ScrollOrientation.Vertical,
#if __ANDROID__
                IsClippedToBounds = true,
#endif
                Content = videoDescription,
            };

            videoImage = new Image
            {
                Source = video.Image,
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
            deleteBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await DeleteFromPlaylist(sender, e);
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

            buttonStackLayout.Children.Add(playBtn);
            buttonStackLayout.Children.Add(qualityBtn);

#if __IOS__
            bottomButtonStackLayout.Children.Add(backBtn);
#endif
            bottomButtonStackLayout.Children.Add(deleteBtn);

            flexLayout.Children.Add(videoFrame);
            flexLayout.Children.Add(videoNameLbl);
            flexLayout.Children.Add(buttonStackLayout);
            flexLayout.Children.Add(videoDescriptionScrollView);
            flexLayout.Children.Add(bottomButtonStackLayout);

        }

        public void PlayIOSVideo(object sender, EventArgs e)
        {
            ToggleButtons();
            MessagingCenter.Send(this, "ShowVideoPlayer", new ShowVideoPlayerArguments(videoUrl));
            ToggleButtons();
        }

#if __ANDROID__
        public async Task PlayAndroidVideo(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new AndroidVideoPage(videoUrl));
        }
#endif

        public async Task DeleteFromPlaylist(object sender, EventArgs e)
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
                }
                else
                {
                    await DisplayAlert("Video Not Deleted From Playlist", videoTechnique.Name + " has not been deleted from " + userPlaylist.Name + ". Try again!", "Ok");
                }
            }
            else
            {
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

        public async Task ChangeVideoQuality(object sender, EventArgs e)
        {
            string[] videoQuality = { "SD", "HD" };
            string result = await DisplayActionSheet("Video Quality", "Cancel", null, videoQuality);

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
        }
    }
}
