﻿using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;
using Xamarin.Auth;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace MahechaBJJ.Views
{
    public class SignUpPage : ContentPage
    {
        //ViewModel
        private SignUpPageViewModel _signUpPageViewModel = new SignUpPageViewModel();
        private BaseViewModel _baseViewModel = new BaseViewModel();
        private const string CREATEUSER = "http://localhost:8080/user/create";
        //declare objects
        private Grid innerGrid;
        private Grid outerGrid;
        private Image mahechaLogo;
        private Label nameLbl;
        private Entry nameEntry;
        private Label beltLbl;
        private Picker beltPicker;
        private ObservableCollection<string> beltList;
        private Label emailAddressLbl;
        private Entry emailAddressEntry;
        private Label passWordLbl;
        private Entry passWordEntry;
        private Label passWordRepeatLbl;
        private Entry passWordRepeatEntry;
        private Label secretQuestionLbl;
        private Picker secretQuestionPicker1;
        private Entry secretQuestionEntry1;
        private Picker secretQuestionPicker2;
        private Entry secretQuestionEntry2;
        private Button signUpBtn;
        private Button backBtn;
        private Button clearBtn;
        private User user;
        private ObservableCollection<string> secretQuestionList1;
        private ObservableCollection<string> secretQuestionList2;
        //Xam Auth
        Account account;

        public SignUpPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            user = new User();
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));			//Grid view definition
			outerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection 
                {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};

			innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
				    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				},
                ColumnDefinitions = new ColumnDefinitionCollection {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
			};
            //View objects
            mahechaLogo = new Image
            {
                Source = ImageSource.FromResource("mahechabjjlogo.png"),
                Aspect = Aspect.AspectFit
			};
            beltLbl = new Label
            {
                Text = "Belt",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
            beltList = new ObservableCollection<string>();
            beltList.Add("White");
            beltList.Add("Blue");
            beltList.Add("Purple");
            beltList.Add("Brown");
            beltList.Add("Black");
            beltPicker = new Picker
            {
                Title = "Choose Your Rank",
                ItemsSource = beltList
            };
            nameLbl = new Label
            {

#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Name",
                FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
            nameEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Placeholder = "Brian Mahecha",
                FontSize = entrySize
            };
            emailAddressLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "E-Mail Address",
                FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center

            };
            emailAddressEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Placeholder = "admin@Mahechabjj.com",
                FontSize = entrySize
            };
            passWordLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Password",
                FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };
            passWordEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				IsPassword = true,
                FontSize = entrySize
            };
            passWordRepeatLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Re-Enter Password",
                FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };
            passWordRepeatEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				IsPassword = true,
                FontSize = entrySize
            };
            secretQuestionLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize,
                Text = "Secret Questions",
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
            secretQuestionList1 = new ObservableCollection<String>();
            secretQuestionList1.Add("What city were you born in?");
            secretQuestionList1.Add("What city was your high school?");
            secretQuestionList1.Add("Name of favorite instructor.");
            secretQuestionPicker1 = new Picker
            {
                Title = "Select a secret question to answer!",
                ItemsSource = secretQuestionList1
            };
            secretQuestionEntry1 = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize,
                Placeholder = "Answer for your own security!"
			};
            secretQuestionList2 = new ObservableCollection<string>();
            secretQuestionList2.Add("What is your favorite guard?");
            secretQuestionList2.Add("What is your favorite takedown?");
            secretQuestionList2.Add("Federation with best ruleset?");
            secretQuestionPicker2 = new Picker
            {
                Title = "Select another secret question to answer!",
                ItemsSource = secretQuestionList2
            };
            secretQuestionEntry2 = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize,
                Placeholder = "Answer again for even more security!"
			};
            signUpBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Sign Up!",
                FontSize = btnSize,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};
            backBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Back",
                FontSize = btnSize,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};
            clearBtn = new Button
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Clear",
                FontSize = btnSize,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};

            //Events
            signUpBtn.Clicked += Validate;
            backBtn.Clicked += GoBack;
            passWordRepeatEntry.Unfocused += PasswordMatch;
            //TODO add specific validation events to make sure entries are correct.

            innerGrid.Children.Add(mahechaLogo, 0, 0);
            Grid.SetColumnSpan(mahechaLogo, 2);
            innerGrid.Children.Add(nameLbl, 0, 1);
            innerGrid.Children.Add(nameEntry, 0, 2);
            innerGrid.Children.Add(beltLbl, 1, 1);
            innerGrid.Children.Add(beltPicker, 1, 2);
			innerGrid.Children.Add(emailAddressLbl, 0, 3);
            Grid.SetColumnSpan(emailAddressLbl, 2);
			innerGrid.Children.Add(emailAddressEntry, 0, 4);
            Grid.SetColumnSpan(emailAddressEntry, 2);
			innerGrid.Children.Add(passWordLbl, 0, 5);
            Grid.SetColumnSpan(passWordLbl, 2);
			innerGrid.Children.Add(passWordEntry, 0, 6);
            Grid.SetColumnSpan(passWordEntry, 2);
			innerGrid.Children.Add(passWordRepeatLbl, 0, 7);
            Grid.SetColumnSpan(passWordRepeatLbl, 2);
			innerGrid.Children.Add(passWordRepeatEntry, 0, 8);
            Grid.SetColumnSpan(passWordRepeatEntry, 2);
			innerGrid.Children.Add(secretQuestionLbl, 0, 9);
            Grid.SetColumnSpan(secretQuestionLbl, 2);
			innerGrid.Children.Add(secretQuestionPicker1, 0, 10);
			Grid.SetColumnSpan(secretQuestionPicker1, 2);
			innerGrid.Children.Add(secretQuestionEntry1, 0, 11);
            Grid.SetColumnSpan(secretQuestionEntry1, 2);
			innerGrid.Children.Add(secretQuestionPicker2, 0, 12);
			Grid.SetColumnSpan(secretQuestionPicker2, 2);
			innerGrid.Children.Add(secretQuestionEntry2, 0, 13);
            Grid.SetColumnSpan(secretQuestionEntry2, 2);
			innerGrid.Children.Add(signUpBtn, 0, 14);
            innerGrid.Children.Add(backBtn, 1, 14);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

		//functions

        private void Validate(object sender, EventArgs e)
        {
            if (nameEntry.Text != null || emailAddressEntry.Text != null || passWordEntry.Text != null || 
                passWordRepeatEntry.Text != null || secretQuestionEntry1.Text != null || secretQuestionEntry2.Text != null) 
            {
                SignUp(sender, e);
            }
            else {
                DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
            }
        }

        private async void SignUp(object sender, EventArgs e)
        {
            await DisplayAlert("test", emailAddressEntry.Text+nameEntry.Text+passWordEntry.Text, "ok");
            signUpBtn.IsEnabled = false;
            user = await _signUpPageViewModel.CreateUser(nameEntry.Text, emailAddressEntry.Text, passWordEntry.Text, secretQuestionPicker1.SelectedItem.ToString(), 
                                                         secretQuestionEntry1.Text, secretQuestionPicker2.SelectedItem.ToString(), secretQuestionEntry2.Text, beltPicker.SelectedItem.ToString());
            _signUpPageViewModel.SaveCredentials(user.Email, user.password, user.Id);
            account = _baseViewModel.GetAccountInformation();
            await DisplayAlert("account test", account.Username, "Xam Auth works!");
            await DisplayAlert("user info!", user.Id + " " + user.Email, "nice!");
            signUpBtn.IsEnabled = true;
            Application.Current.MainPage = new MainTabbedPage();
        }

        private void PasswordMatch(object sender, EventArgs e)
        {
            if(passWordEntry.Text != passWordRepeatEntry.Text){
                DisplayAlert("Password Mismatch!", "Error! Passwords don't match!", "Ok, I'll fix it!");
                passWordEntry.Text = "";
                passWordRepeatEntry.Text = "";
                passWordEntry.Focus();
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 4);
                innerGrid.Children.Add(nameLbl, 1, 0);
                innerGrid.Children.Add(nameEntry, 2, 0);
                innerGrid.Children.Add(beltLbl, 1, 1);
                innerGrid.Children.Add(beltPicker, 2, 1);
                innerGrid.Children.Add(emailAddressLbl, 1, 2);
                innerGrid.Children.Add(emailAddressEntry, 2, 2);
                innerGrid.Children.Add(passWordLbl, 1, 3);
                innerGrid.Children.Add(passWordEntry, 2, 3);
                innerGrid.Children.Add(passWordRepeatLbl, 1, 4);
                innerGrid.Children.Add(passWordRepeatEntry, 2, 4);
                innerGrid.Children.Add(secretQuestionLbl, 1, 5);
                Grid.SetColumnSpan(secretQuestionLbl, 2);
                innerGrid.Children.Add(secretQuestionPicker1, 0, 6);
                innerGrid.Children.Add(secretQuestionEntry1, 1, 6);
                innerGrid.Children.Add(secretQuestionPicker2, 0, 7);
                innerGrid.Children.Add(secretQuestionEntry2, 1, 7);
                Grid.SetColumnSpan(secretQuestionEntry1, 2);
                Grid.SetColumnSpan(secretQuestionEntry2, 2);
                innerGrid.Children.Add(signUpBtn, 1, 8);
                innerGrid.Children.Add(backBtn, 0, 8);
                innerGrid.Children.Add(clearBtn, 2, 8);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.Children.Add(mahechaLogo, 0, 0);
				Grid.SetColumnSpan(mahechaLogo, 2);
				innerGrid.Children.Add(nameLbl, 0, 1);
				innerGrid.Children.Add(nameEntry, 0, 2);
				innerGrid.Children.Add(beltLbl, 1, 1);
				innerGrid.Children.Add(beltPicker, 1, 2);
				innerGrid.Children.Add(emailAddressLbl, 0, 3);
				Grid.SetColumnSpan(emailAddressLbl, 2);
				innerGrid.Children.Add(emailAddressEntry, 0, 4);
				Grid.SetColumnSpan(emailAddressEntry, 2);
				innerGrid.Children.Add(passWordLbl, 0, 5);
				Grid.SetColumnSpan(passWordLbl, 2);
				innerGrid.Children.Add(passWordEntry, 0, 6);
				Grid.SetColumnSpan(passWordEntry, 2);
				innerGrid.Children.Add(passWordRepeatLbl, 0, 7);
				Grid.SetColumnSpan(passWordRepeatLbl, 2);
				innerGrid.Children.Add(passWordRepeatEntry, 0, 8);
				Grid.SetColumnSpan(passWordRepeatEntry, 2);
				innerGrid.Children.Add(secretQuestionLbl, 0, 9);
				Grid.SetColumnSpan(secretQuestionLbl, 2);
				innerGrid.Children.Add(secretQuestionPicker1, 0, 10);
				Grid.SetColumnSpan(secretQuestionPicker1, 2);
				innerGrid.Children.Add(secretQuestionEntry1, 0, 11);
				Grid.SetColumnSpan(secretQuestionEntry1, 2);
				innerGrid.Children.Add(secretQuestionPicker2, 0, 12);
				Grid.SetColumnSpan(secretQuestionPicker2, 2);
				innerGrid.Children.Add(secretQuestionEntry2, 0, 13);
				Grid.SetColumnSpan(secretQuestionEntry2, 2);
				innerGrid.Children.Add(signUpBtn, 0, 14);
				innerGrid.Children.Add(backBtn, 1, 14);
			}
		}
    }
}

