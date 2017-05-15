using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class SearchPage : ContentPage
    {
        public SearchPage()
        {
            Title = "Search Page";
            Padding = 30;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello SearchPage" }
                }
            };
        }
    }
}

