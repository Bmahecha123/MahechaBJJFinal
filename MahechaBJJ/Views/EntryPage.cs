﻿using System;
using System.Diagnostics;
using System.Linq;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class EntryPage : ContentPage
    {
		//viewModel
		private readonly SignInPageViewModel _signInPageViewModel = new SignInPageViewModel();
        private const String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Button loginBtn;
        private Button signUpBtn;
        private Button googleSignInBtn;
        //Xam Auth
        private Account account;
        private AccountStore store;
        private User user;

        public EntryPage()
        {
            if (Navigation.ModalStack.Count > 0){
                Navigation.PopToRootAsync();
            }
			//XAM AUTH
			store = AccountStore.Create();
			account = store.FindAccountsForService(Constants.AppName).FirstOrDefault();

            Padding = new Thickness(10, 30, 10, 10);
            //outer Grid
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            //inner Grid
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //view objects
            mahechaLogo = new Image
            {
                Source = ImageSource.FromResource("mahechabjjlogo.png"),
                Aspect = Aspect.AspectFit
            };
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            loginBtn = new Button
            {
                Text = "Login",
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            signUpBtn = new Button
            {
                Text = "Sign Up",
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.Orange,
				TextColor = Color.Black
            };
            googleSignInBtn = new Button
            {
                Text = "Google Sign Up",
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
			};
            //Button events
            loginBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new LoginPage());
            };
            googleSignInBtn.Clicked += OnLoginClicked;
            signUpBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new SignUpPage());
            };


            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(signUpBtn, 0, 1);
            innerGrid.Children.Add(loginBtn, 0, 2);
            innerGrid.Children.Add(googleSignInBtn, 0, 3);

            outerGrid.Children.Add(innerGrid);

            Content = outerGrid;
		}

        //Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

            if (width > height) {
                Padding = new Thickness(10, 10, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 3);
                innerGrid.Children.Add(signUpBtn, 1, 0);
                innerGrid.Children.Add(loginBtn, 1, 1);
                innerGrid.Children.Add(googleSignInBtn, 1, 2);
            } else {
				Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                innerGrid.Children.Add(loginBtn, 0, 1);
                innerGrid.Children.Add(signUpBtn, 0, 2);
                innerGrid.Children.Add(googleSignInBtn, 0, 3);
            }
		}
		//functions
		private async void CallVimeoApi()
		{
			string url = VIMEOURL;
			await _signInPageViewModel.GetVimeo(url);
            SetPageContent(_signInPageViewModel.VimeoInfo, user);
		}

		private void SetPageContent(BaseInfo Output, User user)
		{
            Navigation.PushModalAsync(new MainTabbedPage(Output, user));
		}

		void OnLoginClicked(object sender, EventArgs e)
		{
			string clientId = null;
			string redirectUri = null;

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					clientId = Constants.iOSClientId;
					redirectUri = Constants.iOSRedirectUrl;
					break;

				case Device.Android:
					clientId = Constants.AndroidClientId;
					redirectUri = Constants.AndroidRedirectUrl;
					break;
			}

			var authenticator = new OAuth2Authenticator(
				clientId,
				null,
				Constants.Scope,
				new Uri(Constants.AuthorizeUrl),
				new Uri(redirectUri),
				new Uri(Constants.AccessTokenUrl),
				null,
				true);

			authenticator.Completed += OnAuthCompleted;
			authenticator.Error += OnAuthError;

			AuthenticationState.Authenticator = authenticator;

			var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
			presenter.Login(authenticator);
		}

		async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
		{
			var authenticator = sender as OAuth2Authenticator;
			if (authenticator != null)
			{
				authenticator.Completed -= OnAuthCompleted;
				authenticator.Error -= OnAuthError;
			}

			user = null;
			if (e.IsAuthenticated)
			{
				// If the user is authenticated, request their basic user data from Google
				// UserInfoUrl = https://www.googleapis.com/oauth2/v2/userinfo
				var request = new OAuth2Request("GET", new Uri(Constants.UserInfoUrl), null, e.Account);
				var response = await request.GetResponseAsync();
				if (response != null)
				{
					// Deserialize the data and store it in the account store
					// The users email address will be used to identify data in SimpleDB
					string userJson = await response.GetResponseTextAsync();
					user = JsonConvert.DeserializeObject<User>(userJson);
				}

				if (account != null)
				{
					store.Delete(account, Constants.AppName);
				}
				await DisplayAlert("Email address", user.Email, "OK");

				await store.SaveAsync(account = e.Account, Constants.AppName);
                CallVimeoApi();
				await DisplayAlert("Email address", user.Email, "OK");
			}
		}

		void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
		{
			var authenticator = sender as OAuth2Authenticator;
			if (authenticator != null)
			{
				authenticator.Completed -= OnAuthCompleted;
				authenticator.Error -= OnAuthError;
			}

			Debug.WriteLine("Authentication error: " + e.Message);
		}
	}
}

