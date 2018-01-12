using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using Xamarin.Auth;
using Xamarin.Forms;

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
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid videoGrid;
        private Label videoLbl;
        private Image videoImage;
        private Frame videoFrame;
        private Button backBtn;
        private bool modal;


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
            this.modal = false;
#if __IOS__
            Icon = "search.png";
            Title = "Search";
            Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
            Icon = "search.png";
            Padding = new Thickness(5, 5, 5, 5);
#endif

            //SetSearch();
            SetContent(false);
        }

        public SearchPage(Album album)
        {
            _searchPageViewModel = new SearchPageViewModel();
            _baseViewModel = new BaseViewModel();
            searchedVideos = new ObservableCollection<VideoData>();
            this.modal = true;
            Title = "Search";
            Icon = "004-search.png";
            Padding = new Thickness(10, 30, 10, 10);
            SetSearch(album);
            SetContent(true);
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
                IsRunning = false,
                IsEnabled = false,
                IsVisible = false
            };

            //View Objects
            innerGrid = new Grid
            {

                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(10, GridUnitType.Star)},
                    #if __ANDROID__
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}

                    #endif
                    #if __IOS__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}

                    #endif
                }
            };

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };


            searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for...",
                CancelButtonColor = Color.Red,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
            };

            loadBtn = new Button
            {
                Text = "Load More...",
                BorderWidth = 3,
                BorderColor = Color.Black,
                TextColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174)

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
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            videoListView = new ListView
            {
                ItemsSource = searchedVideos,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() =>
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                    videoImage = new Image();
                    videoImage.SetBinding(Image.SourceProperty, "pictures.sizes[3].link");
                    videoImage.Aspect = Aspect.Fill;

                    videoLbl = new Label();
                    videoLbl.SetBinding(Label.TextProperty, "name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.TextColor = Color.White;
#if __IOS__
					videoLbl.FontFamily = "AmericanTypewriter-Bold";
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "Roboto Bold";
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
#endif


                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.OutlineColor = Color.Black;
                    videoFrame.BackgroundColor = Color.Black;
                    videoFrame.HasShadow = false;
                    videoFrame.Padding = 3;

                    //building grid
                    videoGrid.Children.Add(videoFrame, 0, 0);
                    videoGrid.Children.Add(videoLbl, 0, 0);

                    //return a ViewCell
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
                SearchVimeo(false);
            };
            searchBar.Focused += FocusSearchBar;
            videoListView.ItemSelected += LoadVideo;
            backBtn.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PopModalAsync();
            };
            loadBtn.Clicked += LoadMoreVideos;

            //Building grid
            if (modal)
            {
                innerGrid.Children.Add(backBtn, 0, 0);
            }
            else
            {
                innerGrid.Children.Add(searchBar, 0, 0);
            }

            innerGrid.Children.Add(videoListView, 0, 1);
            if (moreToLoad)
            {
                innerGrid.Children.Add(loadBtn, 0, 2);
                Grid.SetRowSpan(videoListView, 1);
            }
            else
            {
                innerGrid.Children.Remove(loadBtn);
                Grid.SetRowSpan(videoListView, 2);
            }
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 3);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
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
                    innerGrid.Children.Add(loadBtn, 0, 2);
                    if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                    {
                        Grid.SetRowSpan(videoListView, 1);
                    }
                }
                else
                {
                    moreToLoad = false;
                    innerGrid.Children.Remove(loadBtn);
                    if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                    {
                        Grid.SetRowSpan(videoListView, 2);
                    }
                }
            }
            else
            {
                searchBar.Text = "";
                await DisplayAlert("Network Time Out", "Unable to search videos, poor network connectivity.", "Try Again");
            }
        }

        public void LoadVideo(object Sender, SelectedItemChangedEventArgs e)
        {
            VideoData video = (VideoData)((ListView)Sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)Sender).SelectedItem = null;
            Navigation.PushModalAsync(new VideoDetailPage(video));
        }

        public async void LoadMoreVideos(object sender, EventArgs e)
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
                innerGrid.Children.Remove(loadBtn);
                if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                {
                    Grid.SetRowSpan(videoListView, 2);
                }
            }
        }

        //deals with searchBar being unfocused
        private void FocusSearchBar(object sender, EventArgs e)
        {
            searchBar.Text = " ";
        }

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Star) });
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                loadBtn.Text = "More";
#endif
#if __IOS__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
#endif
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.Children.Clear();

                if (this.modal)
                {
                    innerGrid.Children.Add(backBtn, 0, 0);
                }
                else
                {
                    innerGrid.Children.Add(searchBar, 0, 0);
                }

                innerGrid.Children.Add(videoListView, 1, 0);
                Grid.SetRowSpan(videoListView, 3);

                if (moreToLoad)
                {
                    innerGrid.Children.Add(loadBtn, 0, 2);
                }
                else
                {
                    innerGrid.Children.Remove(loadBtn);
                }
                innerGrid.Children.Add(activityIndicator, 0, 0);
                Grid.SetRowSpan(activityIndicator, 3);
                Grid.SetColumnSpan(activityIndicator, 2);
            }
            else
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                loadBtn.Text = "Load More...";

#endif
#if __IOS__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

#endif
                innerGrid.Children.Clear();

                if (modal)
                {
                    innerGrid.Children.Add(backBtn, 0, 0);
                }
                else
                {
                    innerGrid.Children.Add(searchBar, 0, 0);
                }

                innerGrid.Children.Add(videoListView, 0, 1);

                if (moreToLoad)
                {
                    innerGrid.Children.Add(loadBtn, 0, 2);
                    Grid.SetRowSpan(videoListView, 1);
                }
                else
                {
                    innerGrid.Children.Remove(loadBtn);
                    Grid.SetRowSpan(videoListView, 2);
                }
                innerGrid.Children.Add(activityIndicator, 0, 0);
                Grid.SetRowSpan(activityIndicator, 3);
            }
        }
    }
}


