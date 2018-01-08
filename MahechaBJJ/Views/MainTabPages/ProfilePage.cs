using System;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.CommonPages;
using MahechaBJJ.Views.EntryPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class ProfilePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private Grid outerGrid;
        private Grid innerGrid;
        private Label nameLbl;
        private Label nameTextLbl;
        private Label emailLbl;
        private Label emailTextLbl;
        private Label beltLbl;
        private Label beltTextLbl;
        private Button packageBtn;
        private Button contactUsBtn;
        private Button logOutBtn;
        private Button settingsBtn;
        private Account account;
        private User user;
        private Label timeOutLbl;
        private Frame timeOutFrame;
        private TapGestureRecognizer timeOutTap;
        private ActivityIndicator activityIndicator;
        private StackLayout userCredentialStack;

        public ProfilePage()
        {
            _baseViewModel = new BaseViewModel();
            account = _baseViewModel.GetAccountInformation();

            Title = "Profile";
#if __IOS__
            Icon = "karate.png";
#endif
#if __ANDROID__
            Icon = "karate.png";
#endif
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
            SetContent();
        }

        //functions
        public void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            userCredentialStack = new StackLayout();

            //load User
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            //grid definiton

            nameLbl = new Label
            {
                Text = "Name",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            nameTextLbl = new Label
            {
                Text = "Jon",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            emailLbl = new Label
            {
                Text = "E-Mail",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            emailTextLbl = new Label
            {
                Text = "Doe",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                LineBreakMode = LineBreakMode.TailTruncation,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
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
                FontSize = size * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            beltTextLbl = new Label
            {
                Text = "White",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            packageBtn = new Button
            {
                Text = "Packages",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };
            contactUsBtn = new Button
            {
                Text = "Contact Us",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };
            logOutBtn = new Button
            {
                Text = "Log Out",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };
            settingsBtn = new Button
            {
                Text = "Settings",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };
            timeOutLbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Network Has Timed Out! \n Click To Try Again!",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.White
            };
            timeOutFrame = new Frame
            {
                Content = timeOutLbl,
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            timeOutTap = new TapGestureRecognizer();
            timeOutTap.Tapped += (sender, e) =>
            {
                SetContent();
            };
            timeOutLbl.GestureRecognizers.Add(timeOutTap);
            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                IsEnabled = true,
                IsVisible = true
            };

            //Events
            packageBtn.Clicked += (object sender, EventArgs e) => {
                SetPackages();
            };
            contactUsBtn.Clicked += (sender, e) =>
            {
                contactUsBtn.IsEnabled = false;
                var emailMessage = new EmailMessage();
                emailMessage.Subject = "Mahecha BJJ - <Insert Subject Here>";
#if __IOS__
                MessagingCenter.Send(this, "Send EMail", emailMessage);
#endif
#if __ANDROID__
                Xamarin.Forms.DependencyService.Register<IEmailService>();
                DependencyService.Get<IEmailService>().StartEmailActivity(emailMessage);
#endif
                contactUsBtn.IsEnabled = true;
			};
			logOutBtn.Clicked += async (sender, e) =>
			{
				bool logout = await DisplayAlert("Logout", "Are you sure you want to log out " + user.Email + "?", "Yes, I'll be back friend.", "No, I'll stay!");
				if (logout)
				{
                    LogOut();
				}
			};
            settingsBtn.Clicked += async (sender, e) =>
            {
                string[] settings = { "Change Password" };
                string settingSelection = await DisplayActionSheet("Settings", "Cancel", null, settings);
                if (settingSelection.Equals("Change Password"))
                {
                    await Navigation.PushModalAsync(new ChangePasswordPage(user));
                }
            };

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        public async void SetContent()
        {
            //add activity indicator while contents load
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 6);
            Grid.SetColumnSpan(activityIndicator, 3);

            if (_baseViewModel.User == null)
            {
				user = await _baseViewModel.FindUserByIdAsync(Constants.FINDUSER, account.Properties["Id"]);
			}
            if (_baseViewModel.Successful)
            {
                activityIndicator.IsRunning = false;
				nameTextLbl.Text = user.Name;
				emailTextLbl.Text = user.Email;
				beltTextLbl.Text = user.Belt;
                //Building Stack
                userCredentialStack.Children.Add(nameLbl);
                userCredentialStack.Children.Add(nameTextLbl);
                userCredentialStack.Children.Add(beltLbl);
                userCredentialStack.Children.Add(beltTextLbl);
                userCredentialStack.Children.Add(emailLbl);
                userCredentialStack.Children.Add(emailTextLbl);
                //Building Grid
                innerGrid.Children.Clear();
                innerGrid.Children.Add(userCredentialStack, 0, 0);
                innerGrid.Children.Add(packageBtn, 0, 1);
				innerGrid.Children.Add(contactUsBtn, 0, 2);
				innerGrid.Children.Add(settingsBtn, 0, 3);
				innerGrid.Children.Add(logOutBtn, 0, 4);
            } else {
				/*innerGrid.Children.Clear();
				innerGrid.Children.Add(timeOutFrame, 0, 0);
				Grid.SetRowSpan(timeOutFrame, 4);
				Grid.SetRowSpan(timeOutLbl, 4); */
                LogOut();
            }

		}

        private void LogOut()
        {
            _baseViewModel.DeleteCredentials();
            var entryPage = new NavigationPage(new EntryPage());
            NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
            Application.Current.MainPage = entryPage;
        }

        private void SetPackages()
        {
            account = _baseViewModel.GetAccountInformation();

            if (account.Properties["Package"].Contains("GiAndNoGi"))
            {
                DisplayAlert("No Packages", "No more packages are available for you to purchase.", "Ok");
                return;
            }
            else if (account.Properties["Package"].Contains("Gi"))
            {
                string[] packages = { "NoGi" };
                Navigation.PushModalAsync(new PurchasePage(Package.Gi));
            } 
            else 
            {
                string[] packages = { "Gi" };
                Navigation.PushModalAsync(new PurchasePage(Package.NoGi));
            }
        }

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                if (_baseViewModel.User != null)
                {
                    Padding = new Thickness(10, 10, 10, 10);
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    //Layout Options
                    //Building Grid
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(userCredentialStack, 0, 0);
                    Grid.SetRowSpan(userCredentialStack, 4);
                    innerGrid.Children.Add(packageBtn, 1, 0);
                    innerGrid.Children.Add(contactUsBtn, 1, 1);
                    innerGrid.Children.Add(settingsBtn, 1, 2);
                    innerGrid.Children.Add(logOutBtn, 1, 3);
                }
            }
            else
            {
                if (_baseViewModel.User != null)
                {
                    Padding = new Thickness(10, 30, 10, 10);
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    //Building Grid
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(userCredentialStack, 0, 0);
                    innerGrid.Children.Add(packageBtn, 0, 1);
                    innerGrid.Children.Add(contactUsBtn, 0, 2);
                    innerGrid.Children.Add(settingsBtn, 0, 3);
                    innerGrid.Children.Add(logOutBtn, 0, 4);
                }
            }
        }
	}
}

