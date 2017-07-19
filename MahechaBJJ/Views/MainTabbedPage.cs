using System;
using System.Linq;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
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

