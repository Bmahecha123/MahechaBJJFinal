﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class FacebookProfilePage : ContentPage
    {
        FacebookPageViewModel _facebookViewModel = new FacebookPageViewModel();
        private string clientId = "602878376580983";
       
        WebView webView;

        StackLayout layout;

        public FacebookProfilePage()
        {
			var facebookApiRequest = "https://www.facebook.com/dialog/oauth?client_id="
				+ clientId
				+ "&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";
            
            webView = new WebView
            {
                Source = facebookApiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;

            Content = webView;
        }

        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokenFromUrl(e.Url);

            if (accessToken != "")
            {
                await _facebookViewModel.SetFacebookUserProfileAsync(accessToken);

                SetPageContent(_facebookViewModel.FacebookProfile);
            }
        }

        private String ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

                var accessToken = at.Remove(at.IndexOf("&expires_in="));
                DisplayAlert("access token", accessToken, "nice");
                return accessToken;
            }
            return string.Empty;
        }

		private void SetPageContent(FacebookProfile facebookProfile)
		{
			Content = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Padding = new Thickness(8, 30),
				Children =
				{
					new Label
					{
						Text = facebookProfile.Name,
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.Id,
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.IsVerified.ToString(),
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
                    {
                        Text = facebookProfile.Devices[0].ToString(),
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.Gender,
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.AgeRange.Min.ToString(),
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.Picture.Data.Url,
						TextColor = Color.Black,
						FontSize = 22,
					},
					new Label
					{
						Text = facebookProfile.Cover.Source,
						TextColor = Color.Black,
						FontSize = 22,
					},
				}
			};
		}
    }
}

