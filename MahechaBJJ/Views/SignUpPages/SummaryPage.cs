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
        private string packageName;
        private string packagePrice;

        public SummaryPage(User user)
        {
            _summaryPageViewModel = new SummaryPageViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            this.user = user;
            SetContent();
        }

        private void SetContent()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            summaryLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Summary",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            userDetailsLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "User Details",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

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

            packageLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Package: {packageName}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            priceLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Price: {packagePrice}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            nameLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Name: {user.Name}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            emailLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"E-Mail: {user.Email}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            beltLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Belt: {user.Belt}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            secretQuestionLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Secret Question: {user.SecretQuestion}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            secretQuestionAnswerLbl = new Label
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = $"Answer: {user.SecretQuestionAnswer}",
                LineBreakMode = LineBreakMode.WordWrap,
                FontSize = lblSize,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

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

            signUpBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Sign Up",
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

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


            //events
            backBtn.Clicked += (sender, e) => {
                GoBack();
            };
            signUpBtn.Clicked += (sender, e) =>
            {
                SignUp();
            };
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(signUpBtn, 1, 0);

            innerGrid.Children.Add(summaryLbl, 0, 0);
            innerGrid.Children.Add(packageLbl, 0, 1);
            innerGrid.Children.Add(priceLbl, 0 , 2);
            innerGrid.Children.Add(userDetailsLbl, 0, 3);
            innerGrid.Children.Add(nameLbl, 0, 4);
            innerGrid.Children.Add(emailLbl, 0, 5);
            innerGrid.Children.Add(beltLbl, 0, 6);
            innerGrid.Children.Add(secretQuestionLbl, 0, 7);
            innerGrid.Children.Add(secretQuestionAnswerLbl, 0, 8);
            innerGrid.Children.Add(buttonGrid, 0, 9);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private async void SignUp()
        {
            signUpBtn.IsEnabled = false;
            backBtn.IsEnabled = false;
            bool purchased = false;

            if (await _summaryPageViewModel.UserExist(user))
            {
                await DisplayAlert("Account Exists", $"An account with the email {user.Email} already exists. Use a different email address.", "Ok");
                await Navigation.PopModalAsync();
                signUpBtn.IsEnabled = true;
            }
            else 
            {
                purchased = await _summaryPageViewModel.PurchaseProduct(FindPackageName());
            }

            if (purchased)
            {
                await _summaryPageViewModel.CreateUser(user);
                _summaryPageViewModel.SaveCredentials();
                Application.Current.MainPage = new MainTabbedPage();
                await _summaryPageViewModel.Disconnect();
                signUpBtn.IsEnabled = true;
                backBtn.IsEnabled = true;
            }
            else 
            {
                _summaryPageViewModel.DeleteUser(user);
                await Navigation.PopModalAsync();
                signUpBtn.IsEnabled = true;
                backBtn.IsEnabled = true;
            }
        }

        private void GoBack()
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
            backBtn.IsEnabled = true;
        }

        private string FindPackageName()
        {
            if (user.Packages.GiJiuJitsu == true)
            {
                return "package_gi";
            }
            else if (user.Packages.NoGiJiuJitsu == true)
            {
                return "package_nogi";
            }
            else 
            {
                return "package_giandnogi";
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
          
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                Padding = new Thickness(10, 10, 10, 0);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

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
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

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
            }
        }
    }
}

