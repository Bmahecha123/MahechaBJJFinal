﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using MahechaBJJ.Droid;
#endif

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
        private bool isPressed;
#if __ANDROID__
        private Android.Widget.Button androidLoadBtn;
        private ContentView contentViewLoadBtn;
#endif


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
            BackgroundColor = Color.FromHex("#F1ECCE");

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
            BackgroundColor = Color.FromHex("#F1ECCE");

            this.modal = true;
#if __IOS__
            Icon = "search.png";
            Title = "Search";
            Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
            Icon = "search.png";
            Padding = new Thickness(5, 5, 5, 5);
#endif
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
                Style = (Style)Application.Current.Resources["common-activity-indicator"]

            };

            //View Objects
            innerGrid = new Grid
            {

                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(10, GridUnitType.Star)},
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


            searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for...",
                BackgroundColor = Color.FromHex("#F1ECCE"),
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
                Style = (Style)Application.Current.Resources["common-blue-btn"],
                Text = "Load More...",
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
            };

            backBtn = new Button
            {
                Style = (Style)Application.Current.Resources["common-red-btn"],
                Image = "back.png"
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidLoadBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidLoadBtn.Text = "Load More...";
            androidLoadBtn.Typeface = Constants.COMMONFONT;
            androidLoadBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidLoadBtn.SetBackground(pd);
            androidLoadBtn.SetTextColor(Android.Graphics.Color.Rgb(242, 253, 255));
            androidLoadBtn.Gravity = Android.Views.GravityFlags.Center;
            androidLoadBtn.SetAllCaps(false);
            androidLoadBtn.Click += async (object sender, EventArgs e) => {
                ToggleButtons();
                await LoadMoreVideos(sender, e);
                ToggleButtons();
            };

            contentViewLoadBtn = new ContentView();
            contentViewLoadBtn.Content = androidLoadBtn.ToView();
#endif

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
#if __IOS__
                    videoImage.SetBinding(Image.SourceProperty, "pictures.sizes[3].link");
                    videoImage.Aspect = Aspect.Fill;
#endif
#if __ANDROID__
                    videoImage.SetBinding(Image.SourceProperty, "pictures.sizes[4].link");
                    videoImage.Aspect = Aspect.AspectFill;
#endif

                    videoLbl = new Label();
                    videoLbl.SetBinding(Label.TextProperty, "name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

#if __IOS__
                    videoLbl.Style = (Style)Application.Current.Resources["common-technique-lbl"];
					videoLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt";
                    videoLbl.TextColor = Color.AntiqueWhite;
                    videoLbl.FontAttributes = FontAttributes.Bold;
#endif


                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.BorderColor = Color.Black;
                    videoFrame.BackgroundColor = Color.Black;
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

            //Building grid
            if (modal)
            {
#if __ANDROID__
                innerGrid.Children.Add(videoListView, 0, 0);
#endif
#if __IOS__
                innerGrid.Children.Add(backBtn, 0, 0);
                innerGrid.Children.Add(videoListView, 0, 1);
#endif
            }
            else
            {
                innerGrid.Children.Add(searchBar, 0, 0);
                innerGrid.Children.Add(videoListView, 0, 1);
            }

            if (moreToLoad)
            {

#if __ANDROID__
                innerGrid.Children.Add(contentViewLoadBtn, 0, 2);
                Grid.SetRowSpan(videoListView, 2);
#endif
#if __IOS__
                innerGrid.Children.Add(loadBtn, 0, 2);
                Grid.SetRowSpan(videoListView, 1);
#endif

            }
            else
            {

#if __ANDROID__
                innerGrid.Children.Remove(contentViewLoadBtn);
                if (modal)
                {
                    Grid.SetRowSpan(videoListView, 3);
                }
                else
                {
                    Grid.SetRowSpan(videoListView, 2);
                }
#endif
#if __IOS__
                innerGrid.Children.Remove(loadBtn);
                Grid.SetRowSpan(videoListView, 2);
#endif

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
#if __ANDROID__
                    innerGrid.Children.Add(contentViewLoadBtn, 0, 2);

#endif
#if __IOS__
                    innerGrid.Children.Add(loadBtn, 0, 2);
#endif
                    if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                    {
#if __ANDROID__
                        Grid.SetRowSpan(videoListView, 2);
#endif
#if __IOS__
                        Grid.SetRowSpan(videoListView, 1);
#endif
                    }
                }
                else
                {
                    moreToLoad = false;
#if __IOS__
                    innerGrid.Children.Remove(loadBtn);
#endif
#if __ANDROID__
                    innerGrid.Children.Remove(contentViewLoadBtn);
#endif
                    if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                    {
#if __IOS__
                        Grid.SetRowSpan(videoListView, 2);
#endif
#if __ANDROID__
                        if (modal)
                        {
                            Grid.SetRowSpan(videoListView, 3);
                        }
                        else
                        {
                            Grid.SetRowSpan(videoListView, 2);
                        }
#endif
                    }
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
#if __ANDROID__
                innerGrid.Children.Remove(contentViewLoadBtn);
#endif
#if __IOS__
                innerGrid.Children.Remove(loadBtn);
#endif
                if (Application.Current.MainPage.Width < Application.Current.MainPage.Height)
                {
#if __IOS__
                    Grid.SetRowSpan(videoListView, 2);
#endif
#if __ANDROID__
                    if (modal)
                    {
                        Grid.SetRowSpan(videoListView, 3);
                    }
#endif
                }
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
#if __ANDROID__
            androidLoadBtn.Clickable = !androidLoadBtn.Clickable;
#endif
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
#if __IOS__
                    innerGrid.Children.Add(backBtn, 0, 0);
                    innerGrid.Children.Add(videoListView, 1, 0);
#endif
#if __ANDROID__
                    innerGrid.Children.Add(videoListView, 0, 0);
                    Grid.SetColumnSpan(videoListView, 2);
#endif
                }
                else
                {
                    innerGrid.Children.Add(searchBar, 0, 0);
                    innerGrid.Children.Add(videoListView, 1, 0);
                }

                Grid.SetRowSpan(videoListView, 3);

                if (moreToLoad)
                {
#if __ANDROID__
                    innerGrid.Children.Add(contentViewLoadBtn, 0, 2);
#endif
#if __IOS__
                    innerGrid.Children.Add(loadBtn, 0, 2);
#endif
                }
                else
                {
#if __ANDROID__
                    innerGrid.Children.Remove(contentViewLoadBtn);
#endif
#if __IOS__
                    innerGrid.Children.Remove(loadBtn);
#endif
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Clear();

                //Building grid
                if (this.modal)
                {
#if __ANDROID__
                    innerGrid.Children.Add(videoListView, 0, 0);
#endif
#if __IOS__
                innerGrid.Children.Add(backBtn, 0, 0);
                innerGrid.Children.Add(videoListView, 0, 1);
#endif
                }
                else
                {
                    innerGrid.Children.Add(searchBar, 0, 0);
                    innerGrid.Children.Add(videoListView, 0, 1);
                }

                if (moreToLoad)
                {
#if __ANDROID__
                    innerGrid.Children.Add(contentViewLoadBtn, 0, 2);
                    Grid.SetRowSpan(videoListView, 2);
#endif
#if __IOS__
                    innerGrid.Children.Add(loadBtn, 0, 2);
                    Grid.SetRowSpan(videoListView, 1);
#endif

                }
                else
                {
#if __ANDROID__
                    innerGrid.Children.Remove(contentViewLoadBtn);

                    if (this.modal)
                    {
                        Grid.SetRowSpan(videoListView, 3);
                    }
                    else
                    {
                        Grid.SetRowSpan(videoListView, 2);
                    }
#endif
#if __IOS__
                    innerGrid.Children.Remove(loadBtn);
                Grid.SetRowSpan(videoListView, 2);
#endif

                }
                innerGrid.Children.Add(activityIndicator, 0, 0);
                Grid.SetRowSpan(activityIndicator, 3);

            }
        }
    }
}


