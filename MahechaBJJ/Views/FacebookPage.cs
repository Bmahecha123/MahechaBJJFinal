using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class FacebookPage : ContentPage
    {
        Label lbl;
        Button facebookBtn;
        StackLayout layout;

        public FacebookPage()
        {
            lbl = new Label
            {
                Text = "Login with Facebook API",
                FontSize = 66,
                TextColor = Color.Blue
            };
            facebookBtn = new Button
            {
                Text = "Login with Facebook!",
                TextColor = Color.White,
                BackgroundColor = Color.Blue,
                FontAttributes = FontAttributes.Bold,
                FontSize = 36
            };
            layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    lbl,
                    facebookBtn
                }
            };
            //events
            facebookBtn.Clicked += LoginWithFacebook;

            Content = layout;
        }

        private async void LoginWithFacebook(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfilePage());
        }
    }
}
