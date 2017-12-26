using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.CommonPages
{
    public class PurchasePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private Account account;
        private Grid outerGrid;
        private Grid innerGrid;
        private Grid buttonGrid;
        private Frame giFrame;
        private Frame noGiFrame;
        private ScrollView giScrollView;
        private ScrollView noGiScrollView;
        private StackLayout giStackLayout;
        private StackLayout noGiStackLayout;
        private Label giTitle;
        private Label giPrice;
        private Label giBody;
        private Label noGiTitle;
        private Label noGiPrice;
        private Label noGiBody;
        private Button backBtn;
        private Button purchaseBtn;
        private Package package;

        public PurchasePage(Package package)
        {
            _baseViewModel = new BaseViewModel();
            account = _baseViewModel.GetAccountInformation();
            this.package = package;
            Padding = new Thickness(10, 30, 10, 10);

            SetContent();
        }

        private void SetContent()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}                }
            };

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(9, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

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

            giStackLayout = new StackLayout();
            noGiStackLayout = new StackLayout();

            #region GI
            giTitle = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Gi",
                FontSize = lblSize * 2,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "$19.99",
                FontSize = lblSize * 1.5,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giBody = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "",
                FontSize = lblSize,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giScrollView = new ScrollView
            {
                Content = giStackLayout
            };

            giFrame = new Frame
            {
                OutlineColor = Color.Black,
                Content = giScrollView,
                HasShadow = false
            };
            #endregion
            #region NOGI
            noGiTitle = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "No-Gi",
                FontSize = lblSize * 2,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "$19.99",
                FontSize = lblSize * 1.5,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiBody = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "",
                FontSize = lblSize,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiScrollView = new ScrollView
            {
                Content = noGiStackLayout
            };

            noGiFrame = new Frame
            {
                OutlineColor = Color.Black,
                Content = noGiScrollView,
                HasShadow = false
            };
            #endregion

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

            purchaseBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Purchase",
                FontSize = btnSize * 1.5,
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            //events
            backBtn.Clicked += (object sender, EventArgs e) => {
                Navigation.PopModalAsync();
            };
            purchaseBtn.Clicked += (object sender, EventArgs e) => {
                //insert logic for Itunes or Play Store APIS
                account.Properties.Remove("Package");
                account.Properties.Add("Package", "GiAndNoGi");
                _baseViewModel.UpdateCredentials(account);
                DisplayAlert("Successfully Purchased Package", "You have successfully purchased this package", "Ok");
                Navigation.PopModalAsync();
            };

            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(purchaseBtn, 1, 0);

            giStackLayout.Children.Add(giTitle);
            giStackLayout.Children.Add(giPrice);
            giStackLayout.Children.Add(giBody);
            giStackLayout.Orientation = StackOrientation.Vertical;
            noGiStackLayout.Children.Add(noGiTitle);
            noGiStackLayout.Children.Add(noGiPrice);
            noGiStackLayout.Children.Add(noGiBody);
            noGiStackLayout.Orientation = StackOrientation.Vertical;

            if (this.package == Package.Gi)
            {
                innerGrid.Children.Add(giFrame, 0, 0);
            }
            else 
            {
                innerGrid.Children.Add(noGiFrame, 0, 0);
            }

            innerGrid.Children.Add(buttonGrid, 0, 1);
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }
    }
}

