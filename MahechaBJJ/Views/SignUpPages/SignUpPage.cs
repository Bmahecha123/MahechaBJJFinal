using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Resources;
using Xamarin.Forms;
using Xamarin.Auth;
using MahechaBJJ.ViewModel.SignUpPages;
using System.Threading.Tasks;

namespace MahechaBJJ.Views.SignUpPages
{
    public class SignUpPage : ContentPage
    {
        //ViewModel
        private BaseViewModel _baseViewModel;
        private SummaryPageViewModel _summaryPageViewModel;
        //declare objects
        private Package package;
        private Entry nameEntry;
        private Entry emailAddressEntry;
        private Entry passWordEntry;
        private Picker secretQuestionPicker;
        private Label secretQuestionLbl;
        private Entry secretQuestionEntry;
        private Button nextBtn;
        private Button backBtn;
        private User user;
        private ObservableCollection<string> secretQuestionList;
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private ScrollView scrollView;
        private bool hasPackage;
        private Account _account;
        private double width;
        private double height;
        private double lblSize;
        private double entrySize;

        public SignUpPage(Package package)
        {
            BackgroundColor = Theme.White;
            _baseViewModel = new BaseViewModel();
            this.hasPackage = true;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            width = this.Width;
            height = this.Height;
            lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            this.package = package;
            SetContent();
            UpdateLayout();

            Content = flexLayout;
        }

        public SignUpPage()
        {
            BackgroundColor = Theme.White;
            _summaryPageViewModel = new SummaryPageViewModel();
            _baseViewModel = new BaseViewModel();
            this.hasPackage = false;

            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            width = this.Width;
            height = this.Height;
            lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            SetContent();
            UpdateLayout();

            Content = flexLayout;
        }

        //functions
        private void SetContent()
        {
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            //View objects
            nameEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                Placeholder = "Name",
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black,
                BackgroundColor = Theme.Azure,
            };
            emailAddressEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black,
                Placeholder = "E-Mail Address",
                BackgroundColor = Theme.Azure,
            };
            passWordEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                PlaceholderColor = Theme.Black,
                Placeholder = "Password",
                TextColor = Theme.Black,
                IsPassword = true,
                BackgroundColor = Theme.Azure,

            };
            secretQuestionList = new ObservableCollection<String>();
            secretQuestionList.Add("What city were you born in?");
            secretQuestionList.Add("What city was your high school?");
            secretQuestionList.Add("Name of favorite instructor.");
            secretQuestionPicker = new Picker
            {
                Title = "Select a secret question to answer!",
                ItemsSource = secretQuestionList,
                TextColor = Theme.Black,
                FontFamily = Theme.Font,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Picker)),
                BackgroundColor = Theme.Azure,
                TitleColor = Theme.Black,
            };

            secretQuestionLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "Secret Question",
                TextColor = Theme.Black,
            };

            secretQuestionEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                TextColor = Theme.Black,
                PlaceholderColor = Theme.Black,
                Placeholder = "Answer for your own security!",
                BackgroundColor = Theme.Azure,
            };

            nextBtn = new Button
            {
                Style = Theme.BlueButton,
                ImageSource = "next.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            //Events
            nextBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Validate();
                ToggleButtons();
            };
            backBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            //passWordRepeatEntry.Unfocused += PasswordMatch;
            //TODO add specific validation events to make sure entries are correct.

            buttonStackLayout.Children.Clear();
#if __IOS__
            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(nextBtn);

            FlexLayout.SetAlignSelf(secretQuestionLbl, FlexAlignSelf.Center);

            flexLayout.Children.Clear();
            flexLayout.Children.Add(nameEntry);
            flexLayout.Children.Add(emailAddressEntry);
            flexLayout.Children.Add(passWordEntry);
            flexLayout.Children.Add(secretQuestionLbl);
            flexLayout.Children.Add(secretQuestionPicker);
            flexLayout.Children.Add(secretQuestionEntry);

            flexLayout.Children.Add(buttonStackLayout);
        }

        private async Task Validate()
        {
            if (this.hasPackage)
            {
                if (!string.IsNullOrWhiteSpace(nameEntry.Text) || !string.IsNullOrWhiteSpace(emailAddressEntry.Text) || !string.IsNullOrWhiteSpace(passWordEntry.Text)
                    || !string.IsNullOrWhiteSpace(secretQuestionEntry.Text))
                {
                    CreateUser();
                    await Navigation.PushModalAsync(new SummaryPage(user));
                }
                else
                {
                    await DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
                }
            }
            else
            {
                _account = _baseViewModel.GetAccountInformation();
                if (_account.Properties["Package"] == "Gi")
                {
                    this.package = Package.Gi;
                }
                else if (_account.Properties["Package"] == "NoGi")
                {
                    this.package = Package.NoGi;
                }
                else
                {
                    this.package = Package.GiAndNoGi;
                }

                if (nameEntry.Text != null || emailAddressEntry.Text != null || passWordEntry.Text != null
                || secretQuestionEntry.Text != null)
                {
                    CreateUser();
                    await _summaryPageViewModel.CreateUser(user);
                    _baseViewModel.DeleteCredentials();
                    _baseViewModel.SaveCredentials(_summaryPageViewModel.User);
                    Application.Current.MainPage = new MainTabbedPage(true);
                }
                else
                {
                    await DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
                }
            }
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
            Padding = new Thickness(20, 0, 20, 0);
        }

        private void PortraitLayout()
        {
            Padding = Theme.Thickness;
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

