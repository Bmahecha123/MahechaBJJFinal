using System;
#if __ANDROID__
using MahechaBJJ.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
#endif
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
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
#if __ANDROID__
        private Android.Widget.Button androidAccountBtn;
        private Android.Widget.Button androidNoAccountBtn;
        private Android.Widget.TextView androidAccountTitle;
        private Android.Widget.TextView androidAccountInfo;
#endif

        public AccountInfoPage(Package package)
        {
            BackgroundColor = Color.FromHex("#F1ECCE");

#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
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
#if __ANDROID__
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(6, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
#endif
#if __IOS__
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(4, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
#endif

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
            accountBtn.Style = (Style)Application.Current.Resources["common-blue-btn"];
            accountBtn.FontFamily = "AmericanTypewriter-Bold";
            accountBtn.FontSize = btnSize * 2;
            accountBtn.Text = "Create";
            accountBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new SignUpPage(package));
                ToggleButtons();
            };

            noAccountBtn = new Button();
            noAccountBtn.Style = (Style)Application.Current.Resources["common-red-btn"];
            noAccountBtn.FontFamily = "AmericanTypewriter-Bold";
            noAccountBtn.FontSize = btnSize * 2;
            noAccountBtn.Text = "No Account";
            noAccountBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new SummaryPage(package));
                ToggleButtons();
            };

            backBtn = new Button();
            backBtn.Style = (Style)Application.Current.Resources["common-red-btn"];
            backBtn.Image = "back.png";
            backBtn.VerticalOptions = LayoutOptions.FillAndExpand;
            backBtn.HorizontalOptions = LayoutOptions.FillAndExpand;
            backBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidNoAccountBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidNoAccountBtn.Text = "No Account";
            androidNoAccountBtn.Typeface = Constants.COMMONFONT;
            androidNoAccountBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidNoAccountBtn.SetBackground(pd);
            androidNoAccountBtn.SetTextColor(Android.Graphics.Color.Rgb(242, 253, 255));
            androidNoAccountBtn.Gravity = Android.Views.GravityFlags.Center;
            androidNoAccountBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new SummaryPage(package));
                ToggleButtons();
            };
            androidNoAccountBtn.SetAllCaps(false);

            androidAccountBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidAccountBtn.Text = "Create";
            androidAccountBtn.Typeface = Constants.COMMONFONT;
            androidAccountBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidAccountBtn.SetBackground(pd);
            androidAccountBtn.SetTextColor(Android.Graphics.Color.Rgb(242, 253, 255));
            androidAccountBtn.Gravity = Android.Views.GravityFlags.Center;
            androidAccountBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new SignUpPage(package));
                ToggleButtons();
            };
            androidAccountBtn.SetAllCaps(false);

            androidAccountTitle = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidAccountTitle.Text = "Mahecha BJJ Account";
            androidAccountTitle.Typeface = Constants.COMMONFONT;
            androidAccountTitle.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidAccountTitle.SetTextColor(Android.Graphics.Color.Black);
            androidAccountTitle.Gravity = Android.Views.GravityFlags.Center;
            androidAccountTitle.SetTypeface(androidAccountTitle.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidAccountInfo = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidAccountInfo.Text = "-Ability to create and manage you're own playlists.\n-Access to Mahecha BJJ Web Application(Coming soon)";
            androidAccountInfo.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidAccountInfo.Typeface = Constants.COMMONFONT;
            androidAccountInfo.SetTextColor(Android.Graphics.Color.Black);
            androidAccountInfo.Gravity = Android.Views.GravityFlags.Start;
#endif
        }

        private void SetContent()
        {
            accountStackLayout = new StackLayout();
#if __ANDROID__
            accountStackLayout.Children.Add(androidAccountTitle.ToView());
            accountStackLayout.Children.Add(androidAccountInfo.ToView());
#endif
#if __IOS__
            accountStackLayout.Children.Add(accountTitle);
            accountStackLayout.Children.Add(accountInfo);
#endif
            accountScrollView = new ScrollView();
            accountScrollView.Content = accountStackLayout;
#if __ANDROID__
            accountScrollView.IsClippedToBounds = true;
#endif

            accountFrame = new Frame();
            accountFrame.BorderColor = Color.Black;
            accountFrame.HasShadow = false;
            accountFrame.BackgroundColor = Color.FromRgb(57, 172, 166);
            accountFrame.Content = accountScrollView;
#if __ANDROID__
            innerGrid.Children.Add(accountFrame, 0, 0);
            innerGrid.Children.Add(androidAccountBtn.ToView(), 0, 1);
            innerGrid.Children.Add(androidNoAccountBtn.ToView(), 0, 2);
#endif
#if __IOS__
            innerGrid.Children.Add(accountFrame, 0, 0);
            innerGrid.Children.Add(accountBtn, 0, 1);
            innerGrid.Children.Add(noAccountBtn, 0, 2);
            innerGrid.Children.Add(backBtn, 0, 3);
#endif

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private void ToggleButtons()
        {
#if __ANDROID__
            androidAccountBtn.Clickable = !androidAccountBtn.Clickable;
            androidNoAccountBtn.Clickable = !androidNoAccountBtn.Clickable;
#endif
            accountBtn.IsEnabled = !accountBtn.IsEnabled;
            noAccountBtn.IsEnabled = !noAccountBtn.IsEnabled;
        }
    }
}

