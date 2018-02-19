using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Droid;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using MahechaBJJ.Views.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MahechaBJJ.Views
{
    public class HomePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private HomePageViewModel _homePageViewModel;
        //private String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        private string vimeoUrl;
        private BaseInfo VimeoInfo;
        private Grid outerGrid;
        private Grid innerGrid;
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
#if __ANDROID__
        private Android.Widget.TextView androidVideo1Lbl;
        private Android.Widget.TextView androidVideo2Lbl;
        private Android.Widget.TextView androidWhatsNewLbl;
        private Android.Widget.TextView androidPlayListLbl;
        private Android.Widget.Button androidAddPlaylistBtn;
        private Android.Widget.Button androidViewPlaylistBtn;
        private ContentView contenViewWhatsNewLbl;
        private ContentView contentViewPlayListLbl;
        private ContentView contentViewVideo1Lbl;
        private ContentView contentViewVideo2Lbl;
#endif

        public HomePage()
        {
            _baseViewModel = new BaseViewModel();
            _homePageViewModel = new HomePageViewModel();
            _account = _baseViewModel.GetAccountInformation();
            this.account = true;
#if __IOS__
            Icon = "construction.png";
            Title = "Home";
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __ANDROID__
            Icon = "construction.png";
            Padding = new Thickness(5, -5, 5, 5);
#endif
            SetVimeoUrl();
            BuildPageObjects();
            SetContent(this.account);
        }

        public HomePage(bool hasAccount)
        {
            _baseViewModel = new BaseViewModel();
            _homePageViewModel = new HomePageViewModel();
            _account = _baseViewModel.GetAccountInformation();
            this.account = hasAccount;
#if __IOS__
            Icon = "construction.png";
            Title = "Home";
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __ANDROID__
            Icon = "construction.png";
            Padding = new Thickness(5, -5, 5, 5);
#endif
            SetVimeoUrl();
            BuildPageObjects();
            SetContent(hasAccount);
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


            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

#if __ANDROID__
            androidVideo1Lbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidVideo1Lbl.Text = "Spider Guard Stuff!";
            androidVideo1Lbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidVideo1Lbl.SetTextColor(Android.Graphics.Color.AntiqueWhite);
            androidVideo1Lbl.Gravity = Android.Views.GravityFlags.Center;
            androidVideo1Lbl.Click += (object sender, EventArgs e) =>
            {
                VideoData video = VimeoInfo.data[0];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
            androidVideo1Lbl.SetTypeface(androidVideo1Lbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            contentViewVideo1Lbl = new ContentView();
            contentViewVideo1Lbl.Content = androidVideo1Lbl.ToView();

            androidVideo2Lbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidVideo2Lbl.Text = "Spider Guard Stuff!";
            androidVideo2Lbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidVideo2Lbl.SetTextColor(Android.Graphics.Color.AntiqueWhite);
            androidVideo2Lbl.Gravity = Android.Views.GravityFlags.Center;
            androidVideo2Lbl.Click += (object sender, EventArgs e) =>
            {
                VideoData video = VimeoInfo.data[1];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
            androidVideo2Lbl.SetTypeface(androidVideo2Lbl.Typeface, Android.Graphics.TypefaceStyle.Bold);


            contentViewVideo2Lbl = new ContentView();
            contentViewVideo2Lbl.Content = androidVideo2Lbl.ToView();

            androidWhatsNewLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidWhatsNewLbl.Text = "What's New";
            androidWhatsNewLbl.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidWhatsNewLbl.SetTextColor(Android.Graphics.Color.Black);
            androidWhatsNewLbl.Gravity = Android.Views.GravityFlags.Center;

            contenViewWhatsNewLbl = new ContentView();
            contenViewWhatsNewLbl.Content = androidWhatsNewLbl.ToView();

            androidPlayListLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidPlayListLbl.Text = "Playlists";
            androidPlayListLbl.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidPlayListLbl.SetTextColor(Android.Graphics.Color.Black);
            androidPlayListLbl.Gravity = Android.Views.GravityFlags.Center;

            contentViewPlayListLbl = new ContentView();
            contentViewPlayListLbl.Content = androidPlayListLbl.ToView();

            androidAddPlaylistBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidAddPlaylistBtn.Text = "Create";
            androidAddPlaylistBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidAddPlaylistBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidAddPlaylistBtn.SetTextColor(Android.Graphics.Color.Black);
            androidAddPlaylistBtn.Gravity = Android.Views.GravityFlags.Center;
            androidAddPlaylistBtn.SetAllCaps(false);
            androidAddPlaylistBtn.Click += CreatePlaylist;

            androidViewPlaylistBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidViewPlaylistBtn.Text = "View";
            androidViewPlaylistBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidViewPlaylistBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidViewPlaylistBtn.SetTextColor(Android.Graphics.Color.Black);
            androidViewPlaylistBtn.Gravity = Android.Views.GravityFlags.Center;
            androidViewPlaylistBtn.SetAllCaps(false);
            androidViewPlaylistBtn.Click += ViewPlaylists;
#endif
            whatsNewLbl = new Label
            {
                Text = "What's New",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.Center
            };
            video1Image = new Image
            {
                Aspect = Aspect.AspectFill
            };
            video1Frame = new Frame
            {
                Content = video1Image,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3

            };
            video1Lbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Text = "Spider Guard Stuff!",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White
            };
            video1Tap = new TapGestureRecognizer();
            video1Tap.Tapped += (sender, e) =>
            {
                VideoData video = VimeoInfo.data[0];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
            video1Lbl.GestureRecognizers.Add(video1Tap);
            video2Image = new Image
            {
                Aspect = Aspect.AspectFill
            };
            video2Frame = new Frame
            {
                Content = video2Image,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3
            };
            video2Lbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Text = "Spider Guard Stuff!",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White
            };
            video2Tap = new TapGestureRecognizer();
            video2Tap.Tapped += (sender, e) =>
            {
                VideoData video = VimeoInfo.data[1];
                Navigation.PushModalAsync(new VideoDetailPage(video));
            };
            video2Lbl.GestureRecognizers.Add(video2Tap);

            playListLbl = new Label
            {
                Text = "Playlists",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            addPlaylistBtn = new Button
            {
                Text = "Create",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize * .75,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };
            viewPlaylistBtn = new Button
            {
                Text = "View",
                BorderWidth = 3,
                BorderColor = Color.Black,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize * .75,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black
            };

            timeOutLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Network Has Timed Out! \n Click To Try Again!",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.White
            };
            timeOutFrame = new Frame
            {
                Content = timeOutLbl,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            timeOutTap = new TapGestureRecognizer();
            timeOutTap.Tapped += (sender, e) =>
            {
                SetContent(this.account);
            };
            timeOutLbl.GestureRecognizers.Add(timeOutTap);
            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                IsEnabled = true,
                IsVisible = true
            };

            //events
            addPlaylistBtn.Clicked += CreatePlaylist;
            viewPlaylistBtn.Clicked += ViewPlaylists;

            outerGrid.Children.Add(innerGrid, 0, 0);
            Content = outerGrid;
        }

        private async void SetContent(bool userAccount)
        {
            //add activity indicator while contents load
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 5);
            Grid.SetColumnSpan(activityIndicator, 2);
            if (_homePageViewModel.VimeoInfo == null)
            {
                await _homePageViewModel.GetVimeo(vimeoUrl);
            }
            if (_homePageViewModel.Successful)
            {
                activityIndicator.IsRunning = false;
                VimeoInfo = _homePageViewModel.VimeoInfo;
#if __ANDROID__
                androidVideo1Lbl.Text = VimeoInfo.data[0].name;
                androidVideo2Lbl.Text = VimeoInfo.data[1].name;
#endif
                video1Image.Source = VimeoInfo.data[0].pictures.sizes[4].link;
                video2Image.Source = VimeoInfo.data[1].pictures.sizes[4].link;
                video1Lbl.Text = VimeoInfo.data[0].name;
                video2Lbl.Text = VimeoInfo.data[1].name;

                if (userAccount)
                {
                    innerGrid.Children.Clear();
#if __ANDROID__
                    innerGrid.Children.Add(contenViewWhatsNewLbl, 0, 0);
                    Grid.SetColumnSpan(contenViewWhatsNewLbl, 2);
                    innerGrid.Children.Add(video1Frame, 0, 1);
                    Grid.SetColumnSpan(video1Frame, 2);
                    innerGrid.Children.Add(contentViewVideo1Lbl, 0, 1);
                    Grid.SetColumnSpan(contentViewVideo1Lbl, 2);
                    innerGrid.Children.Add(video2Frame, 0, 2);
                    Grid.SetColumnSpan(video2Frame, 2);
                    Grid.SetRowSpan(video2Frame, 2);
                    innerGrid.Children.Add(contentViewVideo2Lbl, 0, 2);
                    Grid.SetColumnSpan(contentViewVideo2Lbl, 2);
                    Grid.SetRowSpan(contentViewVideo2Lbl, 2);
                    innerGrid.Children.Add(contentViewPlayListLbl, 0, 4);
                    Grid.SetColumnSpan(contentViewPlayListLbl, 2);
                    innerGrid.Children.Add(androidViewPlaylistBtn.ToView(), 0, 5);
                    innerGrid.Children.Add(androidAddPlaylistBtn.ToView(), 1, 5);
#endif
#if __IOS__
                    innerGrid.Children.Add(whatsNewLbl, 0, 0);
                    Grid.SetColumnSpan(whatsNewLbl, 2);
                    innerGrid.Children.Add(video1Frame, 0, 1);
                    Grid.SetColumnSpan(video1Frame, 2);
                    innerGrid.Children.Add(video1Lbl, 0, 1);
                    Grid.SetColumnSpan(video1Lbl, 2);
                    innerGrid.Children.Add(video2Frame, 0, 2);
                    Grid.SetColumnSpan(video2Frame, 2);
                    Grid.SetRowSpan(video2Frame, 2);
                    innerGrid.Children.Add(video2Lbl, 0, 2);
                    Grid.SetColumnSpan(video2Lbl, 2);
                    Grid.SetRowSpan(video2Lbl, 2);
                    innerGrid.Children.Add(playListLbl, 0, 4);
                    Grid.SetColumnSpan(playListLbl, 2);
                    innerGrid.Children.Add(viewPlaylistBtn, 0, 5);
                    innerGrid.Children.Add(addPlaylistBtn, 1, 5);
#endif
                }
                else
                {
#if __IOS__
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(whatsNewLbl, 0, 0);
                    Grid.SetColumnSpan(whatsNewLbl, 2);
                    innerGrid.Children.Add(video1Frame, 0, 1);
                    Grid.SetColumnSpan(video1Frame, 2);
                    Grid.SetRowSpan(video1Frame, 2);
                    innerGrid.Children.Add(video1Lbl, 0, 1);
                    Grid.SetColumnSpan(video1Lbl, 2);
                    Grid.SetRowSpan(video1Lbl, 2);
                    innerGrid.Children.Add(video2Frame, 0, 3);
                    Grid.SetColumnSpan(video2Frame, 2);
                    Grid.SetRowSpan(video2Frame, 3);
                    innerGrid.Children.Add(video2Lbl, 0, 3);
                    Grid.SetColumnSpan(video2Lbl, 2);
                    Grid.SetRowSpan(video2Lbl, 3);
#endif
                }
            }
            else
            {
                innerGrid.Children.Clear();
                innerGrid.Children.Add(timeOutFrame, 0, 0);
                Grid.SetRowSpan(timeOutFrame, 5);
                Grid.SetRowSpan(timeOutLbl, 5);
                Grid.SetColumnSpan(timeOutFrame, 2);
                Grid.SetColumnSpan(timeOutLbl, 2);
            }

        }

        private void CreatePlaylist(object sender, EventArgs e)
        {
            addPlaylistBtn.IsEnabled = false;
            Navigation.PushModalAsync(new PlaylistCreatePage());
            addPlaylistBtn.IsEnabled = true;
        }
        private void ViewPlaylists(object sender, EventArgs e)
        {
            viewPlaylistBtn.IsEnabled = false;
            Navigation.PushModalAsync(new PlaylistViewPage());
            viewPlaylistBtn.IsEnabled = true;
        }
    }
}

