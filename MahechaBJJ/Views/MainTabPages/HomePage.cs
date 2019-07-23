using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using MahechaBJJ.Views.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class HomePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private HomePageViewModel _homePageViewModel;
        //private String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        private string vimeoUrl;
        private BaseInfo VimeoInfo;
        private FlexLayout flexLayout;
        private FlexLayout videoContainterLayout;
        private StackLayout buttonStackLayout;
        private Grid video1Grid;
        private Grid video2Grid;
        private Frame video1Frame;
        private Frame video2Frame;
        private Image video1Image;
        private Image video2Image;
        private Label video1Lbl;
        private Label video2Lbl;
        private TapGestureRecognizer video1Tap;
        private TapGestureRecognizer video2Tap;
        private Label whatsNewLbl;
        private Label playListLbl;
        private Button addPlaylistBtn;
        private Button viewPlaylistBtn;
        private Label timeOutLbl;
        private Frame timeOutFrame;
        private TapGestureRecognizer timeOutTap;
        private ActivityIndicator activityIndicator;
        private Account _account;
        private bool account;
        private double width;
        private double height;

        public HomePage()
        {
            _baseViewModel = new BaseViewModel();
            _homePageViewModel = new HomePageViewModel();
            _account = _baseViewModel.GetAccountInformation();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;
            this.account = true;

            Padding = Theme.Thickness;
            IconImageSource = "construction.png";

            width = this.Width;
            height = this.Height;

            SetVimeoUrl();
            BuildPageObjects();
             SetContent(this.account);
            UpdateLayout();

            Content = flexLayout;
        }

        public HomePage(bool hasAccount)
        {
            _baseViewModel = new BaseViewModel();
            _homePageViewModel = new HomePageViewModel();
            _account = _baseViewModel.GetAccountInformation();
            BackgroundColor = Color.FromHex("#F1ECCE");
            Visual = VisualMarker.Material;
            this.account = hasAccount;

            Padding = Theme.Thickness;
            IconImageSource = "construction.png";

            width = this.Width;
            height = this.Height;

            SetVimeoUrl();
            BuildPageObjects();
            SetContent(hasAccount);
            UpdateLayout();

            Content = flexLayout;
        }

        //functions
        private void SetVimeoUrl()
        {
            if (_account.Properties["Package"].Equals("Gi"))
            {
                vimeoUrl = Constants.VIMEOGIALBUM;
            }
            else if (_account.Properties["Package"].Equals("NoGi"))
            {
                vimeoUrl = Constants.VIMEONOGIALBUM;
            }
            else
            {
                vimeoUrl = Constants.VIMEOGIANDNOGIALBUM;
            }
        }

        private void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            videoContainterLayout = new FlexLayout();
            videoContainterLayout.Direction = FlexDirection.Column;
            videoContainterLayout.JustifyContent = FlexJustify.SpaceEvenly;

            video1Grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            video2Grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            whatsNewLbl = new Label
            {
                Text = "What's New",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.NoWrap
            };
            video1Image = new Image
            {
                Aspect = Aspect.AspectFill
            };
            video1Frame = new Frame
            {
                Content = video1Image,
                BorderColor = Theme.Black,
                BackgroundColor = Theme.Black,
                HasShadow = false,
                Padding = 3,
                Margin = new Thickness(0, 0, 0, 10)

            };
            video1Lbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "Spider Guard Stuff!",
                TextColor = Theme.Azure,
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            video1Tap = new TapGestureRecognizer();
            video1Tap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                VideoData video = VimeoInfo.data[0];
                await Navigation.PushModalAsync(new VideoDetailPage(video));
                ToggleButtons();
            };
            video1Image.GestureRecognizers.Add(video1Tap);
            video1Lbl.GestureRecognizers.Add(video1Tap);

            video2Image = new Image
            {
                Aspect = Aspect.AspectFill
            };
            video2Frame = new Frame
            {
                Content = video2Image,
                BorderColor = Theme.Black,
                BackgroundColor = Theme.Black,
                HasShadow = false,
                Padding = 3,
                Margin = new Thickness(0, 0, 0, 10)
            };
            video2Lbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "Spider Guard Stuff!",
                TextColor = Theme.Azure,
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            video2Tap = new TapGestureRecognizer();
            video2Tap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                VideoData video = VimeoInfo.data[1];
                await Navigation.PushModalAsync(new VideoDetailPage(video));
                ToggleButtons();
            };
            video2Image.GestureRecognizers.Add(video2Tap);
            video2Lbl.GestureRecognizers.Add(video2Tap);

            playListLbl = new Label
            {
                Text = "Playlists",
                FontFamily = Theme.Font,
                LineBreakMode = LineBreakMode.NoWrap,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            addPlaylistBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Create",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            viewPlaylistBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "View",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            timeOutLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "Network Has Timed Out! \n Click To Try Again!",
                LineBreakMode = LineBreakMode.WordWrap,
                TextColor = Theme.White
            };
            timeOutFrame = new Frame
            {
                Content = timeOutLbl,
                BorderColor = Theme.Black,
                BackgroundColor = Theme.Black,
                HasShadow = false,
                Padding = 3
            };
            timeOutTap = new TapGestureRecognizer();
            timeOutTap.Tapped += (sender, e) =>
            {
                ToggleButtons();
                SetContent(this.account);
                ToggleButtons();
            };
            timeOutLbl.GestureRecognizers.Add(timeOutTap);
            activityIndicator = new ActivityIndicator
            {
                Style = (Style)Application.Current.Resources["common-activity-indicator"]
            };

            //events
            addPlaylistBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new PlaylistCreatePage());
                ToggleButtons();
            };
            viewPlaylistBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new PlaylistViewPage());
                ToggleButtons();
            };
        }

        private async void SetContent(bool userAccount)
        {
            //add activity indicator while contents load
            activityIndicator.IsRunning = true;

            flexLayout.Children.Clear();
            flexLayout.Children.Add(activityIndicator);

            if (_homePageViewModel.VimeoInfo == null)
            {
                await _homePageViewModel.GetVimeo(vimeoUrl);
            }
            if (_homePageViewModel.Successful)
            {
                activityIndicator.IsRunning = false;
                VimeoInfo = _homePageViewModel.VimeoInfo;

                video1Image.Source = VimeoInfo.data[0].pictures.sizes[4].link;
                video2Image.Source = VimeoInfo.data[1].pictures.sizes[4].link;
                video1Lbl.Text = VimeoInfo.data[0].name;
                video2Lbl.Text = VimeoInfo.data[1].name;

                FlexLayout.SetAlignSelf(whatsNewLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(playListLbl, FlexAlignSelf.Center);

                FlexLayout.SetBasis(videoContainterLayout, 6);
                FlexLayout.SetBasis(video1Grid, 1);
                FlexLayout.SetBasis(video2Grid, 1);
                FlexLayout.SetBasis(timeOutFrame, 1);

                FlexLayout.SetGrow(videoContainterLayout, 6);
                FlexLayout.SetGrow(video1Grid, 1);
                FlexLayout.SetGrow(video2Grid, 1);
                FlexLayout.SetGrow(timeOutFrame, 1);

                FlexLayout.SetShrink(videoContainterLayout, 3);

                video1Grid.Children.Add(video1Frame, 0, 0);
                video1Grid.Children.Add(video1Lbl, 0, 0);

                video2Grid.Children.Add(video2Frame, 0, 0);
                video2Grid.Children.Add(video2Lbl, 0, 0);

                videoContainterLayout.Children.Add(video1Grid);
                videoContainterLayout.Children.Add(video2Grid);

                buttonStackLayout.Children.Add(viewPlaylistBtn);
                buttonStackLayout.Children.Add(addPlaylistBtn);

                if (userAccount)
                {
                    flexLayout.Children.Clear();
                    flexLayout.Children.Add(whatsNewLbl);
                    flexLayout.Children.Add(videoContainterLayout);
                    flexLayout.Children.Add(playListLbl);
                    flexLayout.Children.Add(buttonStackLayout);
                }
                else
                {
                    flexLayout.Children.Clear();
                    flexLayout.Children.Add(whatsNewLbl);
                    flexLayout.Children.Add(videoContainterLayout);
                }
            }
            else
            {
#if __IOS__
                flexLayout.Children.Clear();
                flexLayout.Children.Add(timeOutFrame);
#endif
#if __ANDROID__
                SetContent(this.account);
#endif
            }
        }

        private void ToggleButtons()
        {
            addPlaylistBtn.IsEnabled = !addPlaylistBtn.IsEnabled;
            viewPlaylistBtn.IsEnabled = !viewPlaylistBtn.IsEnabled;
            video1Lbl.IsEnabled = !video1Lbl.IsEnabled;
            video2Lbl.IsEnabled = !video2Lbl.IsEnabled;
            timeOutLbl.IsEnabled = !timeOutLbl.IsEnabled;
        }

        private void PortraitLayout()
        {
            FlexLayout.SetBasis(videoContainterLayout, 6);
            FlexLayout.SetGrow(videoContainterLayout, 6);
        }

        private void LandscapeLayout()
        {
            FlexLayout.SetBasis(videoContainterLayout, 4);
            FlexLayout.SetGrow(videoContainterLayout, 4);
        }

        private void UpdateLayout()
        {
            if (this.Width > this.Height)
                LandscapeLayout();
            else
                PortraitLayout();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                UpdateLayout();
            }
        }
    }
}

