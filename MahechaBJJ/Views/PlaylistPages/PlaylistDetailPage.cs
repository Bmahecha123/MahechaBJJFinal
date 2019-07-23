using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistDetailPage : ContentPage
    {
        private static BaseViewModel _baseViewModel;
        private static PlaylistDetailPageViewModel _playListDetailPageViewModel;
        private Account account;
        private string id;
        private Label playlistNameLbl;
        private Label playlistDescriptionLbl;
        private ListView videosListView;
        private Button backBtn;
        private Grid videoGrid;

        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;

        private Frame videoFrame;
        private Image videoImage;
        private Label videoLbl;
        private Button deleteBtn;
        private PlayList userPlaylist;
        private ObservableCollection<Video> videos;
        private bool isPressed;

        public PlaylistDetailPage(PlayList playlist)
        {
            _baseViewModel = new BaseViewModel();
            _playListDetailPageViewModel = new PlaylistDetailPageViewModel();
            BackgroundColor = Theme.White;

            Title = playlist.Name;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            userPlaylist = playlist;
            FindPlaylist();
            SetContent();

            Content = flexLayout;
        }

        //Functions
        public void SetContent()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //View Objects
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            playlistNameLbl = new Label
            {
                FontSize = lblSize,
                FontFamily = Theme.Font,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.WordWrap,
                Text = userPlaylist.Name
            };

            playlistDescriptionLbl = new Label
            {
                FontFamily = Theme.Font,
                LineBreakMode = LineBreakMode.WordWrap,
                Text = userPlaylist.Description,
                TextColor = Theme.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            videosListView = new ListView
            {
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                BackgroundColor = Theme.White
            };

            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            deleteBtn = new Button
            {
                ImageSource = "trash.png",
                Style = Theme.RedButton,
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
                await DeletePlaylist(sender, e);
                ToggleButtons();
            };
            videosListView.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (isPressed)
                {
                    return;
                }
                else
                {
                    isPressed = true;
                    ToggleButtons();
                    await LoadVideo(sender, e);
                }
                isPressed = false;
                ToggleButtons();
            };

            FlexLayout.SetAlignSelf(playlistNameLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(playlistDescriptionLbl, FlexAlignSelf.Center);

            FlexLayout.SetBasis(videosListView, 1);

            FlexLayout.SetGrow(videosListView, 1);
#if __IOS__
            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(deleteBtn);

            flexLayout.Children.Add(playlistNameLbl);
            flexLayout.Children.Add(playlistDescriptionLbl);
            flexLayout.Children.Add(videosListView);
            flexLayout.Children.Add(buttonStackLayout);
        }

        public async Task DeletePlaylist(object sender, EventArgs e)
        {
            bool delete = await DisplayAlert("Delete Playlist", "Are you sure you want to delete " + userPlaylist.Name + "?", "Yes", "No");
            if (delete)
            {
                await _playListDetailPageViewModel.DeleteUserPlaylist(Constants.DELETEPLAYLIST, id, userPlaylist);
                if (_playListDetailPageViewModel.Successful)
                {
                    await Navigation.PopModalAsync();
                }
                else
                {
                    await DisplayAlert("Unable To Delete", userPlaylist.Name + " has not been deleted. Try again.", "Ok");
                }
            }
            else
            {
                return;
            }
        }

        public void ToggleButtons()
        {
            videosListView.IsEnabled = !videosListView.IsEnabled;
            backBtn.IsEnabled = !backBtn.IsEnabled;
            deleteBtn.IsEnabled = !deleteBtn.IsEnabled;
        }

        public async Task LoadVideo(object sender, SelectedItemChangedEventArgs e)
        {
            Video video = (Video)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushModalAsync(new PlaylistVideoPage(video, userPlaylist));
        }

        public async void FindPlaylist()
        {
            account = _baseViewModel.GetAccountInformation();
            id = account.Properties["Id"];
            await _playListDetailPageViewModel.FindUserPlaylist(Constants.FINDPLAYLIST, id, userPlaylist.Name);
            videos = _playListDetailPageViewModel.Playlist.Videos;
            SetViewContents();
        }

        //page reloading
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            account = _baseViewModel.GetAccountInformation();
            id = account.Properties["Id"];
            PlaylistDetailPageViewModel viewModel = new PlaylistDetailPageViewModel();
            await viewModel.FindUserPlaylist(Constants.FINDPLAYLIST, id, userPlaylist.Name);
            videosListView.ItemsSource = viewModel.Playlist.Videos;
        }

        public void SetViewContents()
        {
            videosListView.ItemsSource = videos;

            videosListView.ItemTemplate = new DataTemplate(() =>
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                    videoImage = new Image();
                    videoImage.SetBinding(Image.SourceProperty, "Image");
                    videoImage.Aspect = Aspect.Fill;

                    videoLbl = new Label();
                    videoLbl.FontFamily = Theme.Font;
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
                    videoLbl.TextColor = Theme.Azure;
                    videoLbl.SetBinding(Label.TextProperty, "Name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;

                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.BorderColor = Theme.Black;
                    videoFrame.BackgroundColor = Theme.Black;
                    videoFrame.HasShadow = false;
                    videoFrame.Padding = 3;

                    videoGrid.Children.Add(videoFrame, 0, 0);
                    videoGrid.Children.Add(videoLbl, 0, 0);

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Spacing = 0,
                            Padding = new Thickness(0, 5, 0, 5),
                            Children = {
                                videoGrid
                            }
                        }
                    };
                });
        }
    }
}

