﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class SignUpPage : ContentPage
    {
        private readonly SignInPageViewModel _signInPageViewModel = new SignInPageViewModel();

        //declare objects
        Grid innerGrid;
        Grid outerGrid;
        Image mahechaLogo;
        Label firstNameLbl;
        Entry firstNameEntry;
        Label lastNameLbl;
        Entry lastNameEntry;
        Label emailAddressLbl;
        Entry emailAddressEntry;
        Label passWordLbl;
        Entry passWordEntry;
        Label passWordRepeatLbl;
        Entry passWordRepeatEntry;
        Button signUpBtn;

        public SignUpPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            //Grid view definition
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };

			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
				}
			};
			//View objects
			mahechaLogo = new Image
			{
				Source = ImageSource.FromResource("mahechabjjlogo.png"),
				Aspect = Aspect.AspectFit
			};
            //TODO DEFINE OBJECTS
            firstNameLbl = new Label
            {

            };
            firstNameEntry = new Entry
            {

            };
            lastNameLbl = new Label
            {

            };
            lastNameEntry = new Entry
            {

            };
            emailAddressLbl = new Label
            {

            };
            emailAddressEntry = new Entry
            {

            };
			signUpBtn = new Button
			{
				Text = "Sign Up",
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};
            //Button Events
            signUpBtn.Clicked += CallVimeoApi;

            innerGrid.Children.Add(firstNameLbl, 0, 0);
            innerGrid.Children.Add(firstNameEntry, 1, 0);
            innerGrid.Children.Add(lastNameLbl, 0, 1);
            innerGrid.Children.Add(lastNameEntry, 1, 1);
            innerGrid.Children.Add(emailAddressLbl, 0, 2);
            innerGrid.Children.Add(emailAddressEntry, 1, 2);
            innerGrid.Children.Add(passWordLbl, 0, 3);
            innerGrid.Children.Add(passWordEntry, 1, 3);
            innerGrid.Children.Add(passWordRepeatLbl, 0, 4);
            innerGrid.Children.Add(passWordRepeatEntry, 1, 4);
            innerGrid.Children.Add(signUpBtn, 0, 5);
            Grid.SetColumnSpan(signUpBtn, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

		//functions
		private async void CallVimeoApi(object sender, EventArgs e)
		{
			string url = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
			await _signInPageViewModel.GetVimeo(url);
            SetPageContent(_signInPageViewModel.VimeoInfo);
		}

		private void SetPageContent(BaseInfo Output)
		{
            Navigation.PushModalAsync(new MainTabbedPage(Output));
		}
    }
}

