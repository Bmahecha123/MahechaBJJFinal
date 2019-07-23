using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MahechaBJJ.Views
{
    public class SearchPage : ContentPage
    {
        private SearchPageViewModel _searchPageViewModel;
        private BaseViewModel _baseViewModel;
        private Account account;
        private ObservableCollection<VideoData> searchedVideos;
        private ActivityIndicator activityIndicator;
        private SearchBar searchBar;
        private Button loadBtn;
        private bool moreToLoad = false;
        private ListView videoListView;
        private Grid videoGrid;
        private FlexLayout flexLayout;
        private Label videoLbl;
        private Image videoImage;
        private Frame videoFrame;
        private Button backBtn;
        private bool isPressed;

        //CONSTS
        private const string VIMEOBASEURL = "https://api.vimeo.com";
        private string VIMEOVIDEOS;
        private const string VIDEOSPERPAGE = "&per_page=5";
        private const string QUERY = "&query=";

        public SearchPage()
        {
            _searchPageViewModel = new SearchPageViewModel();
            _baseViewModel = new BaseViewModel();
            searchedVideos = new ObservableCollection<VideoData>();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            IconImageSource = "search.png";
            Padding = Theme.Thickness;

            SetContent(false);

            Content = flexLayout;
        }

        public SearchPage(Album album)
        {
            _searchPageViewModel = new SearchPageViewModel();
            _baseViewModel = new BaseViewModel();
            searchedVideos = new ObservableCollection<VideoData>();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            IconImageSource = "search.png";
            Padding = Theme.Thickness;

            SetSearch(album);
            SetContent(true);

            Content = flexLayout;

            SearchVimeo(true);
        }

        //Functions
        private void SetSearch()
        {
            account = _baseViewModel.GetAccountInformation();
            if (account.Properties["Package"] != null)
            {
                var package = account.Properties["Package"];

                if (package == "Gi")
                {
                    VIMEOVIDEOS = Constants.VIMEOGIALBUM;
                }
                else if (package == "NoGi")
                {
                    VIMEOVIDEOS = Constants.VIMEONOGIALBUM;
                }
                else
                {
                    VIMEOVIDEOS = Constants.VIMEOGIANDNOGIALBUM;
                }
            }
        }

        private void SetSearch(Album album)
        {
            VIMEOVIDEOS = Constants.GetAlbum($"VIMEO{album.ToString()}ALBUM");

        }

        public void SetContent(bool modal)
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            //View Objects

            activityIndicator = new ActivityIndicator
            {
                Color = Theme.Blue,
                IsRunning = false,
                IsVisible = false,
                IsEnabled = false
            };

            //View Objects
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for...",
                BackgroundColor = Theme.Azure,
                CancelButtonColor = Theme.Red,
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black,
                FontFamily = Theme.Font,
            };

            loadBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Load More..."
            };

            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png"
            };

            videoListView = new ListView
            {
                ItemsSource = searchedVideos,
                BackgroundColor = Color.FromHex("#F1ECCE"),
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() =>
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                    videoImage = new Image();
                    videoImage.SetBinding(Image.SourceProperty, "pictures.sizes[4].link");
                    videoImage.Aspect = Aspect.AspectFill;

                    videoLbl = new Label();
                    videoLbl.SetBinding(Label.TextProperty, "name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
                    videoLbl.FontFamily = Theme.Font;
                    videoLbl.TextColor = Theme.Azure;

                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.BorderColor = Theme.Black;
                    videoFrame.BackgroundColor = Theme.Black;
                    videoFrame.HasShadow = false;
                    videoFrame.Padding = 3;

                    //building grid
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
                })
            };

            //Events
            searchBar.SearchButtonPressed += (object sender, EventArgs e) =>
            {
                ToggleButtons();
                SearchVimeo(false);
                ToggleButtons();
            };
            searchBar.Focused += (object sender, FocusEventArgs e) => {
                FocusSearchBar(sender, e);
            };

            videoListView.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => {
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
            backBtn.Clicked += (object sender, EventArgs e) =>
            {
                ToggleButtons();
                Navigation.PopModalAsync();
                ToggleButtons();
            };
            loadBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await LoadMoreVideos(sender, e);
                ToggleButtons();
            };

            FlexLayout.SetBasis(videoListView, 1);
            FlexLayout.SetBasis(activityIndicator, 1);

            FlexLayout.SetGrow(videoListView, 1);
            FlexLayout.SetGrow(activityIndicator, 1);

            if (modal)
            {
#if __ANDROID__
                flexLayout.Children.Add(videoListView);
#endif
#if __IOS__
                flexLayout.Children.Add(backBtn);
                flexLayout.Children.Add(videoListView);
#endif
            }
            else
            {
                flexLayout.Children.Add(searchBar);
                flexLayout.Children.Add(videoListView);
            }

            if (moreToLoad)
            {
                flexLayout.Children.Add(loadBtn);
            }
            else
            {
                flexLayout.Children.Remove(loadBtn);
            }

            flexLayout.Children.Add(activityIndicator);
        }

        public async void SearchVimeo(bool modal)
        {
            activityIndicator.IsRunning = true;
            activityIndicator.IsEnabled = true;
            activityIndicator.IsVisible = true;

            string url;

            if (modal)
            {
                url = VIMEOVIDEOS + VIDEOSPERPAGE;

                await _searchPageViewModel.SearchVideo(url);
            }
            else
            {
                SetSearch();
                url = VIMEOVIDEOS + VIDEOSPERPAGE + QUERY;

                if (searchBar.Text == " ")
                {
                    url = VIMEOVIDEOS + VIDEOSPERPAGE;
                }
                await _searchPageViewModel.SearchVideo(url + searchBar.Text);
            }

            activityIndicator.IsRunning = false;
            activityIndicator.IsEnabled = false;
            activityIndicator.IsVisible = false;
            if (_searchPageViewModel.Successful)
            {
                if (searchedVideos != null)
                {
                    searchedVideos.Clear();
                }

                for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
                {
                    searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
                }

                //checking whether to show load button or not
                if (_searchPageViewModel.Videos.paging.next != null)
                {
                    moreToLoad = true;

                    flexLayout.Children.Add(loadBtn);
                }
                else
                {
                    moreToLoad = false;

                    flexLayout.Children.Remove(loadBtn);
                }
            }
            else
            {
                searchBar.Text = "";
                await DisplayAlert("Network Time Out", "Unable to search videos, poor network connectivity.", "Try Again");
            }
        }

        public async Task LoadVideo(object Sender, SelectedItemChangedEventArgs e)
        {
            VideoData video = (VideoData)((ListView)Sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)Sender).SelectedItem = null;
            await Navigation.PushModalAsync(new VideoDetailPage(video));
        }

        public async Task LoadMoreVideos(object sender, EventArgs e)
        {
            await _searchPageViewModel.SearchVideo(VIMEOBASEURL + _searchPageViewModel.Videos.paging.next);

            for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
            {
                searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
            }
            CheckIfNextPageIsNull(sender, e);
        }

        //Checks if next page is null or not.
        public void CheckIfNextPageIsNull(object sender, EventArgs e)
        {
            if (_searchPageViewModel.Videos.paging.next == null)
            {
                moreToLoad = false;

                flexLayout.Children.Remove(loadBtn);
            }
        }

        //deals with searchBar being unfocused
        private void FocusSearchBar(object sender, EventArgs e)
        {
            searchBar.Text = " ";
        }

        private void ToggleButtons()
        {
            loadBtn.IsEnabled = !loadBtn.IsEnabled;
            backBtn.IsEnabled = !backBtn.IsEnabled;
            videoListView.IsEnabled = !videoListView.IsEnabled;
        }
    }
}