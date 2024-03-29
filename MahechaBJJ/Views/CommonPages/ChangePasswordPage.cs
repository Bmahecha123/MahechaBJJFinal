﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.EntryPages;
using MahechaBJJ.Resources;
using Xamarin.Forms;
using System.Threading.Tasks;
#if __ANDROID__
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using MahechaBJJ.Droid;
using Android.Text.Method;
#endif

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
#if __ANDROID__
        private Grid innerGrid;
        private Grid outerGrid;
        private Android.Widget.TextView androidSecretQuestionLbl;
        private Android.Widget.EditText androidSecretQuestionEntry;
        private Android.Widget.TextView androidNewPasswordLbl;
        private Android.Widget.EditText androidNewPasswordEntry;
        private Android.Widget.Button androidSubmitBtn;

        private ContentView contentViewAndroidSecretQuestionLbl;
        private ContentView contentViewAndroidSecretQuestionEntry;
        private ContentView contentViewAndroidNewPasswordLbl;
        private ContentView contentViewAndroidNewPasswordEntry;
        private ContentView contentViewAndroidSubmitBtn;
#endif

        public ChangePasswordPage(User user)
        {
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Color.FromHex("#F1ECCE");
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
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
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star)}
                }
            };

            headerLbl = new Label
            {
                Text = "Change Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
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
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            secretQuestionEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = entrySize * .75,
#endif
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            newPasswordLbl = new Label
            {
                Text = "New Password",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            newPasswordEntry = new Entry
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = entrySize * .75,
#endif
                IsPassword = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            backBtn = new Button
            {
                Image = "back.png",
                Style = (Style)Application.Current.Resources["common-red-btn"]
            };

            submitBtn = new Button
            {
                Style = (Style)Application.Current.Resources["common-blue-btn"],

#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize * .75,
#endif
                Text = "Submit"
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            innerGrid = new Grid();
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });

            outerGrid = new Grid();
            outerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            androidSecretQuestionLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidSecretQuestionLbl.Text = _user.SecretQuestion;
            androidSecretQuestionLbl.Typeface = Constants.COMMONFONT;
            androidSecretQuestionLbl.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidSecretQuestionLbl.SetTextColor(Android.Graphics.Color.Black);
            androidSecretQuestionLbl.Gravity = Android.Views.GravityFlags.Center;

            androidSecretQuestionEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidSecretQuestionEntry.Typeface = Constants.COMMONFONT;
            androidSecretQuestionEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidSecretQuestionEntry.SetTextColor(Android.Graphics.Color.Black);
            androidSecretQuestionEntry.Gravity = Android.Views.GravityFlags.Start;
            androidSecretQuestionEntry.InputType = Android.Text.InputTypes.TextVariationShortMessage;

            androidNewPasswordLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidNewPasswordLbl.Text = "New Password";
            androidNewPasswordLbl.Typeface = Constants.COMMONFONT;
            androidNewPasswordLbl.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidNewPasswordLbl.SetTextColor(Android.Graphics.Color.Black);
            androidNewPasswordLbl.Gravity = Android.Views.GravityFlags.Center;

            androidNewPasswordEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidNewPasswordEntry.Typeface = Constants.COMMONFONT;
            androidNewPasswordEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidNewPasswordEntry.SetTextColor(Android.Graphics.Color.Black);
            androidNewPasswordEntry.Gravity = Android.Views.GravityFlags.Start;
            androidNewPasswordEntry.InputType = Android.Text.InputTypes.TextVariationPassword;
            androidNewPasswordEntry.TransformationMethod = new PasswordTransformationMethod();

            androidSubmitBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidSubmitBtn.Text = "Change Password";
            androidSubmitBtn.Typeface = Constants.COMMONFONT;
            androidSubmitBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidSubmitBtn.SetTextColor(Android.Graphics.Color.Rgb(242, 253, 255));
            androidSubmitBtn.SetBackground(pd);
            androidSubmitBtn.SetAllCaps(false);
            androidSubmitBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await ChangePassword(sender, e);
                ToggleButtons();
            };

            contentViewAndroidSecretQuestionLbl = new ContentView();
            contentViewAndroidSecretQuestionLbl.Content = androidSecretQuestionLbl.ToView();

            contentViewAndroidSecretQuestionEntry = new ContentView();
            contentViewAndroidSecretQuestionEntry.Content = androidSecretQuestionEntry.ToView();

            contentViewAndroidNewPasswordLbl = new ContentView();
            contentViewAndroidNewPasswordLbl.Content = androidNewPasswordLbl.ToView();

            contentViewAndroidNewPasswordEntry = new ContentView();
            contentViewAndroidNewPasswordEntry.Content = androidNewPasswordEntry.ToView();

            contentViewAndroidSubmitBtn = new ContentView();
            contentViewAndroidSubmitBtn.Content = androidSubmitBtn.ToView();
#endif

            //events
            backBtn.Clicked += (sender, e) =>
            {
                backBtn.IsEnabled = false;
                Navigation.PopModalAsync();
                backBtn.IsEnabled = true;
            };
            submitBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await ChangePassword(sender, e);
                ToggleButtons();
            };

            //layout
#if __ANDROID__
            innerGrid.Children.Add(contentViewAndroidSecretQuestionLbl, 0, 3);
            innerGrid.Children.Add(contentViewAndroidSecretQuestionEntry, 0, 4);
            innerGrid.Children.Add(contentViewAndroidNewPasswordLbl, 0, 6);
            innerGrid.Children.Add(contentViewAndroidNewPasswordEntry, 0, 7);
            innerGrid.Children.Add(contentViewAndroidSubmitBtn, 0, 10);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
#endif
#if __IOS__
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(submitBtn, 1, 0);

            stackLayout.Children.Add(headerLbl);
            stackLayout.Children.Add(secretQuestionLbl);
            stackLayout.Children.Add(secretQuestionEntry);
            stackLayout.Children.Add(newPasswordLbl);
            stackLayout.Children.Add(newPasswordEntry);
            stackLayout.Children.Add(buttonGrid);

            scrollView.Content = stackLayout;

            Content = scrollView;
#endif
        }

        //Events

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            submitBtn.IsEnabled = !submitBtn.IsEnabled;
#if __ANDROID__
            androidSubmitBtn.Clickable = !androidSubmitBtn.Clickable;
#endif
        }

        public async Task ChangePassword(object sender, EventArgs e)
        {
#if __IOS__
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
#endif
#if __ANDROID__
            bool success = await _baseViewModel.ChangePassword(_user.Id, androidSecretQuestionEntry.Text.ToLower(), androidNewPasswordEntry.Text);
            if (success)
            {
                await DisplayAlert("Password Updated", "Password has been successfully updated.", "Ok");
                if (Navigation.ModalStack.Count > 1)
                {
                    Application.Current.MainPage = new EntryPage();
                }
                else
                {
                    await Navigation.PopModalAsync();
                }
            }
            else
            {
                await DisplayAlert("Password Not Updated", "Password has not been updated, please try again.", "Ok");
            }
#endif
        }
    }
}

