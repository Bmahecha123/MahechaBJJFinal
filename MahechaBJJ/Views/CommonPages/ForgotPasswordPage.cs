using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

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

        public ForgotPasswordPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
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

            headerLbl = new Label
            {
                Text = "Forgot Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.StartAndExpand
            };


            emailLbl = new Label
            {
                Text = "E-Mail Address",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center                 
            };

            emailEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = entrySize * 1.25,
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
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Next",
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            //events
            backBtn.Clicked += GoBack;
            nextBtn.Clicked += CheckIfUserExists;

            //building layouts
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
        }

        private void GoBack(Object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            Navigation.PopModalAsync();
            backBtn.IsEnabled = true;
        }

        private async void CheckIfUserExists(Object sender, EventArgs e)
        {
            nextBtn.IsEnabled = false;
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
            nextBtn.IsEnabled = true;
        }
    }
}

