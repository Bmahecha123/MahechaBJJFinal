using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views.Blog
{
    public class BlogDetailPage : ContentPage
    {
        public BlogDetailPage()
        {
            var browser = new WebView();
            var html = new HtmlWebViewSource
            {
            };
            browser.Source = html;

            Content = browser;
        }
    }
}

