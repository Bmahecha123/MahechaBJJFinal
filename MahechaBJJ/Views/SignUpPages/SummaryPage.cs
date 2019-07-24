using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.SignUpPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.SignUpPages
{
    public class SummaryPage : ContentPage
    {
        private SummaryPageViewModel _summaryPageViewModel;
        private Label summaryLbl;
        private Label userDetailsLbl;
        private Label packageLbl;
        private Label priceLbl;
        private Label nameLbl;
        private Label emailLbl;
        private Label secretQuestionLbl;
        private Label secretQuestionAnswerLbl;
        private Button backBtn;
        private Button signUpBtn;
        private User user;
        private FlexLayout flexLayout;
        private FlexLayout userDetailsFlexLayout;
        private StackLayout buttonStackLayout;
        private string packageName;
        private string packagePrice;
        private Image packageImage;
        private Frame packageImageFrame;
        private Package package;
        private bool userPassed;
        private double width;
        private double height;

        public SummaryPage(Package package)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            BackgroundColor = Theme.White;
            this.package = package;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            width = this.Width;
            height = this.Height;
            this.userPassed = false;
            SetPackageInfo(false);
            SetContent(false);
            UpdateLayout();

            Content = flexLayout;
        }


        public SummaryPage(User user)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            BackgroundColor = Theme.White;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            width = this.Width;
            height = this.Height;
            this.user = user;
            this.userPassed = true;
            SetPackageInfo(true);
            SetContent(true);
            UpdateLayout();

            Content = flexLayout;
        }

        private void SetPackageInfo(bool hasUser)
        {
            if (hasUser)
            {
                if (user.Packages.GiJiuJitsu == true)
                {
                    packageName = "Gi Jiu-Jitsu Package";
                    packagePrice = "$19.99";
                }
                if (user.Packages.NoGiJiuJitsu == true)
                {
                    packageName = "No-Gi Jiu-Jitsu Package";
                    packagePrice = "$19.99";
                }
                if (user.Packages.GiAndNoGiJiuJitsu == true)
                {
                    packageName = "Complete Jiu-Jitsu Package";
                    packagePrice = "$29.99";
                }
            }
            else
            {
                if (package == Package.Gi)
                {
                    packageName = "Gi Jiu-Jitsu Package";
                    packagePrice = "$19.99";
                }
                if (package == Package.NoGi)
                {
                    packageName = "No-Gi Jiu-Jitsu Package";
                    packagePrice = "$19.99";
                }
                if (package == Package.GiAndNoGi)
                {
                    packageName = "Complete Jiu-Jitsu Package";
                    packagePrice = "$29.99";
                }
            }
        }

        private void SetContent(bool hasUser)
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            userDetailsFlexLayout = new FlexLayout();
            userDetailsFlexLayout.Direction = FlexDirection.Column;
            userDetailsFlexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            backBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };

            signUpBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Sign Up",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            signUpBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await SignUp();
                ToggleButtons();
            };

            summaryLbl = new Label
            {
                FontSize = lblSize,
                FontFamily = Theme.Font,
                Text = "Summary",
                TextColor = Theme.Black
            };

            userDetailsLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = "User Details",
                TextColor = Theme.Black
            };

            packageLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = packageName,
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.WordWrap
            };

            priceLbl = new Label
            {
                FontFamily = Theme.Font,
                FontSize = lblSize,
                Text = $"Price: {packagePrice}",
                TextColor = Theme.Black,
                LineBreakMode = LineBreakMode.WordWrap
            };

            packageImage = new Image();
            packageImage.Source = "giguard.jpg";
            packageImage.Aspect = Aspect.AspectFill;

            packageImageFrame = new Frame
            {
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = packageImage,
                Padding = 0
            };
#if __IOS__
            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(signUpBtn);

            if (hasUser)
            {
                nameLbl = new Label
                {
                    FontFamily = Theme.Font,
                    FontSize = lblSize,
                    Text = $"Name: {user.Name}",
                    TextColor = Theme.Black,
                    LineBreakMode = LineBreakMode.WordWrap
                };

                emailLbl = new Label
                {
                    FontFamily = Theme.Font,
                    FontSize = lblSize,
                    Text = $"E-Mail: {user.Email}",
                    TextColor = Theme.Black,
                    LineBreakMode = LineBreakMode.WordWrap
                };

                secretQuestionLbl = new Label
                {
                    FontSize = lblSize,
                    FontFamily = Theme.Font,
                    TextColor = Theme.Black,
                    Text = $"Secret Question: {user.SecretQuestion}",
                    LineBreakMode = LineBreakMode.WordWrap,
                };

                secretQuestionAnswerLbl = new Label
                {
                    FontSize = lblSize,
                    FontFamily = Theme.Font,
                    TextColor = Theme.Black,
                    Text = $"Answer: {user.SecretQuestionAnswer}",
                    LineBreakMode = LineBreakMode.WordWrap,
                };
            }
        }

        private async Task SignUp()
        {
            bool purchased = false;

            //bool purchased = true;
            if (userPassed)
            {
                if (await _summaryPageViewModel.UserExist(user))
                {
                    await DisplayAlert("Account Exists", $"An account with the email {user.Email} already exists. Use a different email address.", "Ok");
                    await Navigation.PopModalAsync();

                }
                else
                {
                    purchased = await _summaryPageViewModel.PurchaseProduct(FindPackageName(true));
                }
                if (purchased)
                {
                    await _summaryPageViewModel.CreateUser(user);
                    _summaryPageViewModel.SaveCredentials();
                    Application.Current.MainPage = new MainTabbedPage(true);
                    await _summaryPageViewModel.Disconnect();
                }
                else
                {
                    _summaryPageViewModel.DeleteUser(user);
                    await Navigation.PopModalAsync();
                }
            }
            else
            {
                purchased = await _summaryPageViewModel.PurchaseProduct(FindPackageName(false));

                if (purchased)
                {
                    _summaryPageViewModel.SavePackageInfoWithNoAccount(package);
                    Application.Current.MainPage = new MainTabbedPage(false);
                    await _summaryPageViewModel.Disconnect();
                }
                else
                {
                    await Navigation.PopModalAsync();
                }
            }
        }

        private string FindPackageName(bool hasUser)
        {
            if (hasUser)
            {
                if (user.Packages.GiJiuJitsu == true)
                {
                    return Constants.GIPACKAGE;
                }
                else if (user.Packages.NoGiJiuJitsu == true)
                {
                    return Constants.NOGIPACKAGE;
                }
                else
                {
                    return Constants.GIANDNOGIPACKAGE;
                }
            }
            else
            {
                if (package == Package.Gi)
                {
                    return Constants.GIPACKAGE;
                }
                if (package == Package.NoGi)
                {
                    return Constants.NOGIPACKAGE;
                }
                else
                {
                    return Constants.GIANDNOGIPACKAGE;
                }
            }
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            signUpBtn.IsEnabled = !signUpBtn.IsEnabled;
        }

        private void PortraitLayout()
        {
            flexLayout.Children.Clear();

            if (this.userPassed)
            {
                FlexLayout.SetAlignSelf(summaryLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(packageLbl, FlexAlignSelf.Start);
                FlexLayout.SetAlignSelf(priceLbl, FlexAlignSelf.Start);
                FlexLayout.SetAlignSelf(userDetailsLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(nameLbl, FlexAlignSelf.Start);
                FlexLayout.SetAlignSelf(emailLbl, FlexAlignSelf.Start);
                FlexLayout.SetAlignSelf(secretQuestionLbl, FlexAlignSelf.Start);
                FlexLayout.SetAlignSelf(secretQuestionAnswerLbl, FlexAlignSelf.Start);

                flexLayout.Children.Add(summaryLbl);
                flexLayout.Children.Add(packageLbl);
                flexLayout.Children.Add(priceLbl);
                flexLayout.Children.Add(userDetailsLbl);
                flexLayout.Children.Add(nameLbl);
                flexLayout.Children.Add(emailLbl);
                flexLayout.Children.Add(secretQuestionLbl);
                flexLayout.Children.Add(secretQuestionAnswerLbl);
                flexLayout.Children.Add(buttonStackLayout);
            } else
            {
                FlexLayout.SetAlignSelf(summaryLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(packageLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(priceLbl, FlexAlignSelf.Center);

                flexLayout.Children.Add(summaryLbl);
                flexLayout.Children.Add(packageLbl);
                flexLayout.Children.Add(priceLbl);
                flexLayout.Children.Add(buttonStackLayout);
            }

        }

        private void LandscapeLayout()
        {
            flexLayout.Children.Clear();

            if (this.userPassed)
            {
                FlexLayout.SetAlignSelf(summaryLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(packageLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(priceLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(userDetailsLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(nameLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(emailLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(secretQuestionLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(secretQuestionAnswerLbl, FlexAlignSelf.Center);

                flexLayout.Children.Add(summaryLbl);
                flexLayout.Children.Add(packageLbl);
                flexLayout.Children.Add(priceLbl);
                flexLayout.Children.Add(userDetailsLbl);
                flexLayout.Children.Add(nameLbl);
                flexLayout.Children.Add(emailLbl);
                flexLayout.Children.Add(secretQuestionLbl);
                flexLayout.Children.Add(secretQuestionAnswerLbl);
                flexLayout.Children.Add(buttonStackLayout);
            } else
            {
                FlexLayout.SetAlignSelf(summaryLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(packageLbl, FlexAlignSelf.Center);
                FlexLayout.SetAlignSelf(priceLbl, FlexAlignSelf.Center);

                flexLayout.Children.Add(summaryLbl);
                flexLayout.Children.Add(packageLbl);
                flexLayout.Children.Add(priceLbl);
                flexLayout.Children.Add(buttonStackLayout);
            }
        }

        private void UpdateLayout()
        {
            if (this.Width > this.Height)
                LandscapeLayout();
            else
                PortraitLayout();
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

