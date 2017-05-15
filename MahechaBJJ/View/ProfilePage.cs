using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            Title = "Profile";
            Padding = 30;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Profile Page" }
                }
            };
        }
    }
}

