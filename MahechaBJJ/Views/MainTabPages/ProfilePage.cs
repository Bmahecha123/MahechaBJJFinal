using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.Service;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.CommonPages;
using MahechaBJJ.Views.EntryPages;
using MahechaBJJ.Views.SignUpPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class ProfilePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private FlexLayout flexLayout;
        private Label nameLbl;
        private Label nameTextLbl;
        private Label emailLbl;
        private Label emailTextLbl;
        private Button contactUsBtn;
        private Button logOutBtn;
        private Button loginBtn;
        private Button settingsBtn;
        private Button backBtn;
        private Account account;
        private User user;
        private ActivityIndicator activityIndicator;
        private Button createAccountBtn;
        private bool hasAccount;

        public ProfilePage(bool hasAccount)
        {
            _baseViewModel = new BaseViewModel();
            this.hasAccount = hasAccount;
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            IconImageSource = "karate.png";
            Padding = Theme.Thickness;

            BuildPageObjects();
            SetContent();

            Content = flexLayout;
        }

        //functions
        public void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            nameLbl = new Label
            {
                Text = "Name",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            nameTextLbl = new Label
            {
                Text = "Jon",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.NoWrap
            };

            emailLbl = new Label
            {
                Text = "E-Mail",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            emailTextLbl = new Label
            {
                Text = "Doe",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.NoWrap
            };

            contactUsBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Contact Us"
            };

            logOutBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Log Out"
            };

            loginBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Login"
            };

            settingsBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Settings"
            };

            createAccountBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Create Account"
            };

            backBtn = new Button
            {
                ImageSource = "back.png",
                Style = Theme.RedButton
            };

            activityIndicator = new ActivityIndicator
            {
                Color = Theme.Blue,
                IsRunning = false,
                IsVisible = false,
                IsEnabled = false
            };

            //Events
            contactUsBtn.Clicked += (sender, e) =>
            {
                ToggleButtons();
                ContactUs();
                ToggleButtons();
            };
            logOutBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await LogOutClick();
                ToggleButtons();
            };
            settingsBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await Settings();
                ToggleButtons();
            };
            createAccountBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PushModalAsync(new SignUpPage());
                ToggleButtons();
            };
            loginBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushModalAsync(new LoginPage());
            };
            backBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
        }

        public async void SetContent()
        {
            account = _baseViewModel.GetAccountInformation();

            FlexLayout.SetAlignSelf(nameLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(nameTextLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(emailLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(emailTextLbl, FlexAlignSelf.Center);

            //add activity indicator while contents load
            if (hasAccount)
            {
                flexLayout.Children.Clear();

                activityIndicator.IsRunning = true;

                flexLayout.Children.Add(activityIndicator);

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

                    nameTextLbl.Text = user.Name;
                    emailTextLbl.Text = user.Email;

                    //Building Grid
                    flexLayout.Children.Clear();
                    flexLayout.Children.Add(nameLbl);
                    flexLayout.Children.Add(nameTextLbl);
                    flexLayout.Children.Add(emailLbl);
                    flexLayout.Children.Add(emailTextLbl);
                    flexLayout.Children.Add(contactUsBtn);
                    flexLayout.Children.Add(settingsBtn);
                    flexLayout.Children.Add(logOutBtn);
//#if __IOS__
//                    flexLayout.Children.Add(backBtn);
//#endif
                }
                else
                {
                    LogOut();
                }
            }
            else
            {
                flexLayout.Children.Clear();
                flexLayout.Children.Add(contactUsBtn);
                flexLayout.Children.Add(loginBtn);
                flexLayout.Children.Add(createAccountBtn);
//#if __IOS__
//                flexLayout.Children.Add(backBtn);
//#endif
            }

        }

        private void LogOut()
        {
            _baseViewModel.DeleteCredentials();
            var entryPage = new NavigationPage(new EntryPage());
            NavigationPage.SetHasNavigationBar(entryPage.CurrentPage, false);
            Application.Current.MainPage = entryPage;
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
            var emailMessage = new EmailMessage();
            emailMessage.Subject = "Mahecha BJJ - <Insert Subject Here>";
#if __IOS__
                MessagingCenter.Send(this, "Send EMail", emailMessage);
#endif
#if __ANDROID__
            Xamarin.Forms.DependencyService.Register<IEmailService>();
            DependencyService.Get<IEmailService>().StartEmailActivity(emailMessage);
#endif
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

        private void ToggleButtons()
        {
            contactUsBtn.IsEnabled = !contactUsBtn.IsEnabled;
            logOutBtn.IsEnabled = !logOutBtn.IsEnabled;
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            settingsBtn.IsEnabled = !settingsBtn.IsEnabled;
            createAccountBtn.IsEnabled = !createAccountBtn.IsEnabled;
            backBtn.IsEnabled = !backBtn.IsEnabled;
        }
    }
}

