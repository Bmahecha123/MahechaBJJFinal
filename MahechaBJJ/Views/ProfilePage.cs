﻿﻿using System;
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
		private const string FINDUSER = "http://localhost:8080/user/findById/";
		//declare objects
		BaseViewModel _baseViewModel = new BaseViewModel();
        Grid outerGrid;
        Grid innerGrid;
        Label nameLbl;
        Label nameTextLbl;
        Label emailLbl;
        Label emailTextLbl;
        Button contactUsBtn;
        Button logOutBtn;
        Account account;
        User user;

        public ProfilePage()
        {
            LoadUser();
            Title = "Profile";
            Padding = new Thickness(10, 30, 10, 10);

        }

        public void LoadUser(){
            account = _baseViewModel.GetAccountInformation();
            SetContent();
        }

        public async void SetContent(){
			//load User
			var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
			//grid definiton
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
				}
			};
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
				    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
            };
			nameLbl = new Label
			{
				Text = "Name",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 2,
                HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			nameTextLbl = new Label
			{
				Text = user.Name,
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			emailLbl = new Label
			{
				Text = "E-Mail",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			emailTextLbl = new Label
			{
				Text = user.Email,
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
                HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			contactUsBtn = new Button
			{
				Text = "Contact Us",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};
			logOutBtn = new Button
			{
				Text = "Log Out",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
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
            innerGrid.Children.Add(nameTextLbl, 0, 1);
            innerGrid.Children.Add(emailLbl, 0, 2);
            innerGrid.Children.Add(emailTextLbl, 0, 3);
            innerGrid.Children.Add(contactUsBtn, 0, 4);
            innerGrid.Children.Add(logOutBtn, 0, 5);
            outerGrid.Children.Add(innerGrid);

			Content = innerGrid;
        }
    }
}

