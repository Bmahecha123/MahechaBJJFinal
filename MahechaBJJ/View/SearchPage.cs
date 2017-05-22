using System;
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
        bool isLoading;
        public SearchPage()
        {
            Title = "Search";
            Padding = 30;
            //View Objects
            var activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
            };

            var searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for..."
            };

            var videoListView = new ListView
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
					activityIndicator,
                    videoListView
                }
            };

			//Events
			searchBar.SearchButtonPressed += SearchVimeo;
            videoListView.ItemSelected += LoadVideo;

            //videoListView.ItemAppearing += (sender, e) =>
           // {
           //    if (isLoading || searchedVideos.Count == 0) {
            //        return;
            //    }
                //hit bottom
              //  if (e.Item.ToString() == searchedVideos[searchedVideos.Count - 1]) 
              //  {
                    
              //  }
           // };

            Content = searchLayout;

            async void SearchVimeo(object Sender, EventArgs e)
            {
                activityIndicator.IsRunning = true;
                string url = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=10&query=";
                await _searchPageViewModel.SearchVideo(url + searchBar.Text);
                if (searchedVideos != null) {
                    searchedVideos.Clear();
                }
                activityIndicator.IsRunning = false;
                for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++) {
                   searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
                }
                await DisplayAlert("test", searchedVideos.Count.ToString(), "works!");
            }

            void LoadVideo(object Sender, SelectedItemChangedEventArgs e) {
                VideoData video = (MahechaBJJ.Model.VideoData)((ListView)Sender).SelectedItem;

                if (e.SelectedItem == null){
                    return;
                }

                DisplayAlert("Item Selected", e.SelectedItem.GetType().ToString() + ", " + video.name, "Cool");
                Navigation.PushModalAsync(new VideoDetailPage(video));
            }
        }
    }
}

