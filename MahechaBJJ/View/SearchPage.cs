﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class SearchPage : ContentPage
    {
        private readonly SearchPageViewModel _searchPageViewModel = new SearchPageViewModel();
        private ObservableCollection<VideoData> searchedVideos = new ObservableCollection<VideoData>();

        public SearchPage()
        {
            Title = "Search";
            Padding = 30;

            var searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for..."
            };
            searchBar.SearchButtonPressed += SearchVimeo;

			//var videoListView = new ListView();
            //videoListView.ItemsSource = searchedVideos;
            //videoListView.SeparatorVisibility = SeparatorVisibility.None;
            //videoListView.HasUnevenRows = true;
            //videoListView.RowHeight = 100;
            //videoListView.Margin = 0;
            //videoListView.HeightRequest = 0;
            //videoListView.WidthRequest = 0;

            //var videoCell = new DataTemplate(typeof(ImageCell));
            //videoCell.SetBinding(ImageCell.ImageSourceProperty, "pictures.sizes[3].link");
            //videoCell.SetBinding(TextCell.TextProperty, "name");
            //videoCell.SetBinding(TextCell.TextProperty, );

            //videoListView.ItemTemplate = videoCell1;

            var videoListView1 = new ListView
            {
                ItemsSource = searchedVideos,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() => 
                {
					var techniqueImage = new Image();
					techniqueImage.SetBinding(Image.SourceProperty, "pictures.sizes[3].link");

					var title = new Label();
					title.SetBinding(Label.TextProperty, "name");

                    //return a ViewCell
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Children = {
                            techniqueImage,
                            title
                        }
                        }
                    };
                })
            };

			var searchLayout = new StackLayout
            {
                Children = 
                { 
                    searchBar,
                    videoListView1
                }

            };

            Content = searchLayout;

            async void SearchVimeo(object Sender, EventArgs e)
            {
                string url = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=10&query=";
                await _searchPageViewModel.SearchVideo(url + searchBar.Text);
                for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++) {
                   searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
                }
                await DisplayAlert("test", searchedVideos.Count.ToString(), "works!");
            }
        }
    }
}

