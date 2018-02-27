using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.SignUpPages;
using Plugin.InAppBilling;
using Plugin.InAppBilling.Abstractions;
using Xamarin.Forms;
#if __ANDROID__
using MahechaBJJ.Droid;
using Xamarin.Forms.Platform.Android;
#endif

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
#if __ANDROID__
        private Android.Widget.TextView androidSummaryLbl;
        private Android.Widget.TextView androidUserDetailsLbl;
        private Android.Widget.TextView androidPackageLbl;
        private Android.Widget.TextView androidPriceLbl;
        private Android.Widget.TextView androidNameLbl;
        private Android.Widget.TextView androidEmailLbl;
        private Android.Widget.TextView androidBeltLbl;
        private Android.Widget.TextView androidSecretQuestionLbl;
        private Android.Widget.TextView androidSecretQuestionAnswerLbl;
        private Android.Widget.Button androidSignUpBtn;
#endif

        public SummaryPage(Package package)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            this.package = package;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
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
            Padding = new Thickness(5, 5, 5, 5);
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

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

#if __IOS__

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
#endif
#if __ANDROID__
            buttonGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
#endif

#if __ANDROID__

            androidSummaryLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidSummaryLbl.Text = "Summary";
            androidSummaryLbl.Typeface = Constants.COMMONFONT;
            androidSummaryLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidSummaryLbl.SetTextColor(Android.Graphics.Color.Black);
            androidSummaryLbl.Gravity = Android.Views.GravityFlags.Center;
            androidSummaryLbl.SetTypeface(androidSummaryLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidPackageLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidPackageLbl.Text = $"Package: {packageName}";
            androidPackageLbl.Typeface = Constants.COMMONFONT;
            androidPackageLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidPackageLbl.SetTextColor(Android.Graphics.Color.Black);
            androidPackageLbl.Gravity = Android.Views.GravityFlags.Start;

            androidPriceLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidPriceLbl.Text = $"Price: {packagePrice}";
            androidPriceLbl.Typeface = Constants.COMMONFONT;
            androidPriceLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidPriceLbl.SetTextColor(Android.Graphics.Color.Black);
            androidPriceLbl.Gravity = Android.Views.GravityFlags.Start;

            androidSignUpBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidSignUpBtn.Text = "Sign Up";
            androidSignUpBtn.Typeface = Constants.COMMONFONT;
            androidSignUpBtn.SetTextColor(Android.Graphics.Color.Black);
            androidSignUpBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidSignUpBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidSignUpBtn.Gravity = Android.Views.GravityFlags.Center;
            androidSignUpBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await SignUp();
                ToggleButtons();
            };
            androidSignUpBtn.SetAllCaps(false);

            if (hasUser)
            {
                androidUserDetailsLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidUserDetailsLbl.Text = "User Details";
                androidUserDetailsLbl.Typeface = Constants.COMMONFONT;
                androidUserDetailsLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidUserDetailsLbl.SetTextColor(Android.Graphics.Color.Black);
                androidUserDetailsLbl.Gravity = Android.Views.GravityFlags.Center;
                androidUserDetailsLbl.SetTypeface(androidUserDetailsLbl.Typeface, Android.Graphics.TypefaceStyle.Bold);

                androidNameLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidNameLbl.Text = $"Name: {user.Name}";
                androidNameLbl.Typeface = Constants.COMMONFONT;
                androidNameLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidNameLbl.SetTextColor(Android.Graphics.Color.Black);
                androidNameLbl.Gravity = Android.Views.GravityFlags.Start;

                androidEmailLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidEmailLbl.Text = $"E-Mail: {user.Email}";
                androidEmailLbl.Typeface = Constants.COMMONFONT;
                androidEmailLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidEmailLbl.SetTextColor(Android.Graphics.Color.Black);
                androidEmailLbl.Gravity = Android.Views.GravityFlags.Start;

                androidBeltLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidBeltLbl.Text = $"Belt: {user.Belt}";
                androidBeltLbl.Typeface = Constants.COMMONFONT;
                androidBeltLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidBeltLbl.SetTextColor(Android.Graphics.Color.Black);
                androidBeltLbl.Gravity = Android.Views.GravityFlags.Start;

                androidSecretQuestionLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidSecretQuestionLbl.Text = $"Secret Question: {user.SecretQuestion}";
                androidSecretQuestionLbl.Typeface = Constants.COMMONFONT;
                androidSecretQuestionLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidSecretQuestionLbl.Gravity = Android.Views.GravityFlags.Start;

                androidSecretQuestionAnswerLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
                androidSecretQuestionAnswerLbl.Text = $"Answer: {user.SecretQuestionAnswer}";
                androidSecretQuestionAnswerLbl.Typeface = Constants.COMMONFONT;
                androidSecretQuestionAnswerLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
                androidSecretQuestionAnswerLbl.Gravity = Android.Views.GravityFlags.Start;
            }
#endif

            backBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
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
            backBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
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
            signUpBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await SignUp();
                ToggleButtons();
            };

#if __IOS__
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(signUpBtn, 1, 0);
#endif

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
                    new RowDefinition { Height = new GridLength(6, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
                };
#endif

#if __ANDROID__
                stackLayout = new StackLayout
                {
                    Children = {
                        androidSummaryLbl.ToView(),
                        androidPackageLbl.ToView(),
                        androidPriceLbl.ToView(),
                        androidUserDetailsLbl.ToView(),
                        androidNameLbl.ToView(),
                        androidEmailLbl.ToView(),
                        androidBeltLbl.ToView(),
                        androidSecretQuestionLbl.ToView(),
                        androidSecretQuestionAnswerLbl.ToView()
                }
                };
                scrollView = new ScrollView
                {
                    Content = stackLayout,
                #if __ANDROID__
                    IsClippedToBounds = true
#endif
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
                buttonGrid.Children.Add(androidSignUpBtn.ToView(), 0, 0);

                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
#endif

            }
            else
            {
                innerGrid = new Grid();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
#if __IOS__
                innerGrid.Children.Add(summaryLbl, 0, 0);
                innerGrid.Children.Add(packageLbl, 0, 1);
                innerGrid.Children.Add(priceLbl, 0, 2);
                innerGrid.Children.Add(packageImage, 0, 3);
                innerGrid.Children.Add(buttonGrid, 0, 4);
#endif
#if __ANDROID__
                buttonGrid.Children.Add(androidSignUpBtn.ToView(), 0, 0);

                innerGrid.Children.Add(androidSummaryLbl.ToView(), 0, 0);
                innerGrid.Children.Add(androidPackageLbl.ToView(), 0, 1);
                innerGrid.Children.Add(androidPriceLbl.ToView(), 0, 2);
                innerGrid.Children.Add(packageImage, 0, 3);
                innerGrid.Children.Add(buttonGrid, 0, 4);
#endif
            }

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private async Task SignUp()
        {
            bool purchased = true;
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
#if __ANDROID__
            androidSignUpBtn.Clickable = !androidSignUpBtn.Clickable;
#endif
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
#if __IOS__
                    Padding = new Thickness(10, 10, 10, 10);
#endif
#if __ANDROID__
                    Padding = new Thickness(5, 5, 5, 5);
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
                Padding = new Thickness(5, 5, 5, 5);
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

