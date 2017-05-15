using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class GoogleSignInPage : ContentPage
    {
        public GoogleSignInPage()
        {
            Padding = 30;
			//Grid view definition
			var grid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
				}
			};
            //View objects
            var mahechaLogo = new Image
            {
                Source = ImageSource.FromFile("mahechabjj.jpg"),
                Aspect = Aspect.AspectFit
            };
            var signUpBtn = new Button
            {
                Text = "Sign Up",
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            //Events
            signUpBtn.Clicked += (sender, e) => {
                Navigation.PushModalAsync(new MainTabbedPage());  
            };

            grid.Children.Add(mahechaLogo, 0, 0);
            grid.Children.Add(signUpBtn, 0, 1);

            Content = grid;
        }
    }
}

