using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using MahechaBJJ.Droid;
#endif

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistViewPage : ContentPage
    {
        private PlaylistViewPageViewModel _playlistViewPageViewModel;
        private BaseViewModel _baseViewModel;
        private Label viewPlaylistLbl;
        private ListView playlistView;
        private Grid innerGrid;
        private Grid outerGrid;
        private Label playlistLbl;
        private Frame playlistFrame;
        private Button backBtn;
        private StackLayout layout;
        private Account account;
        private string id;
        private Label timeOutLbl;
        private Frame timeOutFrame;
        private TapGestureRecognizer timeOutTap;
        private ActivityIndicator activityIndicator;
        private ObservableCollection<PlayList> userPlaylist;
        private bool isPressed;

#if __ANDROID__
        private Android.Widget.TextView androidViewPlaylistLbl;

        private ContentView contentViewAndroidViewPlaylistLbl;
#endif

        public PlaylistViewPage()
        {
            _playlistViewPageViewModel = new PlaylistViewPageViewModel();
            _baseViewModel = new BaseViewModel();
            Title = "User Playlists";
#if __IOS__
                    Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
            BuildPageObjects();
            //FindPlaylists();
            SetContent();
        }

        //Functions
        public void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //View Objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(7, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

#if __ANDROID__
            androidViewPlaylistLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidViewPlaylistLbl.Text = "View Playlists";
            androidViewPlaylistLbl.Typeface = Constants.COMMONFONT;
            androidViewPlaylistLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidViewPlaylistLbl.SetTextColor(Android.Graphics.Color.Black);
            androidViewPlaylistLbl.Gravity = Android.Views.GravityFlags.Center;

            contentViewAndroidViewPlaylistLbl = new ContentView();
            contentViewAndroidViewPlaylistLbl.Content = androidViewPlaylistLbl.ToView();
#endif

            viewPlaylistLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "View Playlists",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            playlistView = new ListView
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
                BackgroundColor = Color.FromRgb(124, 37, 41),
                BorderWidth = 3,
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
                SetContent();
            };
            timeOutLbl.GestureRecognizers.Add(timeOutTap);
            activityIndicator = new ActivityIndicator
            {
                Style = (Style)Application.Current.Resources["common-activity-indicator"]
            };

            //Events
            backBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PopModalAsync();    
                ToggleButtons();
            };

            playlistView.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => {
                if (isPressed)
                {
                    return;
                }
                else
                {
                    isPressed = true;
                    ToggleButtons();
                    await LoadPlaylist(sender, e);
                }
                isPressed = false;
                ToggleButtons();
            };

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private void SetContent()
        {
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 3);

            if (_playlistViewPageViewModel.Playlist == null)
            {
                FindPlaylists();
            }
            if (_playlistViewPageViewModel.Successful)
            {

                //building grid
                innerGrid.Children.Clear();

#if __ANDROID__
                innerGrid.Children.Add(contentViewAndroidViewPlaylistLbl, 0, 0);
                innerGrid.Children.Add(playlistView, 0, 1);
                Grid.SetRowSpan(playlistView, 2);
#endif
#if __IOS__
                innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
                innerGrid.Children.Add(playlistView, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
#endif

            }
            else
            {
                innerGrid.Children.Clear();
#if __ANDROID__
                innerGrid.Children.Add(timeOutFrame, 0, 0);
                Grid.SetRowSpan(timeOutFrame, 3);
#endif
#if __IOS__
                innerGrid.Children.Add(timeOutFrame, 0, 0);
                Grid.SetRowSpan(timeOutFrame, 2);
                innerGrid.Children.Add(backBtn, 0, 2);
#endif

            }
        }

        public async void FindPlaylists()
        {
            account = _baseViewModel.GetAccountInformation();
            id = account.Properties["Id"];
            await _playlistViewPageViewModel.GetUserPlaylists(Constants.GETPLAYLIST, id);
            userPlaylist = _playlistViewPageViewModel.Playlist;
            SetListView();
        }

        public void SetListView()
        {
            playlistView.ItemsSource = userPlaylist;
            playlistView.ItemTemplate = new DataTemplate(() =>
            {
                playlistLbl = new Label();
                playlistLbl.SetBinding(Label.TextProperty, "Name");
                playlistLbl.VerticalTextAlignment = TextAlignment.Center;
                playlistLbl.HorizontalTextAlignment = TextAlignment.Center;
                playlistLbl.LineBreakMode = LineBreakMode.WordWrap;
#if __IOS__
                playlistLbl.TextColor = Color.Black;
                playlistLbl.FontFamily = "AmericanTypewriter-Bold";
                playlistLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2;
#endif
#if __ANDROID__
                playlistLbl.FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt";
                playlistLbl.TextColor = Color.Black;
                playlistLbl.FontAttributes = FontAttributes.Bold;
                playlistLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2;
#endif

                playlistFrame = new Frame();
                playlistFrame.BackgroundColor = Color.FromRgb(58, 93, 174);
                playlistFrame.HasShadow = false;
                playlistFrame.OutlineColor = Color.Black;
                playlistFrame.Content = playlistLbl;
                playlistFrame.Padding = new Thickness(10, 10, 10, 10);

                layout = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Spacing = 0,
                    Padding = new Thickness(0, 5, 0, 5),
                    Children = {
                            playlistFrame
                        }
                };

                ViewCell viewCell = new ViewCell();
                viewCell.View = layout;

                return viewCell;
            });
        }

        public async Task LoadPlaylist(object sender, SelectedItemChangedEventArgs e)
        {
            PlayList playlist = (PlayList)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushModalAsync(new PlaylistDetailPage(playlist));
        }

        private void ToggleButtons()
        {
            playlistView.IsEnabled = !playlistView.IsEnabled;
            timeOutLbl.IsEnabled = !timeOutLbl.IsEnabled;
        }

        //page reloading
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            PlaylistViewPageViewModel vm = new PlaylistViewPageViewModel();
            await vm.GetUserPlaylists(Constants.GETPLAYLIST, id);
            playlistView.ItemsSource = vm.Playlist;
        }

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                if (_playlistViewPageViewModel.Playlist != null)
                {
#if __IOS__
                    Padding = new Thickness(10, 10, 10, 10);
#endif
#if __ANDROID__
                    Padding = new Thickness(5, 5, 5, 5);
#endif
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                    innerGrid.Children.Clear();

#if __ANDROID__
                    innerGrid.Children.Add(contentViewAndroidViewPlaylistLbl, 0, 0);
                    innerGrid.Children.Add(playlistView, 1, 0);
                    Grid.SetRowSpan(playlistView, 3);  
#endif
#if __IOS__
                    innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
            innerGrid.Children.Add(backBtn, 0, 2);
                    innerGrid.Children.Add(playlistView, 1, 0);
                    Grid.SetRowSpan(playlistView, 3);
#endif        
                    
                }
            }
            else
            {
                if (_playlistViewPageViewModel.Playlist != null)
                {
#if __IOS__
                    Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
                    Padding = new Thickness(5, 5, 5, 5);
#endif
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.Children.Clear();
#if __IOS__
                    innerGrid.Children.Add(viewPlaylistLbl, 0, 0);
                    innerGrid.Children.Add(playlistView, 0, 1);
                    innerGrid.Children.Add(backBtn, 0, 2);
#endif
#if __ANDROID__
                    innerGrid.Children.Add(contentViewAndroidViewPlaylistLbl, 0, 0);
                    innerGrid.Children.Add(playlistView, 0, 1);
                    Grid.SetRowSpan(playlistView, 2);
#endif

                }
			}
		}
    }
}

