using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.EntryPages;
using MahechaBJJ.Views.BlogPages;
using MahechaBJJ.Views.SignUpPages;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Threading.Tasks;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.SignUpPages;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using MahechaBJJ.Droid;
#endif

namespace MahechaBJJ.Views.EntryPages
{
    public class EntryPage : ContentPage
    {
        //viewModel
        private EntryPageViewModel _entryPageViewModel;
        private SummaryPageViewModel _summaryPageViewModel;
        private BaseViewModel _baseViewModel;
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Button loginBtn;
        private Button signUpBtn;
        private Button blogBtn;
        private Button restoreBtn;
        private Package package;
        private bool isButtonPressed;
#if __ANDROID__
        private Android.Widget.Button androidLoginBtn;
        private Android.Widget.Button androidSignUpBtn;
        private Android.Widget.Button androidBlogBtn;
        private Android.Widget.Button androidRestoreBtn;
#endif

        public EntryPage()
        {
            _entryPageViewModel = new EntryPageViewModel();
            _baseViewModel = new BaseViewModel();
            _summaryPageViewModel = new SummaryPageViewModel();
#if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            BuildPageObjects();
        }

        public void BuildPageObjects()
        {
            //outer Grid
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            //inner Grid
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //view objects
            mahechaLogo = new Image
            {
                Source = ImageSource.FromResource("mahechabjjlogo.png"),
                Aspect = Aspect.AspectFit
            };
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            loginBtn = new Button
            {
                Text = "Login",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size * 2,

#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black
            };
            signUpBtn = new Button
            {
                Text = "Sign Up",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size * 2,

#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black
            };
            blogBtn = new Button
            {
                Text = "Learn More",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = size * 2,

#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = size,
                Margin = -5,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black
            };

            restoreBtn = new Button();
            restoreBtn.Text = "Restore Packages";
            restoreBtn.FontFamily = "AmericanTypewriter-Bold";
            restoreBtn.FontSize = size * 1.5;
            restoreBtn.BackgroundColor = Color.FromRgb(58, 93, 174);
            restoreBtn.TextColor = Color.Black;
            restoreBtn.BorderWidth = 3;
            restoreBtn.BorderColor = Color.Black;
            restoreBtn.Clicked += CheckIfUserHasPackage;

#if __ANDROID__
            androidLoginBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidLoginBtn.Text = "Login";
            androidLoginBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidLoginBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidLoginBtn.SetTextColor(Android.Graphics.Color.Black);
            androidLoginBtn.Gravity = Android.Views.GravityFlags.Center;
            androidLoginBtn.SetAllCaps(false);

            androidSignUpBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidSignUpBtn.Text = "Sign Up";
            androidSignUpBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidSignUpBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidSignUpBtn.SetTextColor(Android.Graphics.Color.Black);
            androidSignUpBtn.Gravity = Android.Views.GravityFlags.Center;
            androidSignUpBtn.SetAllCaps(false);

            androidBlogBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidBlogBtn.Text = "Learn More";
            androidBlogBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidBlogBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidBlogBtn.SetTextColor(Android.Graphics.Color.Black);
            androidBlogBtn.Gravity = Android.Views.GravityFlags.Center;
            androidBlogBtn.SetAllCaps(false);

            androidRestoreBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidRestoreBtn.Text = "Restore Packages";
            androidRestoreBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidRestoreBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidRestoreBtn.SetTextColor(Android.Graphics.Color.Black);
            androidRestoreBtn.Gravity = Android.Views.GravityFlags.Center;
            androidRestoreBtn.SetAllCaps(false);
#endif

            //Button events
#if __ANDROID__
            //androidLoginBtn.Click += Login;
            androidLoginBtn.Click += async (object sender, EventArgs e) => {
                /*if (isButtonPressed)
                {
                    return;
                }
                else 
                {
                    isButtonPressed = true;
                    await Navigation.PushModalAsync(new LoginPage());
                }
                isButtonPressed = false;*/
                ToggleButtons();
                await Navigation.PushModalAsync(new LoginPage());
                ToggleButtons();
            };

            androidSignUpBtn.Click += SignUp;

            androidBlogBtn.Click += Blog;
#endif
#if __IOS__
            loginBtn.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushModalAsync(new LoginPage());
            };

            signUpBtn.Clicked += (sender, args) =>
            {
                Navigation.PushModalAsync(new PackagePage());
            };

            blogBtn.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new BlogViewPage());

            };
#endif

            //building Grid
#if __ANDROID__
            innerGrid.Children.Add(androidLoginBtn.ToView(), 0, 1);
            innerGrid.Children.Add(androidSignUpBtn.ToView(), 0, 2);
            innerGrid.Children.Add(androidBlogBtn.ToView(), 0, 3);
            innerGrid.Children.Add(androidRestoreBtn.ToView(), 0, 4);
#endif
#if __IOS__
            innerGrid.Children.Add(loginBtn, 0, 1);
            innerGrid.Children.Add(signUpBtn, 0, 2);
            innerGrid.Children.Add(blogBtn, 0, 3);
            innerGrid.Children.Add(restoreBtn, 0, 4);
#endif


            innerGrid.Children.Add(mahechaLogo, 0, 0);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private async void CheckIfUserHasPackage(object sender, EventArgs e)
        {
            ToggleButtons();
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
                ToggleButtons();
            }
        }

        private void Restore()
        {
            _summaryPageViewModel.SavePackageInfoWithNoAccount(package);
            Application.Current.MainPage = new MainTabbedPage(false);
            ToggleButtons();
        }

        private void ToggleButtons()
        {
#if __ANDROID__
            androidLoginBtn.Clickable = !androidLoginBtn.Clickable;
            androidSignUpBtn.Clickable = !androidSignUpBtn.Clickable;
            androidBlogBtn.Clickable = !androidBlogBtn.Clickable;
#endif
            loginBtn.IsEnabled = !loginBtn.IsEnabled;
            signUpBtn.IsEnabled = !signUpBtn.IsEnabled;
            blogBtn.IsEnabled = !blogBtn.IsEnabled;
            restoreBtn.IsEnabled = !restoreBtn.IsEnabled;
        }

        private void Login(object sender, EventArgs e)
        {
#if __ANDROID__
            androidLoginBtn.Click -= Login;
            Navigation.PushModalAsync(new LoginPage());
            androidLoginBtn.Click += Login;
#endif
        }

        private void SignUp(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PushModalAsync(new PackagePage());
            ToggleButtons();
        }

        private void Blog(object sender, EventArgs e)
        {
            ToggleButtons();
            Navigation.PushModalAsync(new BlogViewPage());
            ToggleButtons();
        }

        //Orientation
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
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 4);

#if __ANDROID__
                innerGrid.Children.Add(androidLoginBtn.ToView(), 1, 0);
                innerGrid.Children.Add(androidSignUpBtn.ToView(), 1, 1);
                innerGrid.Children.Add(androidBlogBtn.ToView(), 1, 2);
                innerGrid.Children.Add(androidRestoreBtn.ToView(), 1, 3);
#endif
#if __IOS__
                innerGrid.Children.Add(loginBtn, 1, 0);
                innerGrid.Children.Add(signUpBtn, 1, 1);
                innerGrid.Children.Add(blogBtn, 1, 2);
                innerGrid.Children.Add(restoreBtn, 1, 3);
#endif
            }
            else
            {
#if __ANDROID__
                Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
                 Padding = new Thickness(10, 30, 10, 10);
#endif
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);

#if __ANDROID__
                innerGrid.Children.Add(androidLoginBtn.ToView(), 0, 1);
                innerGrid.Children.Add(androidSignUpBtn.ToView(), 0, 2);
                innerGrid.Children.Add(androidBlogBtn.ToView(), 0, 3);
                innerGrid.Children.Add(androidRestoreBtn.ToView(), 0, 4);
#endif
#if __IOS__
                innerGrid.Children.Add(loginBtn, 0, 1);
                innerGrid.Children.Add(signUpBtn, 0, 2);
                innerGrid.Children.Add(blogBtn, 0, 3);
                innerGrid.Children.Add(restoreBtn, 0, 4);
#endif
            }
        }
        //functions

    }
}

