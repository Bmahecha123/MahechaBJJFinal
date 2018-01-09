using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.EntryPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.CommonPages
{
    public class ChangePasswordPage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private StackLayout stackLayout;
        private ScrollView scrollView;
        private Label headerLbl;
        private Label secretQuestionLbl;
        private Entry secretQuestionEntry;
        private Label newPasswordLbl;
        private Entry newPasswordEntry;
        private Button backBtn;
        private Button submitBtn;
        private Grid buttonGrid;
        private User _user;

        public ChangePasswordPage(User user)
        {
            _baseViewModel = new BaseViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            Title = "Change Password";
            _user = user;
            BuildPageObjects();
            // add view objects.
            //set objects.
            //back button
        }

        private void BuildPageObjects() 
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            stackLayout = new StackLayout();
            scrollView = new ScrollView();
            buttonGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}

                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };

            headerLbl = new Label
            {
                Text = "Change Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 2,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            secretQuestionLbl = new Label
            {
                Text = _user.SecretQuestion,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            secretQuestionEntry = new Entry
            {
                #if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = entrySize * 1.5,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            newPasswordLbl = new Label
            {
                Text = "New Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 1.5,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            newPasswordEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = entrySize * 1.5,
                IsPassword = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
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

            submitBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Change Password",
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            //events
            backBtn.Clicked += (sender, e) => {
                backBtn.IsEnabled = false;
                Navigation.PopModalAsync();
                backBtn.IsEnabled = true;
            };
            submitBtn.Clicked += ChangePassword;

            //layout
            buttonGrid.Children.Add(backBtn, 0, 1);
            buttonGrid.Children.Add(submitBtn, 0, 0);
            stackLayout.Children.Add(headerLbl);
            stackLayout.Children.Add(secretQuestionLbl);
            stackLayout.Children.Add(secretQuestionEntry);
            stackLayout.Children.Add(newPasswordLbl);
            stackLayout.Children.Add(newPasswordEntry);
            stackLayout.Children.Add(buttonGrid);

            scrollView.Content = stackLayout;

            Content = scrollView;
        }

        //Events

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            submitBtn.IsEnabled = !submitBtn.IsEnabled;
        }

        public async void ChangePassword(object sender, EventArgs e) 
        {
            ToggleButtons();
            bool success = await _baseViewModel.ChangePassword(_user.Id, secretQuestionEntry.Text.ToLower(), newPasswordEntry.Text);
            if (success)
            {
                await DisplayAlert("Password Updated", "Password has been successfully updated.", "Ok");
                if(Navigation.ModalStack.Count > 1)
                {
                    Application.Current.MainPage = new EntryPage();
                } else {
                    await Navigation.PopModalAsync();
                }
            } else {
                await DisplayAlert("Password Not Updated", "Password has not been updated, please try again.", "Ok");
            }
            ToggleButtons();
        }
    }
}

