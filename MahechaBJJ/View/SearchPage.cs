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

			var loadBtn = new Button
			{
				Text = "Load more..",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsVisible = false
			};

			var searchLayout = new StackLayout
            {
                Children = 
                { 
                    searchBar,
					activityIndicator,
                    videoListView,
                    loadBtn
                }
            };

			//Events
			searchBar.SearchButtonPressed += SearchVimeo;
            videoListView.ItemSelected += LoadVideo;
            loadBtn.Clicked += LoadMoreVideos;

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
                loadBtn.IsVisible = true;
                await DisplayAlert("test", searchedVideos.Count.ToString(), "works!");
            }

            void LoadVideo(object Sender, SelectedItemChangedEventArgs e) {
                VideoData video = (MahechaBJJ.Model.VideoData)((ListView)Sender).SelectedItem;
                if (e.SelectedItem == null){
                    return;
                }
                Navigation.PushModalAsync(new VideoDetailPage(video));
            }

            async void LoadMoreVideos(object Sender, EventArgs e) {
                string url = "https://api.vimeo.com" + _searchPageViewModel.Videos.paging.next;
                await _searchPageViewModel.SearchVideo(url);
                if(_searchPageViewModel.Videos == null) {
                    loadBtn.IsVisible = false;
                }
                else {
					for (int i = 0; i < _searchPageViewModel.Videos.data.Length; i++)
					{
						searchedVideos.Add(_searchPageViewModel.Videos.data[i]);
					}
					await DisplayAlert("test", searchedVideos.Count.ToString(), "works!");


				}
            }
        }
    }
}

