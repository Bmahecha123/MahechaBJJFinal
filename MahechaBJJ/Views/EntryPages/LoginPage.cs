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
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private FlexLayout loginSectionFlexLayout;
        private Frame loginSectionFrame;
        private Image mahechaLogo;
        private Entry emailEntry;
        private Entry passwordEntry;
        private Button loginBtn;
        private Button backBtn;
        private Button forgotPasswordBtn;
        private User user;
        private double width;
        private double height;

        public LoginPage()
        {
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            width = this.Width;
            height = this.Height;

            Padding = Theme.Thickness;

            BuildPageObjects();
            UpdateLayout();

            Content = flexLayout;
        }

        //functions
        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry));

            flexLayout = new FlexLayout();

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            loginSectionFlexLayout = new FlexLayout();

            loginSectionFrame = new Frame
            {
                CornerRadius = 5,
                Padding = 25,
                Margin = 0,
                BackgroundColor = Theme.Red,
                Content = loginSectionFlexLayout
            };

            mahechaLogo = new Image
            {
                Source = "mahechabjj.png",
                Aspect = Aspect.AspectFit
            };
            emailEntry = new Entry
            {
                Placeholder = "E-Mail Address",
                FontSize = entrySize,
                BackgroundColor = Theme.Azure,
                FontFamily = Theme.Font,
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black
            };
            passwordEntry = new Entry
            {
                IsPassword = true,
                Placeholder = "Password",
                FontSize = entrySize,
                BackgroundColor = Theme.Azure,
                FontFamily = Theme.Font,
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black,
            };
            loginBtn = new Button
            {
                Text = "Login",
                Style = Theme.BlueButton,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            backBtn = new Button
            {
                ImageSource = "back.png",
                Style = Theme.RedButton,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            forgotPasswordBtn = new Button
            {
                ImageSource = "forgotpassword.png",
                Style = Theme.BlueButton,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

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

            FlexLayout.SetBasis(emailEntry, 1);
            FlexLayout.SetGrow(emailEntry, 2);

            FlexLayout.SetBasis(passwordEntry, 1);
            FlexLayout.SetGrow(passwordEntry, 2);

            buttonStackLayout.Children.Clear();
#if __IOS__
            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(loginBtn);
            buttonStackLayout.Children.Add(forgotPasswordBtn);

            loginSectionFlexLayout.Children.Add(emailEntry);
            loginSectionFlexLayout.Children.Add(passwordEntry);
            loginSectionFlexLayout.Children.Add(buttonStackLayout);
            loginSectionFlexLayout.Direction = FlexDirection.Column;
            loginSectionFlexLayout.JustifyContent = FlexJustify.SpaceEvenly;
            FlexLayout.SetBasis(loginSectionFrame, 1);
            FlexLayout.SetGrow(loginSectionFrame, 1);

            flexLayout.Children.Add(mahechaLogo);
            flexLayout.Children.Add(loginSectionFrame);
            FlexLayout.SetBasis(mahechaLogo, 1);
            FlexLayout.SetGrow(mahechaLogo, 1);
        }

        private async Task Validate(object sender, EventArgs e)
        {
            if (emailEntry.Text != null || passwordEntry.Text != null)
            {
                await Login(sender, e);
            }

            else
            {
                await DisplayAlert("Login Error!", "Make sure all fields are filled in!", "Ok, got it.");
            }
        }

        private async Task Login(object sender, EventArgs e)
        {
            user = await _baseViewModel.FindUserByEmailAsync(Constants.FINDUSERBYEMAIL, emailEntry.Text.ToLower(), passwordEntry.Text);

            if (user == null)
            {
                await DisplayAlert("User Not Found", "Wrong Email address or Password, please try again.", "Got It");
            }
            else
            {
                bool UserMatchesPackages = await CheckIfUserMatchesPackages(user);
                //bool UserMatchesPackages = true;
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
            backBtn.IsEnabled = !backBtn.IsEnabled;
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            forgotPasswordBtn.IsEnabled = !forgotPasswordBtn.IsEnabled;
        }

        private void UpdateLayout()
        {
            if (this.Width > this.Height)
                LandscapeLayout();
            else
                PortraitLayout();
        }

        private void LandscapeLayout()
        {
            //Flexbox
            flexLayout.Direction = FlexDirection.Row;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }

        private void PortraitLayout()
        {
            //Flexbox
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                UpdateLayout();
            }
        }
    }

}

