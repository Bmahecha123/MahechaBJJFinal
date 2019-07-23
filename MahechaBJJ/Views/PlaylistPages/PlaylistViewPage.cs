using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;

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
        private FlexLayout flexLayout;
        private Label playlistLbl;
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
        private double lblSize;

        public PlaylistViewPage()
        {
            _playlistViewPageViewModel = new PlaylistViewPageViewModel();
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            Title = "User Playlists";
            Padding = Theme.Thickness;
            lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            BuildPageObjects();
            //FindPlaylists();
            SetContent();

            Content = flexLayout;
        }

        //Functions
        public void BuildPageObjects()
        {
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

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            viewPlaylistLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "Playlists",
                TextColor = Theme.Black
            };

            playlistView = new ListView
            {
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                BackgroundColor = Theme.White
            };

            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png"
            };

            timeOutLbl = new Label
            {
                FontFamily = Theme.Font,
                Text = "Network Has Timed Out! \n Click To Try Again!",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                TextColor = Theme.Azure
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
                SetContent();
            };
            timeOutLbl.GestureRecognizers.Add(timeOutTap);

            activityIndicator = new ActivityIndicator
            {
                Color = Theme.Blue,
                IsRunning = false,
                IsVisible = false,
                IsEnabled = false
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
        }

        private void SetContent()
        {
            flexLayout.Children.Clear();
            activityIndicator.IsRunning = true;
            flexLayout.Children.Add(activityIndicator);

            if (_playlistViewPageViewModel.Playlist == null)
            {
                FindPlaylists();
            }

            FlexLayout.SetAlignSelf(viewPlaylistLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(backBtn, FlexAlignSelf.Center);

            FlexLayout.SetBasis(playlistView, 1);
            FlexLayout.SetBasis(timeOutFrame, 1);

            FlexLayout.SetGrow(playlistView, 1);
            FlexLayout.SetGrow(timeOutFrame, 1);

            if (_playlistViewPageViewModel.Successful)
            {
                flexLayout.Children.Clear();
                flexLayout.Children.Add(viewPlaylistLbl);
                flexLayout.Children.Add(playlistView);
#if __IOS__
                flexLayout.Children.Add(backBtn);
#endif

            }
            else
            {
                flexLayout.Children.Clear();
                flexLayout.Children.Add(timeOutFrame);
#if __IOS__
                flexLayout.Children.Add(backBtn);
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
                playlistLbl.FontFamily = Theme.Font;
                playlistLbl.FontSize = lblSize;
                playlistLbl.BackgroundColor = Theme.Blue;
                playlistLbl.TextColor = Theme.Azure;
                playlistLbl.LineBreakMode = LineBreakMode.WordWrap;
                playlistLbl.Margin = new Thickness(0, 5, 0, 5);
                playlistLbl.HorizontalTextAlignment = TextAlignment.Center;
                playlistLbl.VerticalTextAlignment = TextAlignment.Center;

                layout = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,

                    Children = {
                            playlistLbl
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
    }
}

