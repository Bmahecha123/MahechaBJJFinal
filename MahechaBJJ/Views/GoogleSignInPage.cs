﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class GoogleSignInPage : ContentPage
    {
		private readonly SignInPageViewModel _signInPageViewModel = new SignInPageViewModel();

        //declare objects
        Grid grid;
        Image mahechaLogo;
        Button signUpBtn;

		public GoogleSignInPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
			//Grid view definition
			grid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
				}
			};
            //View objects
            mahechaLogo = new Image
            {
                Source = ImageSource.FromFile("mahechabjj.jpg"),
                Aspect = Aspect.AspectFit
            };
            signUpBtn = new Button
            {
                Text = "Sign Up",
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            //Events
            signUpBtn.Clicked += CallVimeoApi;

            grid.Children.Add(mahechaLogo, 0, 0);
            grid.Children.Add(signUpBtn, 0, 1);

            Content = grid;
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

