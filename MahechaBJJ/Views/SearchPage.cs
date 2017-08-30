﻿﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class SearchPage : ContentPage
    {
        private readonly SearchPageViewModel _searchPageViewModel = new SearchPageViewModel();
        private ObservableCollection<VideoData> searchedVideos = new ObservableCollection<VideoData>();
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


        //CONSTS
        private const string VIMEOBASEURL = "https://api.vimeo.com";
        private const string VIMEOVIDEOS = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952";
        private const string VIDEOSPERPAGE = "&per_page=20";
        private const string QUERY = "&query=";

        public SearchPage()
        {
			Title = "Search";
            Icon = "004-search.png";
			Padding = new Thickness(10, 30, 10, 10);
            SetContent();
         }

        //Functions
        public void SetContent()
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
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 1.5,
				BackgroundColor = Color.Orange

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
					videoLbl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
#if __IOS__
					videoLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "Roboto Bold";
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
			searchBar.SearchButtonPressed += SearchVimeo;
			videoListView.ItemSelected += LoadVideo;
			loadBtn.Clicked += LoadMoreVideos;

            //Building grid
			innerGrid.Children.Add(searchBar, 0, 0);
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

		public async void SearchVimeo(object Sender, EventArgs e)
		{
            activityIndicator.IsRunning = true;
            activityIndicator.IsEnabled = true;
            activityIndicator.IsVisible = true;
            
			string url = VIMEOVIDEOS + VIDEOSPERPAGE + QUERY;

			if (searchBar.Text == " ")
            {
                url = VIMEOVIDEOS + VIDEOSPERPAGE;
            }
			await _searchPageViewModel.SearchVideo(url + searchBar.Text);
			activityIndicator.IsRunning = false;
			activityIndicator.IsEnabled = false;
			activityIndicator.IsVisible = false;
            if (_searchPageViewModel.Successful){
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
            } else {
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

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
				Padding = new Thickness(10, 10, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(searchBar, 0, 0);
                innerGrid.Children.Add(videoListView, 1, 0);
				Grid.SetRowSpan(videoListView, 3);
                if(moreToLoad)
                {
                    innerGrid.Children.Add(loadBtn, 0, 2);
                } else {
                    innerGrid.Children.Remove(loadBtn);
                }
				innerGrid.Children.Add(activityIndicator, 0, 0);
				Grid.SetRowSpan(activityIndicator, 3);
                Grid.SetColumnSpan(activityIndicator, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				innerGrid.Children.Add(searchBar, 0, 0);
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


