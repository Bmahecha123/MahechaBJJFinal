using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class PlaylistViewPage : ContentPage
    {
        public PlaylistViewPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

