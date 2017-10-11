﻿using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.EntryPages;
using Xamarin.Forms;
using Xamarin.Auth;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace MahechaBJJ.Views.EntryPages
{
    public class SignUpPage : ContentPage
    {
        //ViewModel
        private SignUpPageViewModel _signUpPageViewModel;
        private BaseViewModel _baseViewModel;
        //declare objects
        private StackLayout lblLayout;
        private StackLayout entryLayout;
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
        private TableView tableView;
        private StackLayout stackLayout;
        private StackLayout buttonLayout;
        private Grid buttonGrid;
		//Xam Auth
		Account account;

        public SignUpPage()
        {
            _signUpPageViewModel = new SignUpPageViewModel();
            _baseViewModel = new BaseViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            SetContent();
        }

		//functions
        private void SetContent()
        {
			user = new User();
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));            
			
			//View objects
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				FontSize = entrySize,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand

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
				FontSize = entrySize,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				FontSize = entrySize,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				FontSize = entrySize,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				Placeholder = "Answer for your own security!",
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				Placeholder = "Answer again for even more security!",
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				FontSize = btnSize * 1.5,
				BackgroundColor = Color.FromRgb(58, 93, 174),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
				FontSize = btnSize * 1.5,
				BackgroundColor = Color.FromRgb(124, 37, 41),
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
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
                BackgroundColor = Color.Red,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};

			//Events
			signUpBtn.Clicked += Validate;
			backBtn.Clicked += GoBack;
			passWordRepeatEntry.Unfocused += PasswordMatch;
			//TODO add specific validation events to make sure entries are correct.

            tableView = new TableView();
            tableView.Intent = TableIntent.Form;
            tableView.BackgroundColor = Color.White;
            tableView.Root = new TableRoot()
            {
                new TableSection() {
                    new ViewCell {
                        View = nameLbl
                    },
                    new ViewCell {
                        View = nameEntry
                    },
                    new ViewCell {
                        View = emailAddressLbl
                    },
                    new ViewCell {
                        View = emailAddressEntry
                    },
                    new ViewCell {
                        View = beltLbl
                    },
                    new ViewCell {
                        View = beltPicker
                    },
                    new ViewCell {
                        View = passWordLbl
                    },
                    new ViewCell {
                        View = passWordEntry
                    },
                    new ViewCell {
                        View = passWordRepeatLbl
                    },
                    new ViewCell {
                        View = passWordRepeatEntry
                    },
                    new ViewCell {
                        View = secretQuestionLbl
                    },
                    new ViewCell {
                        View = secretQuestionPicker1
                    },
                    new ViewCell {
                        View = secretQuestionEntry1
                    },
                    new ViewCell {
                        View = secretQuestionPicker2
                    },
                    new ViewCell {
                        View = secretQuestionEntry2
                    }
                }
            };
            buttonLayout = new StackLayout();
            buttonLayout.Children.Add(backBtn);
            buttonLayout.Children.Add(signUpBtn);
            buttonLayout.Orientation = StackOrientation.Horizontal;
            buttonGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				},
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(signUpBtn, 1, 0);
            ScrollView scrollView = new ScrollView();
            stackLayout = new StackLayout
            {
                Children = {
                    tableView,
                    buttonGrid
                }
            };
            scrollView.Content = stackLayout;
            Content = stackLayout;
        }

        private void Validate(object sender, EventArgs e)
        {
            signUpBtn.IsEnabled = false;
            if (nameEntry.Text != null || emailAddressEntry.Text != null || passWordEntry.Text != null || 
                passWordRepeatEntry.Text != null || secretQuestionEntry1.Text != null || secretQuestionEntry2.Text != null) 
            {
                SignUp(sender, e);
            }
            else {
                DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
            }
            signUpBtn.IsEnabled = true;
        }

        private async void SignUp(object sender, EventArgs e)
        {
            await DisplayAlert("test", emailAddressEntry.Text+nameEntry.Text+passWordEntry.Text, "ok");
            signUpBtn.IsEnabled = false;
            user = await _signUpPageViewModel.CreateUser(nameEntry.Text, emailAddressEntry.Text, passWordEntry.Text, secretQuestionPicker1.SelectedItem.ToString(), 
                                                         secretQuestionEntry1.Text, secretQuestionPicker2.SelectedItem.ToString(), secretQuestionEntry2.Text, beltPicker.SelectedItem.ToString());
            _signUpPageViewModel.SaveCredentials(user.Email, user.password, user.Id);
            account = _baseViewModel.GetAccountInformation();
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
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
        }
		
		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
                Padding = new Thickness(10, 10, 10, 0);
                backBtn.FontSize = btnSize;
                signUpBtn.FontSize = btnSize;
                stackLayout.Spacing = 0;
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
                backBtn.FontSize = btnSize * 1.5;
                signUpBtn.FontSize = btnSize * 1.5;
			}
		}
    }
}

