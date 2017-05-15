using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class BrowsePage : ContentPage
    {
        public BrowsePage()
        {
            Title = "Browse";
            Padding = 30;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Browse page" }
                }
            };
        }
    }
}

