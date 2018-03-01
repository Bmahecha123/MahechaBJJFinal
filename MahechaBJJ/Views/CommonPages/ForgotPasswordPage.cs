using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;
#if __ANDROID__
using MahechaBJJ.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
#endif

namespace MahechaBJJ.Views.CommonPages
{
    public class ForgotPasswordPage : ContentPage
    {
        private StackLayout stackLayout;
        private StackLayout entryLayout;
        private Grid buttonGrid;
        private Label headerLbl;
        private Label emailLbl;
        private Entry emailEntry;
        private Button backBtn;
        private Button nextBtn;
        private BaseViewModel _baseViewModel;
        private User user;
#if __ANDROID__
        private Grid outerGrid;
        private Grid innerGrid;
        private Android.Widget.TextView androidHeaderLbl;
        private Android.Widget.TextView androidEmailLbl;
        private Android.Widget.EditText androidEmailEntry;
        private Android.Widget.Button androidNextBtn;

        private ContentView contentViewHeaderLbl;
        private ContentView contentViewEmailLbl;
        private ContentView contentViewEmailEntry;
        private ContentView contentViewNextBtn;
#endif

        public ForgotPasswordPage()
        {
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            Title = "Forgot Password";
            _baseViewModel = new BaseViewModel();
            BuildPageObjects();
        }

        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            stackLayout = new StackLayout();
            entryLayout = new StackLayout();
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

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };

            androidHeaderLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidHeaderLbl.Text = "Forgot Password";
            androidHeaderLbl.Typeface = Constants.COMMONFONT;
            androidHeaderLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidHeaderLbl.SetTextColor(Android.Graphics.Color.Black);
            androidHeaderLbl.Gravity = Android.Views.GravityFlags.Center;

            androidEmailLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidEmailLbl.Text = "E-Mail Address";
            androidEmailLbl.Typeface = Constants.COMMONFONT;
            androidEmailLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidEmailLbl.SetTextColor(Android.Graphics.Color.Black);
            androidEmailLbl.Gravity = Android.Views.GravityFlags.Center;

            androidEmailEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidEmailEntry.Hint = "Enter E-Mail";
            androidEmailEntry.Typeface = Constants.COMMONFONT;
            androidEmailEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidEmailEntry.SetTextColor(Android.Graphics.Color.Black);
            androidEmailEntry.Gravity = Android.Views.GravityFlags.Center;
            androidEmailEntry.InputType = Android.Text.InputTypes.TextVariationEmailAddress;

            androidNextBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidNextBtn.Text = "Next";
            androidNextBtn.Typeface = Constants.COMMONFONT;
            androidNextBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidNextBtn.SetTextColor(Android.Graphics.Color.Black);
            androidNextBtn.Gravity = Android.Views.GravityFlags.Center;
            androidNextBtn.SetBackground(pd);
            androidNextBtn.Click += async (object sender, EventArgs e) => {
                ToggleButtons();
                await CheckIfUserExists(sender, e);
                ToggleButtons();
            };

            contentViewHeaderLbl = new ContentView();
            contentViewHeaderLbl.Content = androidHeaderLbl.ToView();
            contentViewEmailLbl = new ContentView();
            contentViewEmailLbl.Content = androidEmailLbl.ToView();
            contentViewEmailEntry = new ContentView();
            contentViewEmailEntry.Content = androidEmailEntry.ToView();
            contentViewNextBtn = new ContentView();
            contentViewNextBtn.Content = androidNextBtn.ToView();
#endif

            headerLbl = new Label
            {
                Text = "Forgot Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.StartAndExpand
            };


            emailLbl = new Label
            {
                Text = "E-Mail Address",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            emailEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize * 1.25,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = entrySize * .75,
#endif
                Placeholder = "Enter E-Mail"
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

            nextBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                Text = "Next",
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            //events
            backBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            nextBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await CheckIfUserExists(sender, e);
                ToggleButtons();
            }; 

            //building layouts
#if __ANDROID__
            innerGrid.Children.Add(contentViewHeaderLbl, 0, 0);
            innerGrid.Children.Add(contentViewEmailLbl, 0, 3);
            innerGrid.Children.Add(contentViewEmailEntry, 0, 4);
            innerGrid.Children.Add(contentViewNextBtn, 0, 7);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
#endif
#if __IOS__
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(nextBtn, 1, 0);

            entryLayout.Children.Add(emailLbl);
            entryLayout.Children.Add(emailEntry);
            entryLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            entryLayout.VerticalOptions = LayoutOptions.FillAndExpand;
            stackLayout.Children.Add(headerLbl);
            stackLayout.Children.Add(entryLayout);
            stackLayout.Children.Add(buttonGrid);

            Content = stackLayout;
#endif
        }

        private async Task CheckIfUserExists(Object sender, EventArgs e)
        {
            //logic to check if email exists
            if (emailEntry.Text != null){
                user = await _baseViewModel.GetUser(emailEntry.Text.ToLower());
                if (user != null)
                {
                    await Navigation.PushModalAsync(new ChangePasswordPage(user));
                } else {
                    await DisplayAlert("User Not Found", emailEntry.Text + " does not exist.", "Ok");
                }
            } else {
                await DisplayAlert("Empty Field", "Email Field is Empty, Fill In.", "Ok");
            }
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            nextBtn.IsEnabled = !nextBtn.IsEnabled;
#if __ANDROID__
            androidNextBtn.Clickable = !androidNextBtn.Clickable;
#endif
        }
    }
}

