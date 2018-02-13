using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views.SignUpPages
{
    public class AccountInfoPage : ContentPage
    {
        private Grid innerGrid;
        private Grid outerGrid;
        private StackLayout accountStackLayout;
        private ScrollView accountScrollView;
        private Frame accountFrame;
        private Button backBtn;
        private Label accountTitle;
        private Label accountInfo;
        private Button accountBtn;
        private Button noAccountBtn;
        private Package package;

        public AccountInfoPage(Package package)
        {
            #if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            this.package = package;
            BuildPageObjects();
            SetContent();
        }

        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            innerGrid = new Grid();
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            outerGrid = new Grid();
            outerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            accountTitle = new Label();
            accountTitle.FontFamily = "AmericanTypewriter-Bold";
            accountTitle.FontSize = lblSize * 2;
            accountTitle.Text = "Mahecha BJJ Account";
            accountTitle.TextColor = Color.Black;
            accountTitle.FontAttributes = FontAttributes.Bold;

            accountInfo = new Label();
            accountInfo.FontFamily = "AmericanTypewriter-Bold";
            accountInfo.FontSize = lblSize;
            accountInfo.Text = "-Ability to create and manage you're own playlists.\n-Access to Mahecha BJJ Web Application(Coming soon)";
            accountInfo.TextColor = Color.Black;

            accountBtn = new Button();
            accountBtn.FontFamily = "AmericanTypewriter-Bold";
            accountBtn.FontSize = btnSize * 2;
            accountBtn.Text = "Create";
            accountBtn.BackgroundColor = Color.FromRgb(58, 93, 174);
            accountBtn.TextColor = Color.Black;
            accountBtn.BorderWidth = 3;
            accountBtn.BorderColor = Color.Black;
            accountBtn.Clicked += (sender, e) => {
                Navigation.PushModalAsync(new SignUpPage(package));
            };

            noAccountBtn = new Button();
            noAccountBtn.FontFamily = "AmericanTypewriter-Bold";
            noAccountBtn.FontSize = btnSize * 2;
            noAccountBtn.Text = "No Account";
            noAccountBtn.BackgroundColor = Color.DarkRed;
            noAccountBtn.TextColor = Color.Black;
            noAccountBtn.BorderWidth = 3;
            noAccountBtn.BorderColor = Color.Black;
            noAccountBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PushModalAsync(new SummaryPage(package));
            };

            backBtn = new Button();
            backBtn.FontFamily = "AmericanTypewriter-Bold";
            backBtn.FontSize = btnSize * 2;
            backBtn.Text = "Back";
            backBtn.BackgroundColor = Color.FromRgb(124, 37, 41);
            backBtn.TextColor = Color.Black;
            backBtn.VerticalOptions = LayoutOptions.FillAndExpand;
            backBtn.HorizontalOptions = LayoutOptions.FillAndExpand;
            backBtn.BorderWidth = 3;
            backBtn.BorderColor = Color.Black;
            backBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PopModalAsync();
            };
        }

        private void SetContent()
        {
            accountStackLayout = new StackLayout();
            accountStackLayout.Children.Add(accountTitle);
            accountStackLayout.Children.Add(accountInfo);

            accountScrollView = new ScrollView();
            accountScrollView.Content = accountStackLayout;

            accountFrame = new Frame();
            accountFrame.OutlineColor = Color.Black;
            accountFrame.HasShadow = false;
            accountFrame.BackgroundColor = Color.FromRgb(58, 93, 174);
            accountFrame.Content = accountScrollView;

            innerGrid.Children.Add(accountFrame, 0, 0);
            innerGrid.Children.Add(accountBtn, 0, 1);
            innerGrid.Children.Add(noAccountBtn, 0, 2);
            innerGrid.Children.Add(backBtn, 0, 3);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }
    }
}

