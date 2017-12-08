﻿using System;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class PackagePage : ContentPage
    {
        private Grid innerGrid;
        private Grid outerGrid;
        private Frame giFrame;
        private Frame noGiFrame;
        private Button backBtn;
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
                HasShadow = false,
                Content = noGiScrollView
            };

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
            giStackLayout.Children.Add(giTitle);
            giStackLayout.Children.Add(giPrice);
            giStackLayout.Children.Add(giBody);
            giStackLayout.Orientation = StackOrientation.Vertical;
            noGiStackLayout.Children.Add(noGiTitle);
            noGiStackLayout.Children.Add(noGiPrice);
            noGiStackLayout.Children.Add(noGiBody);
            noGiStackLayout.Orientation = StackOrientation.Vertical;
            innerGrid.Children.Add(giFrame, 0, 0);
            innerGrid.Children.Add(noGiFrame, 0, 1);
            innerGrid.Children.Add(backBtn, 0, 2);
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

                innerGrid.Children.Add(giFrame, 0, 0);
                Grid.SetColumnSpan(giFrame, 2);
                innerGrid.Children.Add(noGiFrame, 2, 0);
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giFrame, 0, 0);
                innerGrid.Children.Add(noGiFrame, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
            }
        }
    }
}

