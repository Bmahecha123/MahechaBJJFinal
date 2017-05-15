using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            Children.Add(new HomePage());
            Children.Add(new BrowsePage());
            Children.Add(new SearchPage());
            Children.Add(new ProfilePage());
        }
    }
}

