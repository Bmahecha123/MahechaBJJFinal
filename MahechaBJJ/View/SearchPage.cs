using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class SearchPage : ContentPage
    {
        SearchPageViewModel _searchPageViewModel = new SearchPageViewModel();

        public SearchPage(BaseInfo VimeoInfo)
        {
            Title = "Search Page";
            Padding = 30;

            var searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for..."
            };
            searchBar.SearchButtonPressed += SearchVimeo;
            var searchLayout = new StackLayout
            {
                Children = { searchBar }
            };
            //TO DO.... ADD LISTVIEW IMPLEMENTATION TO CONNECT WITH VIEW MODEL

            Content = searchLayout;

            async void SearchVimeo(object Sender, EventArgs e)
            {
                string url = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=10&query=";
                await _searchPageViewModel.SearchVideo(url + searchBar.Text);
                await DisplayAlert("test", _searchPageViewModel.Videos.total.ToString(), "works!");
            }
        }
    }
}

