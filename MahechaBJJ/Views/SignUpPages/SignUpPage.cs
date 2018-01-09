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
using MahechaBJJ.Views.SignUpPages;

namespace MahechaBJJ.Views.SignUpPages
{
    public class SignUpPage : ContentPage
    {
        //ViewModel
        private BaseViewModel _baseViewModel;
        //declare objects
        private Package package;
        private Label nameLbl;
        private Entry nameEntry;
        private Label beltLbl;
        private Picker beltPicker;
        private ObservableCollection<string> beltList;
        private Label emailAddressLbl;
        private Entry emailAddressEntry;
        private Label passWordLbl;
        private Entry passWordEntry;
        private Label secretQuestionLbl;
        private Picker secretQuestionPicker;
        private Entry secretQuestionEntry;
        private Button nextBtn;
        private Button backBtn;
        private Button clearBtn;
        private User user;
        private ObservableCollection<string> secretQuestionList;
        private TableView tableView;
        private StackLayout stackLayout;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid buttonGrid;

        public SignUpPage(Package package)
        {
            //_signUpPageViewModel = new SignUpPageViewModel();
            _baseViewModel = new BaseViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            this.package = package;
            SetContent();
        }

		//functions
        private void SetContent()
        {
			
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
				FontSize = lblSize * 1.5,
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
				FontSize = lblSize * 1.5,
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
				FontSize = lblSize * 1.5,
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
				FontSize = lblSize * 1.5,
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
			secretQuestionLbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize * 1.5,
				Text = "Secret Questions",
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			secretQuestionList = new ObservableCollection<String>();
			secretQuestionList.Add("What city were you born in?");
			secretQuestionList.Add("What city was your high school?");
			secretQuestionList.Add("Name of favorite instructor.");
			secretQuestionPicker = new Picker
			{
				Title = "Select a secret question to answer!",
				ItemsSource = secretQuestionList
			};
			secretQuestionEntry = new Entry
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
			nextBtn = new Button
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Next",
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
            nextBtn.Clicked += (object sender, EventArgs e) => {
                Validate();
            };
			backBtn.Clicked += GoBack;
			//passWordRepeatEntry.Unfocused += PasswordMatch;
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
                        View = secretQuestionLbl
                    },
                    new ViewCell {
                        View = secretQuestionPicker
                    },
                    new ViewCell {
                        View = secretQuestionEntry
                    }
                }
            };
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
            buttonGrid.Children.Add(nextBtn, 1, 0);
            ScrollView scrollView = new ScrollView();
            stackLayout = new StackLayout
            {
                Children = {
                    tableView
                }
            };
            scrollView.Content = stackLayout;

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(9, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
            innerGrid.Children.Add(scrollView, 0, 0);
            innerGrid.Children.Add(buttonGrid, 0, 1);
            outerGrid.Children.Add(innerGrid);
            Content = outerGrid;
        }

        private void Validate()
        {
            ToggleButtons();
            if (nameEntry.Text != null || emailAddressEntry.Text != null || passWordEntry.Text != null 
                || secretQuestionEntry.Text != null) 
            {
                CreateUser();
                Navigation.PushModalAsync(new SummaryPage(user));
            }
            else {
                DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
            }
            ToggleButtons();
        }

        private void GoBack(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PopModalAsync();
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            nextBtn.IsEnabled = !nextBtn.IsEnabled;
        }

        private void CreateUser() 
        {
            user = new User();
            user.Name = nameEntry.Text;
            user.Email = emailAddressEntry.Text;
            Packages packages = new Packages();
            if (package == Package.Gi) 
            {
                packages.GiJiuJitsu = true;
            }
            else if (package == Package.NoGi)
            { 
                packages.NoGiJiuJitsu = true;
            }
            else
            {
                packages.GiAndNoGiJiuJitsu = true;
            }
            user.Packages = packages;
            user.Password = passWordEntry.Text;
            user.SecretQuestion = secretQuestionPicker.SelectedItem.ToString();
            user.SecretQuestionAnswer = secretQuestionEntry.Text.ToLower();
            user.Belt = beltPicker.SelectedItem.ToString();
        }
		
		//Orientation
		/*protected override void OnSizeAllocated(double width, double height)
		{
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
                Padding = new Thickness(10, 10, 10, 0);
                backBtn.FontSize = btnSize;
                nextBtn.FontSize = btnSize;
                stackLayout.Spacing = 0;
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
                backBtn.FontSize = btnSize * 1.5;
                nextBtn.FontSize = btnSize * 1.5;
			}
		}*/
    }
}

