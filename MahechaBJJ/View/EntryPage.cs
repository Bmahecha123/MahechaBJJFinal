using System;

using Xamarin.Forms;

namespace MahechaBJJ.View
{
    public class EntryPage : ContentPage
    {
        public EntryPage()
        {
            Padding = 30;
            //Grid view definition
            var grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }  
            };

            //view objects
            var mahechaLogo = new Image
            {
                Source = ImageSource.FromFile("mahechabjj.jpg"),
                Aspect = Aspect.AspectFit
            };
            var signInLabel = new Label
            {
                Text = "Sign up with",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center

            };
            var googleBtn = new Button
            {
                Text = "Google",
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            var facebookBtn = new Button
            {
                Text = "Facebook",
                BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            //Button events
            googleBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new GoogleSignInPage());
            };
            facebookBtn.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new FaceBookSignInPage());
            };

            //adding children to grid
            grid.Children.Add(mahechaLogo, 0, 0);
            grid.Children.Add(signInLabel, 0, 1);
            grid.Children.Add(googleBtn, 0, 2);
            grid.Children.Add(facebookBtn, 0 , 3);

			Content = grid;
        }
    }
}

