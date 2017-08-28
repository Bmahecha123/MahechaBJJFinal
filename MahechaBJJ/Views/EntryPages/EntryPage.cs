﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class EntryPage : ContentPage
    {
        //viewModel
        private readonly EntryPageViewModel _entryPageViewModel = new EntryPageViewModel();
        private const String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Button loginBtn;
        private Button signUpBtn;
        private Button aboutBtn;

        public EntryPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            SetContent();
		}

        public void SetContent()
        {
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
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};
			signUpBtn = new Button
			{
				Text = "Sign Up",
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
				BorderColor = Color.Black
			};
			aboutBtn = new Button
			{
				Text = "Learn More",
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
				BorderColor = Color.Black
			};
			//Button events
			loginBtn.Clicked += (object sender, EventArgs e) =>
			{
				Navigation.PushModalAsync(new LoginPage());
			};

			signUpBtn.Clicked += (sender, args) =>
			{
				Navigation.PushModalAsync(new SignUpPage());
			};


			innerGrid.Children.Add(mahechaLogo, 0, 0);
			innerGrid.Children.Add(signUpBtn, 0, 1);
			innerGrid.Children.Add(loginBtn, 0, 2);
			innerGrid.Children.Add(aboutBtn, 0, 3);

			outerGrid.Children.Add(innerGrid, 0, 0);

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
                innerGrid.Children.Add(aboutBtn, 1, 2);
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
                innerGrid.Children.Add(aboutBtn, 0, 3);
            }
		}
		//functions
	
	}
}

