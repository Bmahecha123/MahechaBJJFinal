using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.CommonPages
{
    public class ForgotPasswordPage : ContentPage
    {
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private Label headerLbl;
        private Entry emailEntry;
        private Button backBtn;
        private Button nextBtn;
        private BaseViewModel _baseViewModel;
        private User user;

        public ForgotPasswordPage()
        {
            Padding = Theme.Thickness;
            Title = "Forgot Password";
            _baseViewModel = new BaseViewModel();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            BuildPageObjects();

            Content = flexLayout;
        }

        private void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            headerLbl = new Label
            {
                Text = "Forgot Password",
                FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black
            };

            emailEntry = new Entry
            {
                FontFamily = Theme.Font,
                FontSize = entrySize,
                Placeholder = "E-Mail Address",
                PlaceholderColor = Theme.Black,
                BackgroundColor = Theme.Azure,
                TextColor = Theme.Black
            };

            backBtn = new Button
            {
                ImageSource = "back.png",
                Style = Theme.RedButton,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            nextBtn = new Button
            {
                Style = Theme.BlueButton,
                ImageSource = "next.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
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

            FlexLayout.SetAlignSelf(headerLbl, FlexAlignSelf.Center);
            FlexLayout.SetAlignSelf(emailEntry, FlexAlignSelf.Center);

            FlexLayout.SetBasis(headerLbl, 1);
            FlexLayout.SetBasis(emailEntry, 1);

            FlexLayout.SetGrow(headerLbl, 1);
            FlexLayout.SetGrow(emailEntry, 1);

            //building layouts
            buttonStackLayout.Children.Add(backBtn);
            buttonStackLayout.Children.Add(nextBtn);

            flexLayout.Children.Add(headerLbl);
            flexLayout.Children.Add(emailEntry);
            flexLayout.Children.Add(buttonStackLayout);
        }

        private async Task CheckIfUserExists(Object sender, EventArgs e)
        {
            //logic to check if email exists
            if (emailEntry.Text != null)
            {
                user = await _baseViewModel.GetUser(emailEntry.Text.ToLower());
                if (user != null)
                {
                    await Navigation.PushModalAsync(new ChangePasswordPage(user));
                }
                else
                {
                    await DisplayAlert("User Not Found", emailEntry.Text + " does not exist.", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Empty Field", "Email Field is Empty, Fill In.", "Ok");
            }
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            nextBtn.IsEnabled = !nextBtn.IsEnabled;
        }
    }
}

