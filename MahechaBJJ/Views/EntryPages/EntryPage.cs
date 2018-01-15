using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.EntryPages;
using MahechaBJJ.Views.BlogPages;
using MahechaBJJ.Views.SignUpPages;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class EntryPage : ContentPage
    {
        //viewModel
        private EntryPageViewModel _entryPageViewModel;
        private const String VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Button loginBtn;
        private Button signUpBtn;
        private Button blogBtn;

        public EntryPage()
        {
            _entryPageViewModel = new EntryPageViewModel();
            #if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
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

            //Button events
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

            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(loginBtn, 0, 1);
            innerGrid.Children.Add(signUpBtn, 0, 2);
            innerGrid.Children.Add(blogBtn, 0, 3);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
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
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 3);
                innerGrid.Children.Add(loginBtn, 1, 0);
                innerGrid.Children.Add(signUpBtn, 1, 1);
                innerGrid.Children.Add(blogBtn, 1, 2);
            }
            else
            {
                #if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
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

                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                innerGrid.Children.Add(loginBtn, 0, 1);
                innerGrid.Children.Add(signUpBtn, 0, 2);
                innerGrid.Children.Add(blogBtn, 0, 3);

            }
        }
        //functions

    }
}

