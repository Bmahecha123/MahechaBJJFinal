using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.SignUpPages;
using Plugin.InAppBilling;
using Plugin.InAppBilling.Abstractions;
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
        private Label beltLbl;
        private Label secretQuestionLbl;
        private Label secretQuestionAnswerLbl;
        private Button backBtn;
        private Button signUpBtn;
        private User user;
        private Grid buttonGrid;
        private Grid innerGrid;
        private Grid outerGrid;
        private StackLayout stackLayout;
        private ScrollView scrollView;
        private string packageName;
        private string packagePrice;
        private Image packageImage;
        private Package package;
        private bool userPassed;

        public SummaryPage(Package package)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            this.package = package;
            #if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            this.userPassed = false;
            SetPackageInfo(false);
            SetContent(false);

        }


        public SummaryPage(User user)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            #if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            this.user = user;
            this.userPassed = true;
            SetPackageInfo(true);
            SetContent(true);
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
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

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
            backBtn.Clicked += (sender, e) => {
                GoBack();
            };

            signUpBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                Text = "Sign Up",
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            signUpBtn.Clicked += (sender, e) =>
            {
                SignUp();
            };

            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(signUpBtn, 1, 0);

            summaryLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "Summary",
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            userDetailsLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "User Details",
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };



            packageLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Text = $"Package: {packageName}",
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            priceLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Text = $"Price: {packagePrice}",
                LineBreakMode = LineBreakMode.WordWrap,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            packageImage = new Image();
            if (packageName.Equals("Gi Jiu-Jitsu Package"))
            {
                packageImage.Source = "gi.jpg";
            }
            else if (packageName.Equals("No-Gi Jiu-Jitsu Package"))
            {
                packageImage.Source = "nogi6.jpeg";
            }
            else
            {
                packageImage.Source = "sweep.JPG";
            }
            packageImage.Aspect = Aspect.AspectFit;

            if (hasUser)
            {
                nameLbl = new Label
                {
#if __IOS__
                    FontFamily = "AmericanTypewriter-Bold",
                    FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                    Text = $"Name: {user.Name}",
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand

                };

                emailLbl = new Label
                {
#if __IOS__
                    FontFamily = "AmericanTypewriter-Bold",
                    FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                    Text = $"E-Mail: {user.Email}",
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand

                };

                beltLbl = new Label
                {
#if __IOS__
                    FontFamily = "AmericanTypewriter-Bold",
                    FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                    Text = $"Belt: {user.Belt}",
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand

                };

                secretQuestionLbl = new Label
                {
#if __IOS__
                    FontFamily = "AmericanTypewriter-Bold",
                    FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                    Text = $"Secret Question: {user.SecretQuestion}",
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand

                };

                secretQuestionAnswerLbl = new Label
                {
#if __IOS__
                    FontFamily = "AmericanTypewriter-Bold",
                    FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                    Text = $"Answer: {user.SecretQuestionAnswer}",
                    LineBreakMode = LineBreakMode.WordWrap,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand

                };

#if __IOS__
                innerGrid = new Grid
                {
                    RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
                }
                };

#endif
#if __ANDROID__
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(4, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            buttonGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
#endif



#if __ANDROID__
            stackLayout = new StackLayout
            {
                Children = {
                    summaryLbl,
                    packageLbl,
                    priceLbl,
                    userDetailsLbl,
                    nameLbl,
                    emailLbl,
                    beltLbl,
                    secretQuestionLbl,
                    secretQuestionAnswerLbl
                }
            };
            scrollView = new ScrollView
            {
                Content = stackLayout
            };
#endif
#if __IOS__

                innerGrid.Children.Add(summaryLbl, 0, 0);
                innerGrid.Children.Add(packageLbl, 0, 1);
                innerGrid.Children.Add(priceLbl, 0, 2);
                innerGrid.Children.Add(userDetailsLbl, 0, 3);
                innerGrid.Children.Add(nameLbl, 0, 4);
                innerGrid.Children.Add(emailLbl, 0, 5);
                innerGrid.Children.Add(beltLbl, 0, 6);
                innerGrid.Children.Add(secretQuestionLbl, 0, 7);
                innerGrid.Children.Add(secretQuestionAnswerLbl, 0, 8);
                innerGrid.Children.Add(buttonGrid, 0, 9);
#endif
#if __ANDROID__
            buttonGrid.Children.Add(signUpBtn, 0, 0);

            innerGrid.Children.Add(scrollView, 0, 0);
            innerGrid.Children.Add(buttonGrid, 0, 1);
#endif

            }
            else
            {
#if __IOS__
                innerGrid = new Grid();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(summaryLbl, 0, 0);
                innerGrid.Children.Add(packageLbl, 0, 1);
                innerGrid.Children.Add(priceLbl, 0, 2);
                innerGrid.Children.Add(packageImage, 0, 3);
                innerGrid.Children.Add(buttonGrid, 0, 4);
#endif
            }

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private async void SignUp()
        {
            ToggleButtons();
            bool purchased = true;
            if (userPassed)
            {
                if (await _summaryPageViewModel.UserExist(user))
                {
                    await DisplayAlert("Account Exists", $"An account with the email {user.Email} already exists. Use a different email address.", "Ok");
                    await Navigation.PopModalAsync();
                    ToggleButtons();

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
                    ToggleButtons();
                }
                else
                {
                    _summaryPageViewModel.DeleteUser(user);
                    await Navigation.PopModalAsync();
                    ToggleButtons();
                }
            }
            else
            {
                //purchased = await _summaryPageViewModel.PurchaseProduct(FindPackageName(false));

                if (purchased)
                {
                    _summaryPageViewModel.SavePackageInfoWithNoAccount(package);
                    Application.Current.MainPage = new MainTabbedPage(false);
                    await _summaryPageViewModel.Disconnect();
                    ToggleButtons();
                }
                else
                {
                    await Navigation.PopModalAsync();
                    ToggleButtons();
                }
            }


        }

        private void GoBack()
        {
            ToggleButtons();
            Navigation.PopModalAsync();
        }

        private string FindPackageName(bool hasUser)
        {
            if (hasUser)
            {
                if (user.Packages.GiJiuJitsu == true)
                {
                    return "package_gi_jiujitsu";
                }
                else if (user.Packages.NoGiJiuJitsu == true)
                {
                    return "package_nogi_jiujitsu";
                }
                else
                {
                    return "package_giandnogi_jiujitsu";
                }
            }
            else
            {
                if (package == Package.Gi)
                {
                    return "package_gi_jiujitsu";
                }
                if (package == Package.NoGi)
                {
                    return "package_nogi_jiujitsu";
                }
                else 
                {
                    return "package_giandnogi_jiujitsu";
                }
            }
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            signUpBtn.IsEnabled = !signUpBtn.IsEnabled;
        }
            
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (userPassed)
            {
                if (width > height)
                {
                    Padding = new Thickness(10, 10, 10, 0);
                    innerGrid.Children.Clear();
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
#if __IOS__
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });

                    innerGrid.Children.Add(summaryLbl, 0, 0);
                    innerGrid.Children.Add(packageLbl, 0, 1);
                    innerGrid.Children.Add(priceLbl, 0, 2);
                    innerGrid.Children.Add(userDetailsLbl, 0, 3);
                    innerGrid.Children.Add(nameLbl, 0, 4);
                    innerGrid.Children.Add(emailLbl, 0, 5);
                    innerGrid.Children.Add(beltLbl, 0, 6);
                    innerGrid.Children.Add(secretQuestionLbl, 0, 7);
                    innerGrid.Children.Add(secretQuestionAnswerLbl, 0, 8);
                    innerGrid.Children.Add(buttonGrid, 0, 9);
#endif
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });

                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
#endif
                }
                else
                {
#if __IOS__
                    Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
                Padding = new Thickness(10, 10, 10, 10);
#endif
                    innerGrid.Children.Clear();
                    innerGrid.RowDefinitions.Clear();
                    innerGrid.ColumnDefinitions.Clear();
#if __IOS__
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                    innerGrid.Children.Add(summaryLbl, 0, 0);
                    innerGrid.Children.Add(packageLbl, 0, 1);
                    innerGrid.Children.Add(priceLbl, 0, 2);
                    innerGrid.Children.Add(userDetailsLbl, 0, 3);
                    innerGrid.Children.Add(nameLbl, 0, 4);
                    innerGrid.Children.Add(emailLbl, 0, 5);
                    innerGrid.Children.Add(beltLbl, 0, 6);
                    innerGrid.Children.Add(secretQuestionLbl, 0, 7);
                    innerGrid.Children.Add(secretQuestionAnswerLbl, 0, 8);
                    innerGrid.Children.Add(buttonGrid, 0, 9);

#endif
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
#endif
                }
            }
        }
    }
}

