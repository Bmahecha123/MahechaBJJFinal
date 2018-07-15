using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Forms;
#if __ANDROID__
using MahechaBJJ.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using Android.Text.Method;
#endif

namespace MahechaBJJ.Views.EntryPages
{
    public class LoginPage : ContentPage
    {
        private readonly BaseViewModel _baseViewModel;

        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Grid buttonGrid;
        private Image mahechaLogo;
        private Label emailLbl;
        private Image emailImg;
        private Entry emailEntry;
        private Label passwordLbl;
        private Image passwordImg;
        private Entry passwordEntry;
        private Button loginBtn;
        private Button backBtn;
        private Button forgotPasswordBtn;
        private User user;
        private ScrollView scrollView;
        private StackLayout stackLayout;
        private StackLayout innerStackLayout;
        private StackLayout buttonLayout;
        private StackLayout emailLayout;
        private StackLayout passwordLayout;
        private Package package;
#if __ANDROID__
        private Android.Widget.Button androidLoginBtn;
        private Android.Widget.Button androidForgotPasswordBtn;
        private Android.Widget.EditText androidEmailEntry;
        private Android.Widget.EditText androidPasswordEntry;

#endif


        public LoginPage()
        {
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Color.FromHex("#F1ECCE");

#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 10, 10, 10);
#endif
            BuildPageObjects();
        }

        //functions
        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            scrollView = new ScrollView();
            stackLayout = new StackLayout();
            buttonLayout = new StackLayout();
            emailLayout = new StackLayout();
            passwordLayout = new StackLayout();
            innerStackLayout = new StackLayout();
            innerStackLayout.Spacing = 50;
            //View objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition {Height = new GridLength(4, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            buttonGrid = new Grid
            {
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition {Width = new GridLength(3, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                }
            };
            mahechaLogo = new Image
            {
                Source = ImageSource.FromResource("mahechabjjlogo.png"),
                Aspect = Aspect.AspectFit
            };
            emailImg = new Image
            {
                Source = "mail.png",
                Aspect = Aspect.AspectFit
            };
            emailLbl = new Label
            {
                Text = "E-Mail Address",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            emailEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Placeholder = "E-Mail Address",
#endif
                FontSize = entrySize,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            passwordImg = new Image
            {
                Source = "password.png",
                Aspect = Aspect.AspectFit
            };
            passwordLbl = new Label
            {
                Text = "Password",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            passwordEntry = new Entry
            {
                IsPassword = true,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Placeholder = "Password",
#endif
                FontSize = entrySize,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            loginBtn = new Button
            {
                Text = "Login",
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
                Style = (Style)Application.Current.Resources["common-blue-btn"],
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            backBtn = new Button
            {
                Image = "back.png",
                Style = (Style)Application.Current.Resources["common-red-btn"],
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            forgotPasswordBtn = new Button
            {
                Image= "forgotpassword.png",
                Style = (Style)Application.Current.Resources["common-blue-btn"],
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            var pdTwo = new PaintDrawable(Android.Graphics.Color.Rgb(124, 37, 41));
            pdTwo.SetCornerRadius(100);

            androidLoginBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidLoginBtn.Text = "Login";
            androidLoginBtn.Typeface = Constants.COMMONFONT;
            androidLoginBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidLoginBtn.SetBackground(pd);
            androidLoginBtn.SetTextColor(Android.Graphics.Color.Black);
            androidLoginBtn.Gravity = Android.Views.GravityFlags.Center;
            androidLoginBtn.SetAllCaps(false);

            androidForgotPasswordBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidForgotPasswordBtn.Text = "?";
            androidForgotPasswordBtn.Typeface = Constants.COMMONFONT;
            androidForgotPasswordBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidForgotPasswordBtn.SetBackground(pdTwo);
            androidForgotPasswordBtn.SetTextColor(Android.Graphics.Color.Black);
            androidForgotPasswordBtn.Gravity = Android.Views.GravityFlags.Center;
            androidForgotPasswordBtn.SetAllCaps(false);

            androidEmailEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidEmailEntry.Hint = "E-Mail Address";
            androidEmailEntry.Typeface = Constants.COMMONFONT;
            androidEmailEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidEmailEntry.SetPadding(0, 0, 0, 0);
            androidEmailEntry.SetTextColor(Android.Graphics.Color.Black);
            androidEmailEntry.InputType = Android.Text.InputTypes.TextVariationEmailAddress;

            androidPasswordEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidPasswordEntry.Hint = "Password";
            androidPasswordEntry.Typeface = Constants.COMMONFONT;
            androidPasswordEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidPasswordEntry.SetPadding(0, 0, 0, 0);
            androidPasswordEntry.SetTextColor(Android.Graphics.Color.Black);
            androidPasswordEntry.SetHighlightColor(Android.Graphics.Color.Transparent);
            androidPasswordEntry.InputType = Android.Text.InputTypes.TextVariationWebPassword;
            androidPasswordEntry.TransformationMethod = new PasswordTransformationMethod();
#endif
            //Events
            loginBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Validate(sender, e); 
                ToggleButtons();
            }; 
            backBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            forgotPasswordBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PushModalAsync(new ForgotPasswordPage());
                ToggleButtons();
            };

#if __ANDROID__
            androidLoginBtn.Click += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Validate(sender, e);
                ToggleButtons();
            };
            androidForgotPasswordBtn.Click += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PushModalAsync(new ForgotPasswordPage());
                ToggleButtons();
            }; 
#endif

#if __IOS__
            buttonLayout.Children.Add(backBtn);
            buttonLayout.Children.Add(loginBtn);
            buttonLayout.Children.Add(forgotPasswordBtn);
            buttonLayout.Orientation = StackOrientation.Horizontal;
            emailLayout.Children.Add(emailImg);
            emailLayout.Children.Add(emailEntry);
            emailLayout.Orientation = StackOrientation.Horizontal;
            passwordLayout.Children.Add(passwordImg);
            passwordLayout.Children.Add(passwordEntry);
            passwordLayout.Orientation = StackOrientation.Horizontal;
            innerStackLayout.Children.Add(emailLayout);
            innerStackLayout.Children.Add(passwordLayout);
            //innerStackLayout.Children.Add(emailImg);
            //innerStackLayout.Children.Add(emailEntry);

            //innerStackLayout.Children.Add(passwordImg);
            //innerStackLayout.Children.Add(passwordEntry);
            innerStackLayout.Children.Add(buttonLayout);
            stackLayout.Children.Add(mahechaLogo);
            stackLayout.Children.Add(innerStackLayout);
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.VerticalOptions = LayoutOptions.CenterAndExpand;
            stackLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;

            scrollView.Content = stackLayout;
            Content = scrollView;
#endif
#if __ANDROID__
            buttonGrid.Children.Add(androidLoginBtn.ToView(), 0, 0);
            buttonGrid.Children.Add(androidForgotPasswordBtn.ToView(), 1, 0);
            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(androidEmailEntry.ToView(), 0, 1);
            innerGrid.Children.Add(androidPasswordEntry.ToView(), 0, 2);
            innerGrid.Children.Add(buttonGrid, 0, 3);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
#endif
        }

        private async Task Validate(object sender, EventArgs e)
        {
#if __ANDROID__
            if (androidEmailEntry.Text != null || androidPasswordEntry.Text != null)
            {
                await Login(sender, e);
            }
#endif
#if __IOS__
            if (emailEntry.Text != null || passwordEntry.Text != null)
            {
                await Login(sender, e);
            }
#endif

            else
            {
                await DisplayAlert("Login Error!", "Make sure all fields are filled in!", "Ok, got it.");
            }
        }

        private async Task Login(object sender, EventArgs e)
        {
#if __ANDROID__
            user = await _baseViewModel.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, androidEmailEntry.Text.ToLower(), androidPasswordEntry.Text);
#endif
#if __IOS__
            user = await _baseViewModel.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, emailEntry.Text.ToLower(), passwordEntry.Text);
#endif
            if (user == null)
            {
                await DisplayAlert("User Not Found", "Wrong Email address or Password, please try again.", "Got It");
            }
            else
            {
                //bool UserMatchesPackages = await CheckIfUserMatchesPackages(user);
                bool UserMatchesPackages = true;
                if (UserMatchesPackages)
                {
                    _baseViewModel.SaveCredentials(user);
                    Application.Current.MainPage = new MainTabbedPage(true);
                }
                else 
                {
                    await DisplayAlert("Missing Packages", "Missing packages required to access the content of this account.", "Ok");
                    await Navigation.PopModalAsync();
                }
            }
        }

        private async Task<bool> CheckIfUserMatchesPackages(User passedUser)
        {
            await _baseViewModel.CheckIfUserHasPackage();

            if (_baseViewModel.HasGiPackage && _baseViewModel.HasNoGiPackage)
            {
                _baseViewModel.HasGiAndNoGiPackage = true;
            }

            if (_baseViewModel.HasGiAndNoGiPackage && passedUser.Packages.GiAndNoGiJiuJitsu)
            {
                return true;
            }
            else if (_baseViewModel.HasGiPackage && _baseViewModel.HasNoGiPackage && passedUser.Packages.GiJiuJitsu && passedUser.Packages.NoGiJiuJitsu)
            {
                return true;
            }
            else if (_baseViewModel.HasGiPackage && _baseViewModel.HasNoGiPackage && passedUser.Packages.GiJiuJitsu && !passedUser.Packages.NoGiJiuJitsu)
            {
                return true;
            }
            else if (_baseViewModel.HasGiPackage && _baseViewModel.HasNoGiPackage && !passedUser.Packages.GiJiuJitsu && passedUser.Packages.NoGiJiuJitsu)
            {
                return true;
            }
            else if (_baseViewModel.HasGiPackage && !_baseViewModel.HasNoGiPackage && passedUser.Packages.GiJiuJitsu && !passedUser.Packages.NoGiJiuJitsu)
            {
                return true;
            }
            else if (_baseViewModel.HasNoGiPackage && !_baseViewModel.HasGiPackage && passedUser.Packages.NoGiJiuJitsu && !passedUser.Packages.GiJiuJitsu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ToggleButtons()
        {
#if __ANDROID__
            androidLoginBtn.Clickable = !androidLoginBtn.Clickable;
            androidForgotPasswordBtn.Clickable = !androidForgotPasswordBtn.Clickable;
#endif
            backBtn.IsEnabled = !backBtn.IsEnabled;
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            forgotPasswordBtn.IsEnabled = !forgotPasswordBtn.IsEnabled;
        }

#if __IOS__

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 10, 10, 10);
#endif
                mahechaLogo.Scale = 0;
                mahechaLogo.IsVisible = false;
                stackLayout.Orientation = StackOrientation.Horizontal;
                buttonLayout.VerticalOptions = LayoutOptions.EndAndExpand;
            }
            else
            {
                mahechaLogo.Scale = 1;
                mahechaLogo.IsVisible = true;
                stackLayout.Orientation = StackOrientation.Vertical;
                Padding = new Thickness(10, 30, 10, 10);
            }
		}
#endif
    }

}

