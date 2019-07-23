using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.EntryPages;
using MahechaBJJ.Resources;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MahechaBJJ.Views.CommonPages
{
    public class ChangePasswordPage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private Label headerLbl;
        private Label secretQuestionLbl;
        private Entry secretQuestionEntry;
        private Label newPasswordLbl;
        private Entry newPasswordEntry;
        private Button backBtn;
        private Button submitBtn;
        private User _user;

        public ChangePasswordPage(User user)
        {
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Color.FromHex("#F1ECCE");
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;
            Title = "Change Password";
            _user = user;

            BuildPageObjects();

            Content = flexLayout;
        }

        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            headerLbl = new Label
            {
                Text = "Change Password",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            secretQuestionLbl = new Label
            {
                Text = _user.SecretQuestion,
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            secretQuestionEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                BackgroundColor = Theme.Azure,
                TextColor = Theme.Black
            };

            newPasswordLbl = new Label
            {
                Text = "New Password",
                TextColor = Theme.Black,
                FontFamily = Theme.Font,
                FontSize = lblSize
            };

            newPasswordEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                IsPassword = true,
                TextColor = Theme.Black,
                BackgroundColor = Theme.Azure
            };

            backBtn = new Button
            {
                ImageSource = "back.png",
                Style = Theme.RedButton,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            submitBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Submit",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

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

            FlexLayout.SetAlignSelf(headerLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(secretQuestionLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(newPasswordLbl, FlexAlignSelf.Center);

            //layout
#if __IOS__

            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(submitBtn);

            flexLayout.Children.Clear();
            flexLayout.Children.Add(headerLbl);
            flexLayout.Children.Add(secretQuestionLbl);
            flexLayout.Children.Add(secretQuestionEntry);
            flexLayout.Children.Add(newPasswordLbl);
            flexLayout.Children.Add(newPasswordEntry);
            flexLayout.Children.Add(buttonStackLayout);
        }

        //Events

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            submitBtn.IsEnabled = !submitBtn.IsEnabled;
        }

        public async Task ChangePassword(object sender, EventArgs e)
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

