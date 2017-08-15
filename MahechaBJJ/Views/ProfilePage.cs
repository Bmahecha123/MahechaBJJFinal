﻿﻿﻿﻿using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class ProfilePage : ContentPage
    {
		private BaseViewModel _baseViewModel = new BaseViewModel();
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

        public ProfilePage()
        {
            LoadUser();
            Title = "Profile";
            Icon = "003-settings.png";
            Padding = new Thickness(10, 30, 10, 10);

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
				BackgroundColor = Color.Orange,
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
				BackgroundColor = Color.Orange,
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
                BackgroundColor = Color.Orange,
                TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
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

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        //functions
        public void LoadUser(){
            account = _baseViewModel.GetAccountInformation();
            SetContent();
        }

        public async void SetContent(){
            user = await _baseViewModel.FindUserByIdAsync(Constants.FINDUSER, account.Properties["Id"]);
            if (_baseViewModel.Successful)
            {
				nameTextLbl.Text = user.Name;
				emailTextLbl.Text = user.Email;
				beltTextLbl.Text = user.Belt;
            } else {
                SetContent();
            }

		}

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
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
			else
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

