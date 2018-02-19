using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MahechaBJJ.Droid;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.CommonPages;
using MahechaBJJ.Views.EntryPages;
using MahechaBJJ.Views.SignUpPages;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

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
        private Button loginBtn;
        private Button settingsBtn;
        private Account account;
        private User user;
        private Label timeOutLbl;
        private Frame timeOutFrame;
        private TapGestureRecognizer timeOutTap;
        private ActivityIndicator activityIndicator;
        private StackLayout userCredentialStack;
        private Button createAccountBtn;
        private bool hasAccount;
#if __ANDROID__
        private Android.Widget.TextView androidNameLbl;
        private Android.Widget.TextView androidEmailLbl;
        private Android.Widget.TextView androidBeltLbl;
        private Android.Widget.Button androidPackageBtn;
        private Android.Widget.Button androidContactUsBtn;
        private Android.Widget.Button androidLogOutBtn;
        private Android.Widget.Button androidLoginBtn;
        private Android.Widget.Button androidSettingsBtn;
        private Android.Widget.Button androidCreateAccountBtn;
        private ContentView contentViewNameLbl;
        private ContentView contentViewEmailLbl;
        private ContentView contentViewBeltLbl;

#endif

        public ProfilePage(bool hasAccount)
        {
            _baseViewModel = new BaseViewModel();
            this.hasAccount = hasAccount;

#if __IOS__
            Icon = "karate.png";
            Title = "Profile";
            Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
            Icon = "karate.png";
            Padding = new Thickness(5, 5, 5, 5);
#endif
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
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
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
                FontSize = size * 1.5,
                HorizontalTextAlignment = TextAlignment.Center,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                HorizontalTextAlignment = TextAlignment.Start,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            nameTextLbl = new Label
            {
                Text = "Jon",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size * .5,
#endif
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
                FontSize = size * 1.5,
                HorizontalTextAlignment = TextAlignment.Center,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                HorizontalTextAlignment = TextAlignment.Start,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            emailTextLbl = new Label
            {
                Text = "Doe",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size * .5,
#endif
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
                FontSize = size * 1.5,
                HorizontalTextAlignment = TextAlignment.Center,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                HorizontalTextAlignment = TextAlignment.Start,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            beltTextLbl = new Label
            {
                Text = "White",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size * .5,
#endif
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
                FontSize = size * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
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
                FontSize = size * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
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
                FontSize = size * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };

            loginBtn = new Button();
            loginBtn.Text = "Login";
#if __IOS__
            loginBtn.FontFamily = "AmericanTypewriter-Bold";
            loginBtn.FontSize = size * 2;
#endif
            loginBtn.BackgroundColor = Color.FromRgb(58, 93, 174);
            loginBtn.TextColor = Color.Black;
            loginBtn.BorderWidth = 3;
            loginBtn.BorderColor = Color.Black;
            loginBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushModalAsync(new LoginPage());
            };

            settingsBtn = new Button
            {
                Text = "Settings",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
            };

            createAccountBtn = new Button();
            createAccountBtn.Text = "Create Account";
            createAccountBtn.BorderWidth = 3;
            createAccountBtn.BorderColor = Color.Black;
            createAccountBtn.FontFamily = "AmericanTypewriter-Bold";
            createAccountBtn.FontSize = btnSize * 2;
            createAccountBtn.BackgroundColor = Color.FromRgb(58, 93, 174);
            createAccountBtn.TextColor = Color.Black;
            createAccountBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushModalAsync(new SignUpPage());
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

#if __ANDROID__
            androidNameLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidNameLbl.Text = "Name:";
            androidNameLbl.SetTextColor(Android.Graphics.Color.Black);
            androidNameLbl.Gravity = Android.Views.GravityFlags.Start;
            androidNameLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            //androidNameLbl.SetTypeface(androidNameLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidEmailLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidEmailLbl.Text = "Email:";
            androidEmailLbl.SetTextColor(Android.Graphics.Color.Black);
            androidEmailLbl.Gravity = Android.Views.GravityFlags.Start;
            androidEmailLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            //androidEmailLbl.SetTypeface(androidNameLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidBeltLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidBeltLbl.Text = "Belt:";
            androidBeltLbl.SetTextColor(Android.Graphics.Color.Black);
            androidBeltLbl.Gravity = Android.Views.GravityFlags.Start;
            androidBeltLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            //androidBeltLbl.SetTypeface(androidNameLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidPackageBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidPackageBtn.Text = "Packages";
            androidPackageBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidPackageBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidPackageBtn.SetTextColor(Android.Graphics.Color.Black);
            androidPackageBtn.Gravity = Android.Views.GravityFlags.Center;
            androidPackageBtn.SetAllCaps(false);
            androidPackageBtn.Click += (object sender, EventArgs e) => {
                SetPackages();
            };

            androidContactUsBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidContactUsBtn.Text = "Contact Us";
            androidContactUsBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidContactUsBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidContactUsBtn.SetTextColor(Android.Graphics.Color.Black);
            androidContactUsBtn.Gravity = Android.Views.GravityFlags.Center;
            androidContactUsBtn.SetAllCaps(false);
            androidContactUsBtn.Click += (object sender, EventArgs e) => {
                ContactUs();
            };

            androidLogOutBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidLogOutBtn.Text = "Log Out";
            androidLogOutBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidLogOutBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidLogOutBtn.SetTextColor(Android.Graphics.Color.Black);
            androidLogOutBtn.Gravity = Android.Views.GravityFlags.Center;
            androidLogOutBtn.SetAllCaps(false);
            androidLogOutBtn.Click += async (object sender, EventArgs e) => {
                await LogOutClick();
            };

            androidLoginBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidLoginBtn.Text = "Login";
            androidLoginBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidLoginBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidLoginBtn.SetTextColor(Android.Graphics.Color.Black);
            androidLoginBtn.Gravity = Android.Views.GravityFlags.Center;
            androidLoginBtn.SetAllCaps(false);
            androidLoginBtn.Click += (sender, e) => {
                Navigation.PushModalAsync(new LoginPage());
            };

            androidSettingsBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidSettingsBtn.Text = "Settings";
            androidSettingsBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidSettingsBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidSettingsBtn.SetTextColor(Android.Graphics.Color.Black);
            androidSettingsBtn.Gravity = Android.Views.GravityFlags.Center;
            androidSettingsBtn.SetAllCaps(false);
            androidSettingsBtn.Click += async (object sender, EventArgs e) => {
                await Settings();
            };

            androidCreateAccountBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidCreateAccountBtn.Text = "Create Account";
            androidCreateAccountBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidCreateAccountBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidCreateAccountBtn.SetTextColor(Android.Graphics.Color.Black);
            androidCreateAccountBtn.Gravity = Android.Views.GravityFlags.Center;
            androidCreateAccountBtn.SetAllCaps(false);
            androidCreateAccountBtn.Click += (object sender, EventArgs e) => {
                Navigation.PushModalAsync(new SignUpPage());
            };

            contentViewNameLbl = new ContentView();
            contentViewNameLbl.Content = androidNameLbl.ToView();

            contentViewEmailLbl = new ContentView();
            contentViewEmailLbl.Content = androidEmailLbl.ToView();

            contentViewBeltLbl = new ContentView();
            contentViewBeltLbl.Content = androidBeltLbl.ToView();
#endif

            //Events
            packageBtn.Clicked += (object sender, EventArgs e) =>
            {
                SetPackages();
            };
            contactUsBtn.Clicked += (sender, e) =>
            {
                ContactUs();
            };
            logOutBtn.Clicked += async (sender, e) =>
            {
                await LogOutClick();
            };
            settingsBtn.Clicked += async (sender, e) =>
            {
                await Settings();
            };

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public async void SetContent()
        {
            account = _baseViewModel.GetAccountInformation();

            //add activity indicator while contents load
            if (hasAccount)
            {
                innerGrid.Children.Clear();
                activityIndicator.IsRunning = true;
                innerGrid.Children.Add(activityIndicator, 0, 0);
                Grid.SetRowSpan(activityIndicator, 6);
                Grid.SetColumnSpan(activityIndicator, 3);

                if (_baseViewModel.User == null)
                {
                    try
                    {
                        user = await _baseViewModel.FindUserByIdAsync(Constants.FINDUSER, account.Properties["Id"]);
                    }
                    catch (KeyNotFoundException ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        await DisplayAlert("Unknown Error", "There has been an unknown error, please sign in again.", "Ok");
                        LogOut();
                    }
                }
                if (_baseViewModel.Successful)
                {
                    activityIndicator.IsRunning = false;
#if __IOS__
                    nameTextLbl.Text = user.Name;
                    emailTextLbl.Text = user.Email;
                    beltTextLbl.Text = user.Belt;

                    userCredentialStack.Children.Add(nameLbl);
                    userCredentialStack.Children.Add(nameTextLbl);
                    userCredentialStack.Children.Add(beltLbl);
                    userCredentialStack.Children.Add(beltTextLbl);
                    userCredentialStack.Children.Add(emailLbl);
                    userCredentialStack.Children.Add(emailTextLbl);

                    //Building Grid
                    innerGrid.Children.Clear();
                    innerGrid.Children.Add(userCredentialStack, 0, 0);
                    Grid.SetRowSpan(userCredentialStack, 3);
                    innerGrid.Children.Add(packageBtn, 0, 3);
                    innerGrid.Children.Add(contactUsBtn, 0, 4);
                    innerGrid.Children.Add(settingsBtn, 0, 5);
                    innerGrid.Children.Add(logOutBtn, 0, 6);
#endif
#if __ANDROID__
                    androidNameLbl.Text = $"{androidNameLbl.Text} {user.Name}";
                    androidEmailLbl.Text = $"{androidEmailLbl.Text} {user.Email}";
                    androidBeltLbl.Text = $"{androidBeltLbl.Text} {user.Belt}";
                    userCredentialStack.Children.Add(contentViewNameLbl);
                    userCredentialStack.Children.Add(contentViewEmailLbl);
                    userCredentialStack.Children.Add(contentViewBeltLbl);

                    //Building Grid
                    innerGrid.Children.Clear();
                    //innerGrid.Children.Add(userCredentialStack, 0, 0);
                    innerGrid.Children.Add(contentViewNameLbl, 0, 0);
                    innerGrid.Children.Add(contentViewEmailLbl, 0, 1);
                    innerGrid.Children.Add(contentViewBeltLbl, 0, 2);
                    //Grid.SetRowSpan(userCredentialStack, 3);
                    innerGrid.Children.Add(androidPackageBtn.ToView(), 0, 3);
                    innerGrid.Children.Add(androidContactUsBtn.ToView(), 0, 4);
                    innerGrid.Children.Add(androidSettingsBtn.ToView(), 0, 5);
                    innerGrid.Children.Add(androidLogOutBtn.ToView(), 0, 6);
#endif
                }
                else
                {
                    LogOut();
                }
            }
            else
            {
#if __ANDROID__
                //Building Grid
                innerGrid.Children.Clear();
                innerGrid.Children.Add(androidPackageBtn.ToView(), 0, 1);
                innerGrid.Children.Add(androidContactUsBtn.ToView(), 0, 3);
                innerGrid.Children.Add(androidLoginBtn.ToView(), 0, 4);
                innerGrid.Children.Add(androidCreateAccountBtn.ToView(), 0, 5);
#endif
#if __IOS__
                innerGrid.Children.Clear();
                innerGrid.Children.Add(packageBtn, 0, 1);
                innerGrid.Children.Add(contactUsBtn, 0, 3);
                innerGrid.Children.Add(loginBtn, 0, 4);
                innerGrid.Children.Add(createAccountBtn, 0, 5);
#endif
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

            if (account.Properties["Package"].Equals("GiAndNoGi"))
            {
                DisplayAlert("No Packages", "No more packages are available for you to purchase.", "Ok");
                return;
            }
            else if (account.Properties["Package"].Equals("Gi"))
            {
                Navigation.PushModalAsync(new PurchasePage(Package.NoGi));
            }
            else
            {
                Navigation.PushModalAsync(new PurchasePage(Package.Gi));
            }
        }

        private async Task LogOutClick()
        {
            bool logout = await DisplayAlert("Logout", "Are you sure you want to log out " + user.Email + "?", "Yes, I'll be back friend.", "No, I'll stay!");
            if (logout)
            {
                LogOut();
            }
        }

        private void ContactUs()
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
        }

        private async Task Settings() 
        {
            string[] settings = { "Change Password" };
            string settingSelection = await DisplayActionSheet("Settings", "Cancel", null, settings);
            if (settingSelection.Equals("Change Password"))
            {
                await Navigation.PushModalAsync(new ChangePasswordPage(user));
            }
        }
    }
}

