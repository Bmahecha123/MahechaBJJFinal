using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.SignUpPages
{
    public class PackagePage : ContentPage
    {
        private Package package;
        private Grid innerGrid;
        private Grid outerGrid;
        private Frame giFrame;
        private Frame noGiFrame;
        private Frame giAndNoGiFrame;
        private Button backBtn;
        private ScrollView giScrollView;
        private ScrollView noGiScrollView;
        private ScrollView giAndNoGiScrollView;
        private StackLayout giStackLayout;
        private StackLayout noGiStackLayout;
        private StackLayout giAndNoGiStackLayout;
        private TapGestureRecognizer giTap;
        private TapGestureRecognizer noGiTap;
        private TapGestureRecognizer giAndNoGiTap;
        private Label giTitle;
        private Label giPrice;
        private Label giBody;
        private Label noGiTitle;
        private Label noGiPrice;
        private Label noGiBody;
        private Label giAndNoGiTitle;
        private Label giAndNoGiPrice;
        private Label giAndNoGiBody;

        public PackagePage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
            SetContent();
        }

        private void BuildPageObjects()
        {
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            giAndNoGiStackLayout = new StackLayout();
            giStackLayout = new StackLayout();
            noGiStackLayout = new StackLayout();

            backBtn = new Button
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Back",
                FontSize = btnSize * 2,
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
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

            giTap = new TapGestureRecognizer();
            giTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new SignUpPage(Package.Gi));
            };
            giStackLayout.GestureRecognizers.Add(giTap);

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

            noGiTap = new TapGestureRecognizer();
            noGiTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new SignUpPage(Package.NoGi));
            };
            noGiStackLayout.GestureRecognizers.Add(noGiTap);

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
            #region GIANDNOGI
            giAndNoGiTitle = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Complete Jiu-Jitsu",
                FontSize = lblSize * 2,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giAndNoGiPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "$29.99",
                FontSize = lblSize * 1.5,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giAndNoGiBody = new Label
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

            giAndNoGiTap = new TapGestureRecognizer();
            giAndNoGiTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new SignUpPage(Package.GiAndNoGi));
            };
            giAndNoGiStackLayout.GestureRecognizers.Add(giAndNoGiTap);


            giAndNoGiScrollView = new ScrollView
            {
                Content = giAndNoGiStackLayout
            };

            giAndNoGiFrame = new Frame
            {
                OutlineColor = Color.Black,
                HasShadow = false,
                Content = giAndNoGiScrollView
            };
#endregion
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
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //events
            backBtn.Clicked += (object sender, EventArgs e) => {
                backBtn.IsEnabled = false;
                Navigation.PopModalAsync();
                backBtn.IsEnabled = true;
            };
        }

        private void SetContent() 
        {
            giAndNoGiStackLayout.Children.Add(giAndNoGiTitle);
            giAndNoGiStackLayout.Children.Add(giAndNoGiPrice);
            giAndNoGiStackLayout.Children.Add(giAndNoGiBody);
            giAndNoGiStackLayout.Orientation = StackOrientation.Vertical;
            giStackLayout.Children.Add(giTitle);
            giStackLayout.Children.Add(giPrice);
            giStackLayout.Children.Add(giBody);
            giStackLayout.Orientation = StackOrientation.Vertical;
            noGiStackLayout.Children.Add(noGiTitle);
            noGiStackLayout.Children.Add(noGiPrice);
            noGiStackLayout.Children.Add(noGiBody);
            noGiStackLayout.Orientation = StackOrientation.Vertical;
            innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
            innerGrid.Children.Add(giFrame, 0, 1);
            innerGrid.Children.Add(noGiFrame, 0, 2);
            innerGrid.Children.Add(backBtn, 0, 3);
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                Padding = new Thickness(10, 10, 10, 10);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star)});
                innerGrid.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                Grid.SetColumnSpan(giFrame, 2);
                innerGrid.Children.Add(giFrame, 2, 0);
                Grid.SetColumnSpan(giFrame, 2);
                innerGrid.Children.Add(noGiFrame, 4, 0);
                Grid.SetColumnSpan(noGiFrame, 2);
                innerGrid.Children.Add(backBtn, 1, 1);
                Grid.SetColumnSpan(backBtn, 2);
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                innerGrid.Children.Add(giFrame, 0, 1);
                innerGrid.Children.Add(noGiFrame, 0, 2);
                innerGrid.Children.Add(backBtn, 0, 3);
            }
        }
    }
}

