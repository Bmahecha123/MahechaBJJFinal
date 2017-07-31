﻿using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class SignUpPage : ContentPage
    {
        //declare objects
        private Grid innerGrid;
        private Grid outerGrid;
        private Image mahechaLogo;
        private Label nameLbl;
        private Entry nameEntry;
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

        public SignUpPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            user = new User();
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			//Grid view definition
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
            nameLbl = new Label
            {

#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Name",
                FontSize = size
			};
            nameEntry = new Entry
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Placeholder = "Brian Mahecha",
                FontSize = size
            };
            emailAddressLbl = new Label
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "E-Mail Address",
                FontSize = size

            };
            emailAddressEntry = new Entry
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Placeholder = "admin@Mahechabjj.com",
                FontSize = size
            };
            passWordLbl = new Label
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Password",
                FontSize = size
            };
            passWordEntry = new Entry
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                IsPassword = true,
                FontSize = size
            };
            passWordRepeatLbl = new Label
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Re-Enter Password",
                FontSize = size
            };
            passWordRepeatEntry = new Entry
            {
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                IsPassword = true,
                FontSize = size
            };
            secretQuestionLbl = new Label
            {
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                Text = "Secret Questions"
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
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                Placeholder = "Answer for your own security!"
			};
            secretQuestionList2 = new ObservableCollection<string>();
            secretQuestionList2.Add("What is your favorite guard in Jiu Jitsu?");
            secretQuestionList2.Add("What is your favorite takedown in Jiu Jitsu?");
            secretQuestionList2.Add("Which federation has your favorite ruleset?");
            secretQuestionPicker2 = new Picker
            {
                Title = "Select another secret question to answer!",
                ItemsSource = secretQuestionList2
            };
            secretQuestionEntry2 = new Entry
            {
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                Placeholder = "Answer again for even more security!"
			};
            signUpBtn = new Button
            {
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Sign Up!",
                FontSize = size
			};
            backBtn = new Button
            {
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Back",
                FontSize = size
			};
            clearBtn = new Button
            {
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Clear",
                FontSize = size
			};

            //Events
            signUpBtn.Clicked += test;
            backBtn.Clicked += GoBack;
            passWordRepeatEntry.Unfocused += PasswordMatch;

            innerGrid.Children.Add(mahechaLogo, 0, 0);
            Grid.SetColumnSpan(mahechaLogo, 2);
            innerGrid.Children.Add(nameLbl, 0, 1);
            Grid.SetColumnSpan(nameLbl, 2);
            innerGrid.Children.Add(nameEntry, 0, 2);
            Grid.SetColumnSpan(nameEntry, 2);
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

        private async void test(object sender, EventArgs e)
        {
            signUpBtn.IsEnabled = false;
            //user = new User(nameEntry.Text, );
            await DisplayAlert("user info!", nameEntry.Text, "nice!");
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
		/*private async void CallVimeoApi(object sender, EventArgs e)
		{
			string url = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
			await _signInPageViewModel.GetVimeo(url);
            SetPageContent(_signInPageViewModel.VimeoInfo, user);
		}

		private void SetPageContent(BaseInfo Output, User user)
		{
            Navigation.PushModalAsync(new MainTabbedPage(Output, user));
		}*/

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
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 4);
                innerGrid.Children.Add(nameLbl, 1, 0);
                innerGrid.Children.Add(nameEntry, 2, 0);
                innerGrid.Children.Add(emailAddressLbl, 1, 1);
                innerGrid.Children.Add(emailAddressEntry, 2, 1);
                innerGrid.Children.Add(passWordLbl, 1, 2);
                innerGrid.Children.Add(passWordEntry, 2, 2);
                innerGrid.Children.Add(passWordRepeatLbl, 1, 3);
                innerGrid.Children.Add(passWordRepeatEntry, 2, 3);
                innerGrid.Children.Add(secretQuestionLbl, 1, 4);
                Grid.SetColumnSpan(secretQuestionLbl, 2);
                innerGrid.Children.Add(secretQuestionPicker1, 0, 5);
                innerGrid.Children.Add(secretQuestionEntry1, 1, 5);
                innerGrid.Children.Add(secretQuestionPicker2, 0, 6);
                innerGrid.Children.Add(secretQuestionEntry2, 1, 6);
                Grid.SetColumnSpan(secretQuestionEntry1, 2);
                Grid.SetColumnSpan(secretQuestionEntry2, 2);
                innerGrid.Children.Add(signUpBtn, 0, 7);
                innerGrid.Children.Add(backBtn, 1, 7);
                innerGrid.Children.Add(clearBtn, 2, 7);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				innerGrid.Children.Add(mahechaLogo, 0, 0);
				Grid.SetColumnSpan(mahechaLogo, 2);
				innerGrid.Children.Add(nameLbl, 0, 1);
				Grid.SetColumnSpan(nameLbl, 2);
				innerGrid.Children.Add(nameEntry, 0, 2);
				Grid.SetColumnSpan(nameEntry, 2);
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

