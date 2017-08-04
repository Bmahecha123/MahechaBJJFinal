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
        Image image;
        TapGestureRecognizer tapGestureRecognizer;
        //TODO ADD TOUCH EVENT TO PHOTO FOR USER TO SELECT THEIR PROFILE PICTURE

        public ProfilePage()
        {
            LoadUser();
            Title = "Profile";
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
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
				},
				ColumnDefinitions = new ColumnDefinitionCollection {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};

			//load User
			var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			//grid definiton
			image = new Image
			{
				Source = ImageSource.FromResource("mahechabjjlogo.png"),
				Aspect = Aspect.AspectFit
			};
            tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += SelectImage;
            image.GestureRecognizers.Add(tapGestureRecognizer);
			nameLbl = new Label
			{
				Text = "Name",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size * 1.5,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};

			nameTextLbl = new Label
			{
				Text = "Jon",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				HorizontalOptions = LayoutOptions.StartAndExpand
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
				FontSize = size * 1.5,
				HorizontalOptions = LayoutOptions.StartAndExpand
			};
			emailTextLbl = new Label
			{
				Text = "Doe",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = size,
				HorizontalOptions = LayoutOptions.StartAndExpand
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
			innerGrid.Children.Add(image, 1, 0);
			Grid.SetRowSpan(image, 3);
			innerGrid.Children.Add(emailLbl, 0, 2);
			innerGrid.Children.Add(emailTextLbl, 0, 3);
			Grid.SetColumnSpan(emailTextLbl, 2);
			innerGrid.Children.Add(contactUsBtn, 0, 4);
			Grid.SetColumnSpan(contactUsBtn, 2);
			innerGrid.Children.Add(logOutBtn, 0, 5);
			Grid.SetColumnSpan(logOutBtn, 2);
			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        //functions
        public void LoadUser(){
            account = _baseViewModel.GetAccountInformation();
            SetContent();
        }

        public async void SetContent(){
			user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
            nameTextLbl.Text = user.Name;
            emailTextLbl.Text = user.Email;
		}

        public async void SelectImage(object sender, EventArgs e)
        {
           var test = await DisplayActionSheet("Select Profile Image", "Cancel", "Destruction", "Brian", "Kevin", "Christine");
            await DisplayAlert("Result of ActionSheet", test, "cool");
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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(nameLbl, 0, 0);
                innerGrid.Children.Add(nameTextLbl, 0, 1);
                innerGrid.Children.Add(emailLbl, 0, 2);
                innerGrid.Children.Add(emailTextLbl, 0, 3);
                innerGrid.Children.Add(contactUsBtn, 0, 4);
                innerGrid.Children.Add(image, 1, 0);
                Grid.SetRowSpan(image, 4);
                innerGrid.Children.Add(logOutBtn, 1, 4);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				//Building Grid
				innerGrid.Children.Add(nameLbl, 0, 0);
				innerGrid.Children.Add(nameTextLbl, 0, 1);
				innerGrid.Children.Add(image, 1, 0);
				Grid.SetRowSpan(image, 3);
				innerGrid.Children.Add(emailLbl, 0, 2);
				innerGrid.Children.Add(emailTextLbl, 0, 3);
				Grid.SetColumnSpan(emailTextLbl, 2);
				innerGrid.Children.Add(contactUsBtn, 0, 4);
				Grid.SetColumnSpan(contactUsBtn, 2);
				innerGrid.Children.Add(logOutBtn, 0, 5);
				Grid.SetColumnSpan(logOutBtn, 2);
			}
		}
    }
}

