using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Forms;

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
        private Entry emailEntry;
        private Label passwordLbl;
        private Entry passwordEntry;
        private Button loginBtn;
        private Button backBtn;
        private Button forgotPasswordBtn;
        private User user;
        private ScrollView scrollView;
        private StackLayout stackLayout;
        private StackLayout innerStackLayout;
        private StackLayout buttonLayout;


        public LoginPage()
        {
            _baseViewModel = new BaseViewModel();
            #if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
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
            innerStackLayout = new StackLayout();

            //View objects
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition {Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(2, GridUnitType.Star)}
                },
                RowSpacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
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
                Margin = new Thickness(0, -5, 0, -5),
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };
            emailEntry = new Entry
            {
                Placeholder = "SpiderGuard123@gmail.com",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
#endif
                FontSize = entrySize
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
                Margin = new Thickness(0, -5, 0, -5),
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
                Margin = new Thickness(0, -5, 0, -5),
#endif
                FontSize = entrySize
            };
            loginBtn = new Button
            {
                Text = "Login",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            backBtn = new Button
            {
                Text = "Back",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            forgotPasswordBtn = new Button
            {
                Text = "?",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
                BackgroundColor = Color.FromRgb(58, 93, 174),
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
                BackgroundColor = Color.FromRgb(124, 37, 41),
#endif
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            //Events
            loginBtn.Clicked += Validate;
            backBtn.Clicked += GoBack;
            forgotPasswordBtn.Clicked += ForgotPasswordForm;

#if __IOS__
            buttonLayout.Children.Add(backBtn);
            buttonLayout.Children.Add(loginBtn);
            buttonLayout.Children.Add(forgotPasswordBtn);
            buttonLayout.Orientation = StackOrientation.Horizontal;
            innerStackLayout.Children.Add(emailLbl);
            innerStackLayout.Children.Add(emailEntry);
            innerStackLayout.Children.Add(passwordLbl);
            innerStackLayout.Children.Add(passwordEntry);
            innerStackLayout.Children.Add(buttonLayout);
            stackLayout.Children.Add(mahechaLogo);
            stackLayout.Children.Add(innerStackLayout);
            stackLayout.Orientation = StackOrientation.Vertical;

            scrollView.Content = stackLayout;
            Content = scrollView;
#endif
#if __ANDROID__
            buttonGrid.Children.Add(loginBtn, 0, 0);
            buttonGrid.Children.Add(forgotPasswordBtn, 1, 0);
            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(emailLbl, 0, 1);
            innerGrid.Children.Add(emailEntry, 0, 2);
            innerGrid.Children.Add(passwordLbl, 0, 3);
            innerGrid.Children.Add(passwordEntry, 0, 4);
            innerGrid.Children.Add(buttonGrid, 0, 5);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
#endif
        }

        private void Validate(object sender, EventArgs e)
        {
            ToggleButtons();
            if (emailEntry.Text != null || passwordEntry.Text != null)
            {
                Login(sender, e);
            }
            else
            {
                DisplayAlert("Login Error!", "Make sure all fields are filled in!", "Ok, got it.");
            }
            ToggleButtons();
        }

        private async void Login(object sender, EventArgs e)
        {
            user = await _baseViewModel.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, emailEntry.Text.ToLower(), passwordEntry.Text);
            if (user == null)
            {
                await DisplayAlert("User Not Found", "Wrong Email address or Password, please try again.", "Got It");
            }
            else
            {
                _baseViewModel.SaveCredentials(user);
                Application.Current.MainPage = new MainTabbedPage();
            }

        }

        private void GoBack(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PopModalAsync();
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            forgotPasswordBtn.IsEnabled = !forgotPasswordBtn.IsEnabled;
        }

        private void ForgotPasswordForm(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PushModalAsync(new ForgotPasswordPage());
            ToggleButtons();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                Padding = new Thickness(10, 10, 10, 10);
                mahechaLogo.Scale = 0;
                mahechaLogo.IsVisible = false;
#if __IOS__
                stackLayout.Orientation = StackOrientation.Horizontal;
                stackLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;
                stackLayout.VerticalOptions = LayoutOptions.CenterAndExpand;
                buttonLayout.VerticalOptions = LayoutOptions.EndAndExpand;
#endif
#if __ANDROID__
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition {Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                buttonGrid.Children.Add(loginBtn, 0, 0);
                buttonGrid.Children.Add(forgotPasswordBtn, 1, 0);
                innerGrid.Children.Add(emailLbl, 0, 0);
                innerGrid.Children.Add(emailEntry, 0, 1);
                innerGrid.Children.Add(passwordLbl, 0, 2);
                innerGrid.Children.Add(passwordEntry, 0, 3);
                innerGrid.Children.Add(buttonGrid, 0, 4);
#endif
            }
            else
            {
                mahechaLogo.Scale = 1;
                mahechaLogo.IsVisible = true;
#if __IOS__
                stackLayout.Orientation = StackOrientation.Vertical;
                Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
                Padding = new Thickness(10, 10, 10, 10);

                buttonGrid.Children.Add(loginBtn, 0, 0);
                buttonGrid.Children.Add(forgotPasswordBtn, 1, 0);
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                innerGrid.Children.Add(emailLbl, 0, 1);
                innerGrid.Children.Add(emailEntry, 0, 2);
                innerGrid.Children.Add(passwordLbl, 0, 3);
                innerGrid.Children.Add(passwordEntry, 0, 4);
                innerGrid.Children.Add(buttonGrid, 0, 5);

                outerGrid.Children.Add(innerGrid, 0, 0);

                Content = outerGrid;
#endif
            }
		}
    }
}

