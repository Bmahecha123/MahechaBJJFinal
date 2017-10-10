﻿using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class LoginPage : ContentPage
    {
        private readonly BaseViewModel _baseViewModel;

		//declare objects
		private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Label emailLbl;
        private Entry emailEntry;
        private Label passwordLbl;
        private Entry passwordEntry;
        private Button loginBtn;
        private Button backBtn;
        private User user;
        private ScrollView scrollView;
        private StackLayout stackLayout;
        private StackLayout innerStackLayout;
        private StackLayout buttonLayout;


        public LoginPage()
        {
            _baseViewModel = new BaseViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
        }

		//functions
        private void BuildPageObjects()
        {
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			
            scrollView = new ScrollView();
            stackLayout = new StackLayout();
            buttonLayout = new StackLayout();
			innerStackLayout = new StackLayout();

            //View objects
			mahechaLogo = new Image
			{
				Source = ImageSource.FromResource("mahechabjjlogo.png"),
				Aspect = Aspect.AspectFit
			};
			emailLbl = new Label
			{
				Text = "E-Mail Address",
				FontSize = lblSize * 2,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center

			};
			emailEntry = new Entry
			{
				Placeholder = "SpiderGuard123@gmail.com",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize,
			};
			passwordLbl = new Label
			{
				Text = "Password",
				FontSize = lblSize * 2,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			passwordEntry = new Entry
			{
				IsPassword = true,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize
			};
			loginBtn = new Button
			{
				Text = "Login",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
				//BackgroundColor = Color.Orange,
                BackgroundColor = Color.FromRgb(58, 93, 174),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			backBtn = new Button
			{
				Text = "Back",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
                //BackgroundColor = Color.Orange,
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
			};
			//Events
			loginBtn.Clicked += Validate;
			backBtn.Clicked += GoBack;

			buttonLayout.Children.Add(backBtn);
			buttonLayout.Children.Add(loginBtn);
			buttonLayout.Orientation = StackOrientation.Horizontal;
			innerStackLayout.Children.Add(emailLbl);
			innerStackLayout.Children.Add(emailEntry);
			innerStackLayout.Children.Add(passwordLbl);
			innerStackLayout.Children.Add(passwordEntry);
			innerStackLayout.Children.Add(buttonLayout);
            stackLayout.Children.Add(mahechaLogo);
            stackLayout.Children.Add(innerStackLayout);
            stackLayout.Orientation = StackOrientation.Vertical;


            scrollView.Content = stackLayout;
            scrollView.HorizontalOptions = LayoutOptions.Fill;
            scrollView.VerticalOptions = LayoutOptions.Fill;
            Content = scrollView;
        }

        private void Validate(object sender, EventArgs e)
        {
            loginBtn.IsEnabled = false;
            if(emailEntry.Text != null || passwordEntry.Text != null)
            {
                Login(sender, e);
            }
            else
            {
                DisplayAlert("Login Error!", "Make sure all fields are filled in!", "Ok, got it.");
            }
            loginBtn.IsEnabled = true;
        }

        private async void Login(object sender, EventArgs e)
        {
            user = await _baseViewModel.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, emailEntry.Text, passwordEntry.Text);
            if (user == null) {
                await DisplayAlert("User Not Found", "Wrong Email address or Password, please try again.", "Got It");
            }
            else 
            {
					_baseViewModel.SaveCredentials(user.Email, user.password, user.Id);
					Application.Current.MainPage = new MainTabbedPage();
            }

        }

        private void GoBack(object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
        }

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                Padding = new Thickness(10, 10, 10, 10);
                mahechaLogo.Scale = 0;
                mahechaLogo.IsVisible = false;
				stackLayout.Orientation = StackOrientation.Horizontal;
                stackLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;
                stackLayout.VerticalOptions = LayoutOptions.CenterAndExpand;
                buttonLayout.VerticalOptions = LayoutOptions.EndAndExpand;
            }
            else
            {
                mahechaLogo.Scale = 1;
                mahechaLogo.IsVisible = true;
                Padding = new Thickness(10, 30, 10, 10);
				stackLayout.Orientation = StackOrientation.Vertical;
            }
		}
    }
}

