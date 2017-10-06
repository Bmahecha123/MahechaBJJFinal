﻿﻿﻿﻿using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.EntryPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class ProfilePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private Grid outerGrid;
        private Grid innerGrid;
        private Label nameLbl;
        private Label nameTextLbl;
        private Label emailLbl;
        private Label emailTextLbl;
        private Label beltLbl;
        private Label beltTextLbl;
        private Button contactUsBtn;
        private Button logOutBtn;
        private Button settingsBtn;
        private Account account;
        private User user;
		private Label timeOutLbl;
		private Frame timeOutFrame;
		private TapGestureRecognizer timeOutTap;
		private ActivityIndicator activityIndicator;

        public ProfilePage()
        {
            _baseViewModel = new BaseViewModel();
            Title = "Profile";
            Icon = "karate.png";
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
            SetContent();
		}

        //functions
        public void BuildPageObjects()
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

			outerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
				},
				ColumnDefinitions = new ColumnDefinitionCollection {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};

			//load User
			var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			//grid definiton

			nameLbl = new Label
			{
				Text = "Name:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};

			nameTextLbl = new Label
			{
				Text = "Jon",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			emailLbl = new Label
			{
				Text = "E-Mail:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			emailTextLbl = new Label
			{
				Text = "Doe",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
				LineBreakMode = LineBreakMode.TailTruncation
			};
			beltLbl = new Label
			{
				Text = "Belt:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			beltTextLbl = new Label
			{
				Text = "White",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			contactUsBtn = new Button
			{
				Text = "Contact Us",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.FromRgb(58, 93, 174),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
			};
			logOutBtn = new Button
			{
				Text = "Log Out",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.FromRgb(58, 93, 174),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
			};
			settingsBtn = new Button
			{
				Text = "Settings",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.FromRgb(58, 93, 174),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
			};
			timeOutLbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Network Has Timed Out! \n Click To Try Again!",
				LineBreakMode = LineBreakMode.WordWrap,
				FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.White
			};
			timeOutFrame = new Frame
			{
				Content = timeOutLbl,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			timeOutTap = new TapGestureRecognizer();
			timeOutTap.Tapped += (sender, e) =>
			{
				SetContent();
			};
			timeOutLbl.GestureRecognizers.Add(timeOutTap);
			activityIndicator = new ActivityIndicator
			{
				IsRunning = false,
				IsEnabled = true,
				IsVisible = true
			};

			//Events
			//TODO enable email sending when Contact button is sent
			contactUsBtn.Clicked += (sender, e) =>
			{
				DisplayAlert("Subscription Cancellation", "Are you you want to cancel your subscription?!", "Yess D8<!", "Never >8D!");
			};
			logOutBtn.Clicked += async (sender, e) =>
			{
				bool logout = await DisplayAlert("Logout", "Are you sure you want to log out " + user.Email + "?", "Yes, I'll be back friend.", "No, I'll stay!");
				if (logout)
				{
					_baseViewModel.DeleteCredentials();
					var entryPage = new NavigationPage(new EntryPage());
					NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
					Application.Current.MainPage = entryPage;
				}
			};

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        public async void SetContent()
        {
            //add activity indicator while contents load
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 6);
            Grid.SetColumnSpan(activityIndicator, 3);

            if (account == null)
            {
				account = _baseViewModel.GetAccountInformation();
			}
            if (_baseViewModel.User == null)
            {
				user = await _baseViewModel.FindUserByIdAsync(Constants.FINDUSER, account.Properties["Id"]);
			}
            if (_baseViewModel.Successful)
            {
                activityIndicator.IsRunning = false;
				nameTextLbl.Text = user.Name;
				emailTextLbl.Text = user.Email;
				beltTextLbl.Text = user.Belt;

				//Building Grid
				innerGrid.Children.Add(nameLbl, 0, 0);
				innerGrid.Children.Add(nameTextLbl, 1, 0);
				Grid.SetColumnSpan(nameTextLbl, 2);
				innerGrid.Children.Add(beltLbl, 0, 1);
				innerGrid.Children.Add(beltTextLbl, 1, 1);
				Grid.SetColumnSpan(beltTextLbl, 2);
				innerGrid.Children.Add(emailLbl, 0, 2);
				innerGrid.Children.Add(emailTextLbl, 1, 2);
				Grid.SetColumnSpan(emailTextLbl, 2);
				innerGrid.Children.Add(contactUsBtn, 0, 3);
				Grid.SetColumnSpan(contactUsBtn, 3);
				innerGrid.Children.Add(settingsBtn, 0, 4);
				Grid.SetColumnSpan(settingsBtn, 3);
				innerGrid.Children.Add(logOutBtn, 0, 5);
				Grid.SetColumnSpan(logOutBtn, 3);
            } else {
				innerGrid.Children.Clear();
				innerGrid.Children.Add(timeOutFrame, 0, 0);
				Grid.SetRowSpan(timeOutFrame, 6);
				Grid.SetRowSpan(timeOutLbl, 3);
				Grid.SetColumnSpan(timeOutFrame, 6);
				Grid.SetColumnSpan(timeOutLbl, 3);
            }

		}

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
                if (_baseViewModel.User != null)
                {
					Padding = new Thickness(10, 10, 10, 10);
					innerGrid.RowDefinitions.Clear();
					innerGrid.ColumnDefinitions.Clear();
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					//Layout Options
					nameLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					nameLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					nameTextLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					nameTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					beltLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					beltLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					beltTextLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					beltTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					emailLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					emailLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					emailTextLbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
					emailTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					//Building Grid
					innerGrid.Children.Clear();
					innerGrid.Children.Add(nameLbl, 0, 0);
					innerGrid.Children.Add(nameTextLbl, 0, 1);
					innerGrid.Children.Add(emailLbl, 0, 2);
					innerGrid.Children.Add(emailTextLbl, 0, 3);
					innerGrid.Children.Add(beltLbl, 0, 4);
					innerGrid.Children.Add(beltTextLbl, 0, 5);
					innerGrid.Children.Add(contactUsBtn, 1, 0);
					Grid.SetRowSpan(contactUsBtn, 2);
					innerGrid.Children.Add(settingsBtn, 1, 2);
					Grid.SetRowSpan(settingsBtn, 2);
					innerGrid.Children.Add(logOutBtn, 1, 4);
					Grid.SetRowSpan(logOutBtn, 2);
                }
			}
			else
			{
                if (_baseViewModel.User != null)
                {
					Padding = new Thickness(10, 30, 10, 10);
					innerGrid.RowDefinitions.Clear();
					innerGrid.ColumnDefinitions.Clear();
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.Children.Clear();
					//Layout Options
					nameLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					nameLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					nameTextLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					nameTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					beltLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					beltLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					beltTextLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					beltTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					emailLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					emailLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					emailTextLbl.HorizontalOptions = LayoutOptions.StartAndExpand;
					emailTextLbl.VerticalOptions = LayoutOptions.CenterAndExpand;
					//Building Grid
					innerGrid.Children.Add(nameLbl, 0, 0);
					innerGrid.Children.Add(nameTextLbl, 1, 0);
					Grid.SetColumnSpan(nameTextLbl, 2);
					innerGrid.Children.Add(beltLbl, 0, 1);
					innerGrid.Children.Add(beltTextLbl, 1, 1);
					Grid.SetColumnSpan(beltTextLbl, 2);
					innerGrid.Children.Add(emailLbl, 0, 2);
					innerGrid.Children.Add(emailTextLbl, 1, 2);
					Grid.SetColumnSpan(emailTextLbl, 2);
					innerGrid.Children.Add(contactUsBtn, 0, 3);
					Grid.SetColumnSpan(contactUsBtn, 3);
					innerGrid.Children.Add(settingsBtn, 0, 4);
					Grid.SetColumnSpan(settingsBtn, 3);
					innerGrid.Children.Add(logOutBtn, 0, 5);
					Grid.SetColumnSpan(logOutBtn, 3);
                }
			}
		}
    }
}

