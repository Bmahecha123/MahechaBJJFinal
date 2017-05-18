using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class SearchPage : ContentPage
    {
        public SearchPage(BaseInfo VimeoInfo)
        {
            Title = "Search Page";
            Padding = 30;

            var searchBar = new SearchBar
            {
                Placeholder = "Enter technique to search for..."
            };

            var searchLayout = new StackLayout
            {
                Children = { searchBar }
            };
            //TO DO.... ADD LISTVIEW IMPLEMENTATION TO CONNECT WITH VIEW MODEL

            Content = searchLayout;
        }
    }
}

