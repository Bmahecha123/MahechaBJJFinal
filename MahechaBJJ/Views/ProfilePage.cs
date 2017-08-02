﻿using System;
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
        Grid grid;
        Image profileImage;
        Label nameLbl;
        Label nameTextLbl;
        Label emailLbl;
        Label emailTextLbl;
        Button cancelSubBtn;
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
            user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
			//grid definiton
			grid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
				},
				ColumnDefinitions = new ColumnDefinitionCollection {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};

			//view Objects
			profileImage = new Image
			{
				//Source = user.Picture,
				Aspect = Aspect.AspectFit
			};
			nameLbl = new Label
			{
				Text = "Name:"
			};

			nameTextLbl = new Label
			{
				Text = user.Name
			};
			emailLbl = new Label
			{
				Text = "Email:"
			};
			emailTextLbl = new Label
			{
				Text = user.Email
			};
			cancelSubBtn = new Button
			{
				BackgroundColor = Color.Orange,
				Text = "Cancel Subscription"
			};
			logOutBtn = new Button
			{
				BackgroundColor = Color.Orange,
				Text = "Log Out"
			};
			//Events
			//TODO Enable account logout functionality with either Google and/or Facebook
			cancelSubBtn.Clicked += (sender, e) =>
			{
				DisplayAlert("Subscription Cancellation", "Are you you want to cancel your subscription?!", "Yess D8<!", "Never >8D!");
			};
			logOutBtn.Clicked += async (sender, e) =>
			{
				bool logout = await DisplayAlert("Logout", "Are you sure you want to log out " + user.Email + "?", "Yes, I'll be back friend.", "No");
				if (logout)
				{
					_baseViewModel.DeleteCredentials();
					var entryPage = new NavigationPage(new EntryPage());
					NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
					Application.Current.MainPage = entryPage;
				}
			};
			//Building Grid
			grid.Children.Add(profileImage, 0, 0);
			Grid.SetRowSpan(profileImage, 4);
			grid.Children.Add(nameLbl, 1, 0);
			grid.Children.Add(nameTextLbl, 1, 1);
			grid.Children.Add(emailLbl, 1, 2);
			grid.Children.Add(emailTextLbl, 1, 3);
			grid.Children.Add(cancelSubBtn, 0, 4);
			Grid.SetColumnSpan(cancelSubBtn, 2);
			grid.Children.Add(logOutBtn, 0, 5);
			Grid.SetColumnSpan(logOutBtn, 2);

			Content = grid;
        }
    }
}

