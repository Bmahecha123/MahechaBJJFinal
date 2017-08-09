﻿using System;
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
        ActivityIndicator activityIndicator;
        SearchBar searchBar;
        Button loadBtn;
        ListView videoListView;
        Image techniqueImage;
        Label title;
        StackLayout searchLayout;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid videoGrid;
        private Label videoLbl;
        private Image videoImage;
        private Frame videoFrame;


        //CONSTS
        private const string VIMEOVIDEOS = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952";
        private const string VIDEOSPERPAGE = "&per_page=100";
        private const string QUERY = "&query=";

        public SearchPage()
        {
			Title = "Search";
            Padding = new Thickness(10,30,10,10);
            //View Objects
            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

			//View Objects
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(10, GridUnitType.Star)}
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
            };

            loadBtn = new Button
            {
                Text = "Load More...",
                IsVisible = false
            };

            videoListView = new ListView
            {
                ItemsSource = searchedVideos,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() => 
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                    
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

			searchLayout = new StackLayout
            {
                Children = 
                { 
                    searchBar,
                    videoListView
                }
            };

			//Events
			searchBar.SearchButtonPressed += SearchVimeo;
            videoListView.ItemSelected += LoadVideo;

            //Building grid
            innerGrid.Children.Add(searchBar, 0, 0);
            innerGrid.Children.Add(videoListView, 0, 1);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
         }
		public async void SearchVimeo(object Sender, EventArgs e)
		{
			innerGrid.Children.Remove(videoListView);
			innerGrid.Children.Add(activityIndicator, 0, 1);
			activityIndicator.IsRunning = true;
			string url = VIMEOVIDEOS + VIDEOSPERPAGE + QUERY;
			await _searchPageViewModel.SearchVideo(url + searchBar.Text);
			if (searchedVideos != null)
			{
				searchedVideos.Clear();
			}

			for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
			{
				searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
			}

			while (_searchPageViewModel.Videos.paging.next != null)
			{
				await _searchPageViewModel.SearchVideo("https://api.vimeo.com" + _searchPageViewModel.Videos.paging.next);
				for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
				{
					searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
				}
			}
			innerGrid.Children.Remove(activityIndicator);
			innerGrid.Children.Add(videoListView, 0, 1);
			activityIndicator.IsRunning = false;
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
     }
}


