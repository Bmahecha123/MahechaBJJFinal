using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage(BaseInfo VimeoInfo)
        {
            Children.Add(new HomePage(VimeoInfo));
            Children.Add(new BrowsePage(VimeoInfo));
            Children.Add(new SearchPage());
            Children.Add(new ProfilePage());
        }
    }
}

