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
					techniqueImage = new Image();
					techniqueImage.SetBinding(Image.SourceProperty, "pictures.sizes[4].link");

					title = new Label();
                    title.FontAttributes = FontAttributes.Bold;
                    title.HorizontalOptions = LayoutOptions.CenterAndExpand;
					title.SetBinding(Label.TextProperty, "name");

                    //return a ViewCell
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Spacing = 0,
                            Padding = new Thickness(0, 20, 0, 20),
                            Children = {
                                techniqueImage,
                                title
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

            Content = searchLayout;

            async void SearchVimeo(object Sender, EventArgs e)
            {
                searchLayout.Children.Add(activityIndicator);
                activityIndicator.IsRunning = true;
                string url = VIMEOVIDEOS + VIDEOSPERPAGE + QUERY ;
                await _searchPageViewModel.SearchVideo(url + searchBar.Text);
                if (searchedVideos != null) {
                    searchedVideos.Clear();
                }

                for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++) {
                   searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
                }

                 while(_searchPageViewModel.Videos.paging.next != null) {
                    await _searchPageViewModel.SearchVideo("https://api.vimeo.com" + _searchPageViewModel.Videos.paging.next);
					for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
					{
						searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
					}
                }
                searchLayout.Children.Remove(activityIndicator);
                activityIndicator.IsRunning = false;
            }

            void LoadVideo(object Sender, SelectedItemChangedEventArgs e) {
                VideoData video = (MahechaBJJ.Model.VideoData)((ListView)Sender).SelectedItem;
                if (e.SelectedItem == null){
                    return;
                }
                ((ListView)Sender).SelectedItem = null;
                Navigation.PushModalAsync(new VideoDetailPage(video));
            }
         }
     }
}


