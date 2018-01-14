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
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid videoGrid;
        private Frame videoFrame;
        private Image videoImage;
        private Label videoLbl;
        private Button deleteBtn;
        private PlayList userPlaylist;
        private ObservableCollection<Video> videos;

        public PlaylistDetailPage(PlayList playlist)
        {
            _baseViewModel = new BaseViewModel();
            _playListDetailPageViewModel = new PlaylistDetailPageViewModel();
            Title = playlist.Name;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            userPlaylist = playlist;
            FindPlaylist();
            SetContent();
        }

        //Functions
        public void SetContent()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //View Objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    #if __IOS__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(10, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
#endif
#if __ANDROID__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(10, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
#endif
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

            playlistNameLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.TailTruncation,
#endif
                Text = userPlaylist.Name,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            playlistDescriptionLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                LineBreakMode = LineBreakMode.TailTruncation,
#endif
                Text = userPlaylist.Description,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            videosListView = new ListView
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

            deleteBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                Text = "Delete",
                BackgroundColor = Color.Red,
                BorderWidth = 3,
                TextColor = Color.White
            };

            //Events
            backBtn.Clicked += GoBack;
            deleteBtn.Clicked += DeletePlaylist;
            videosListView.ItemSelected += LoadVideo;

            //Building Grid
            innerGrid.Children.Add(playlistNameLbl, 0, 0);
            Grid.SetColumnSpan(playlistNameLbl, 2);
            innerGrid.Children.Add(playlistDescriptionLbl, 0, 1);
            Grid.SetColumnSpan(playlistDescriptionLbl, 2);
            innerGrid.Children.Add(videosListView, 0, 2);
            Grid.SetColumnSpan(videosListView, 2);
#if __IOS__
            innerGrid.Children.Add(backBtn, 0, 3);
			innerGrid.Children.Add(deleteBtn, 1, 3);
#endif
#if __ANDROID__
            innerGrid.Children.Add(deleteBtn, 0, 3);
            Grid.SetColumnSpan(deleteBtn, 2);
#endif
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public void GoBack(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PopModalAsync();
        }

        public async void DeletePlaylist(object sender, EventArgs e)
        {
            ToggleButtons();
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
            backBtn.IsEnabled = !backBtn.IsEnabled;
            deleteBtn.IsEnabled = !deleteBtn.IsEnabled;
        }

        public void LoadVideo(object sender, SelectedItemChangedEventArgs e)
        {
            Video video = (Video)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            //VideoData videoData = new VideoData(video.Name, video.Description, video.Link, video.Image);
            ((ListView)sender).SelectedItem = null;
            Navigation.PushModalAsync(new PlaylistVideoPage(video, userPlaylist));

        }

        public async void FindPlaylist()
        {
            account = _baseViewModel.GetAccountInformation();
            id = account.Properties["Id"];
            await _playListDetailPageViewModel.FindUserPlaylist(Constants.FINDPLAYLIST, id, userPlaylist.Name);
            videos = _playListDetailPageViewModel.Playlist.Videos;
            SetViewContents();
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
#if __IOS__
                    videoLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "Roboto Bold";
#endif
                    videoLbl.SetBinding(Label.TextProperty, "Name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.TextColor = Color.White;
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.OutlineColor = Color.Black;
                    videoFrame.BackgroundColor = Color.Black;
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

        //Orientation
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(playlistNameLbl, 0, 0);
#if __ANDROID__
                innerGrid.Children.Add(deleteBtn, 0, 2);
#endif
#if __IOS__
                innerGrid.Children.Add(deleteBtn, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
#endif
                innerGrid.Children.Add(videosListView, 1, 0);
                Grid.SetRowSpan(videosListView, 3);
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
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
#endif
#if __IOS__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
#endif

                innerGrid.Children.Clear();
                //Building Grid
                innerGrid.Children.Add(playlistNameLbl, 0, 0);
                Grid.SetColumnSpan(playlistNameLbl, 2);
                innerGrid.Children.Add(playlistDescriptionLbl, 0, 1);
                Grid.SetColumnSpan(playlistDescriptionLbl, 2);
                innerGrid.Children.Add(videosListView, 0, 2);
                Grid.SetColumnSpan(videosListView, 2);
#if __IOS__
            innerGrid.Children.Add(backBtn, 0, 3);
            innerGrid.Children.Add(deleteBtn, 1, 3);
#endif
#if __ANDROID__
                innerGrid.Children.Add(deleteBtn, 0, 3);
                Grid.SetColumnSpan(deleteBtn, 2);
#endif
            }
        }
    }
}

