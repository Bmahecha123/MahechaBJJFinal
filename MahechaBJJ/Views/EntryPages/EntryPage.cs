using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.EntryPages;
using MahechaBJJ.Views.SignUpPages;
using Xamarin.Forms;
using System.Threading.Tasks;
using MahechaBJJ.ViewModel.SignUpPages;
using MahechaBJJ.Resources;

namespace MahechaBJJ.Views.EntryPages
{
    public class EntryPage : ContentPage
    {
        //viewModel
        private EntryPageViewModel _entryPageViewModel;
        private SummaryPageViewModel _summaryPageViewModel;
        //declare objects
        private FlexLayout flexLayout;
        private FlexLayout buttonFlexLayout;
        private Frame flexBackgroundFrame;
        private Image mahechaLogo;
        private Button loginBtn;
        private Button signUpBtn;
        private Button restoreBtn;
        private Package package;
        private double width;
        private double height;

        public EntryPage()
        {
            _entryPageViewModel = new EntryPageViewModel();
            _summaryPageViewModel = new SummaryPageViewModel();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            Padding = Theme.Thickness;

            width = this.Width;
            height = this.Height;

            flexLayout = new FlexLayout();
            buttonFlexLayout = new FlexLayout();
            BuildPageObjects();
            UpdateLayout();

            Content = flexLayout;
        }

        public void BuildPageObjects()
        {
            //view objects
            flexBackgroundFrame = new Frame
            {
                CornerRadius = 5,
                Padding = 25,
                Margin = 0,
                BackgroundColor = Theme.Red,
                Content = buttonFlexLayout
            };

            mahechaLogo = new Image
            {
                Source = ImageSource.FromResource("mahechabjjlogo.png"),
                Aspect = Aspect.AspectFit
            };
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            loginBtn = new Button
            {
                Text = "Login",
                Style = Theme.BlueButton
            };
            signUpBtn = new Button
            {
                Text = "Sign Up",
                Style = Theme.BlueButton
            };
            restoreBtn = new Button
            {
                Text = "Restore Purchase",
                Style = Theme.BlueButton
            };

            //Button events
            loginBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new LoginPage());
                ToggleButtons();
            };

            signUpBtn.Clicked += async (sender, args) =>
            {
                ToggleButtons();
                await SignUp();
                ToggleButtons();
            };

            restoreBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await CheckIfUserHasPackage(sender, e);
                ToggleButtons();
            };

            //Build Button Flex Layout
            buttonFlexLayout.Children.Add(loginBtn);
            buttonFlexLayout.Children.Add(signUpBtn);
            buttonFlexLayout.Children.Add(restoreBtn);
            buttonFlexLayout.Direction = FlexDirection.Column;
            buttonFlexLayout.JustifyContent = FlexJustify.SpaceEvenly;
            
            //Flex Layout
            flexLayout.Children.Add(mahechaLogo);
            flexLayout.Children.Add(flexBackgroundFrame);
            
        }

        private async Task SignUp()
        {
            var ACCOUNT = "Sign Up";
            var NOACCOUNT = "Sign Up With No Account";

            string[] options = { ACCOUNT, NOACCOUNT };
            string selection = await DisplayActionSheet("Sign Up", "Cancel", null, options);
            if (selection.Equals(ACCOUNT))
            {
                await Navigation.PushModalAsync(new SignUpPage(Package.GiAndNoGi));
            } else
            {
                await Navigation.PushModalAsync(new SummaryPage(Package.GiAndNoGi));
            }
        }

        private void PortraitLayout()
        {
            //Set props
            FlexLayout.SetBasis(flexBackgroundFrame, 1);
            FlexLayout.SetBasis(mahechaLogo, 1);
            FlexLayout.SetGrow(flexBackgroundFrame, 1);
            FlexLayout.SetGrow(mahechaLogo, 1);

            //Flexbox
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }

        private void LandscapeLayout()
        {
            //Set props
            FlexLayout.SetBasis(flexBackgroundFrame, 1);
            FlexLayout.SetBasis(mahechaLogo, 1);
            FlexLayout.SetGrow(flexBackgroundFrame, 1);
            FlexLayout.SetGrow(mahechaLogo, 1);

            //Flexbox
            flexLayout.Direction = FlexDirection.Row;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }

        private void UpdateLayout()
        {
            //flexLayout.Children.Clear();

            if (this.Width > this.Height)
                LandscapeLayout();
            else
                PortraitLayout();
        }

        private async Task CheckIfUserHasPackage(object sender, EventArgs e)
        {
            await _entryPageViewModel.CheckIfUserHasPackage();
            if (_entryPageViewModel.HasGiAndNoGiPackage)
            {
                package = Package.GiAndNoGi;
                Restore();
            }
            else if (_entryPageViewModel.HasGiPackage && _entryPageViewModel.HasNoGiPackage)
            {
                package = Package.GiAndNoGi;
                Restore();
            }
            else if (_entryPageViewModel.HasGiPackage && !_entryPageViewModel.HasNoGiPackage)
            {
                package = Package.Gi;
                Restore();
            }
            else if (_entryPageViewModel.HasNoGiPackage && !_entryPageViewModel.HasGiPackage)
            {
                package = Package.NoGi;
                Restore();
            }
            else 
            {
                await DisplayAlert("No Packages Found", "There were no packages found.", "Ok");
            }
        }

        private void Restore()
        {
            _summaryPageViewModel.SavePackageInfoWithNoAccount(package);
            Application.Current.MainPage = new MainTabbedPage(false);
        }

        private void ToggleButtons()
        {
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            signUpBtn.IsEnabled = !signUpBtn.IsEnabled;
            restoreBtn.IsEnabled = !restoreBtn.IsEnabled;
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

