using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class EntryPage : ContentPage
    {
        //declare objects
        Grid outerGrid;
        Grid innerGrid;
        Image mahechaLogo;
        Button loginBtn;
        Button signUpBtn;

        public EntryPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
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
                FontFamily = "ChalkboardSE-Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            signUpBtn = new Button
            {
                Text = "Sign Up",
#if __IOS__
                FontFamily = "ChalkboardSE-Bold",
#endif
                FontSize = size * 2,
                BackgroundColor = Color.Orange,
				TextColor = Color.Black
            };
            //Button events
            loginBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new LoginPage());
            };
            signUpBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new SignUpPage());
            };


            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(signUpBtn, 0, 1);
            innerGrid.Children.Add(loginBtn, 0, 2);

            outerGrid.Children.Add(innerGrid);

            Content = outerGrid;
		}

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

            if (width > height) {
                Padding = new Thickness(10, 10, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 2);
                innerGrid.Children.Add(signUpBtn, 1, 0);
                innerGrid.Children.Add(loginBtn, 1, 1);
            } else {
				Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                innerGrid.Children.Add(loginBtn, 0, 1);
                innerGrid.Children.Add(signUpBtn, 0, 2);
            }
		}

	}
}

