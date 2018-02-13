using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.SignUpPages
{
    public class PackagePage : ContentPage
    {
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
        private Image giImage;
        private Frame giImageFrame;
        private Label noGiTitle;
        private Label noGiPrice;
        private Label noGiBody;
        private Image noGiImage;
        private Frame noGiImageFrame;
        private Label giAndNoGiTitle;
        private Label giAndNoGiPrice;
        private Label giAndNoGiBody;
        private Image giAndNoGiImage;
        private Frame giAndNoGiImageFrame;

        public PackagePage()
        {
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
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
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "Gi",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "$19.99",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giBody = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "This library is growing constantly and there is no end in sight. The beauty of this package is that you get to follow our system as we develop and implement new transitions and positions. We’re constantly pushing the barrier in terms of our style and approach to Jiu-Jitsu. Every position that gets posted has been drilled to death and executed at the highest levels of competition. We’re proud of this; something I see wrong with other instructional resources is positions are shown that I know they have never ever hit in a competition or anything. You never have to worry about that with our techniques. One of the biggest advantages of our app is that you have direct access to us, if you have any questions or concerns; contacting us is a click away. Let’s grow and develop our Jiu Jitsu together!",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giImage = new Image
            {
                Source = "gi.jpg",
                Aspect = Aspect.AspectFit
            };

            giImageFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 2,
                Content = giImage,
                HasShadow = false
            };

            giTap = new TapGestureRecognizer();
            giTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new AccountInfoPage(Package.Gi));
            };
            giStackLayout.GestureRecognizers.Add(giTap);

            giScrollView = new ScrollView
            {
                Content = giStackLayout,
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };

            giFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 5,
                Content = giScrollView,
                HasShadow = false
            };
            #endregion
            #region NOGI
            noGiTitle = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "No-Gi",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "$19.99",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiBody = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "Just like the other packages, the No-Gi library is constantly being updated. So that means you’ll grow along with us. As we come up with new tweaks and transitions you’ll see it first as we are constantly updating our libraries. Through these techniques and positions your game will be brought to a new technical level. All the while being exposed to a unique point of view on approaching Jiu Jitsu. Some of the biggest advantages of this package is that you have direct access to us, the ones who implement and recorded these techniques. We love to hear from our members and never ignore anyone. Lets grow together!",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            noGiImage = new Image
            {
                Source = "nogi6.jpeg",
                Aspect = Aspect.AspectFit
            };

            noGiImageFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 2,
                Content = noGiImage,
                HasShadow = false
            };

            noGiTap = new TapGestureRecognizer();
            noGiTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new AccountInfoPage(Package.NoGi));
            };
            noGiStackLayout.GestureRecognizers.Add(noGiTap);

            noGiScrollView = new ScrollView
            {
                Content = noGiStackLayout,
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };

            noGiFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 5,
                Content = noGiScrollView,
                HasShadow = false
            };
            #endregion
            #region GIANDNOGI
            giAndNoGiTitle = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "Complete Jiu-Jitsu",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giAndNoGiPrice = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * 1.5,
#endif
                Text = "$29.99",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giAndNoGiBody = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
#endif
                Text = "This package is the best of both worlds. Whenever any Jiu Jitsu position is uploaded to our database, you’ll get to see it right away. No other Jiu Jitsu apps post a disciplined system like this that gives you direct access to the ones who create, record and execute these techniques at the highest levels of competition. We love Jiu Jitsu and love sharing it with those who want to learn, we live the Jiu Jitsu lifestyle and want to share our unique point of view. At its core our Jiu-Jitsu is an emphasis on solid fundamentals building upon each other to open doors to unique transitions and timings in relation to our style and preferences. Think of this package as having an extra coach to help develop your game. For example: you see a technique on our app and try to work it in training. It goes terribly wrong and you email us in one click from the app. We see your concern and get back to you as soon as we can to help you get it down better. This happens all the time and we love it; anything we can do to help you get better. Let’s grow and develop our game together!",
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            giAndNoGiImage = new Image
            {
                Source = "sweep.JPG",
                Aspect = Aspect.AspectFit
            };

            giAndNoGiImageFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 2,
                Content = giAndNoGiImage,
                HasShadow = false
            };

            giAndNoGiTap = new TapGestureRecognizer();
            giAndNoGiTap.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new AccountInfoPage(Package.GiAndNoGi));
            };
            giAndNoGiStackLayout.GestureRecognizers.Add(giAndNoGiTap);


            giAndNoGiScrollView = new ScrollView
            {
                Content = giAndNoGiStackLayout,
                BackgroundColor = Color.FromRgb(58, 93, 174)
            };

            giAndNoGiFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                Padding = 5,
                HasShadow = false,
                Content = giAndNoGiScrollView
            };
            #endregion
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
#if __ANDROID__
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                }
            };
#endif
#if __IOS__
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
#endif

            //events
            backBtn.Clicked += (object sender, EventArgs e) =>
            {
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
            giAndNoGiStackLayout.Children.Add(giAndNoGiImageFrame);
            giAndNoGiStackLayout.Orientation = StackOrientation.Vertical;
            giStackLayout.Children.Add(giTitle);
            giStackLayout.Children.Add(giPrice);
            giStackLayout.Children.Add(giBody);
            giStackLayout.Children.Add(giImageFrame);
            giStackLayout.Orientation = StackOrientation.Vertical;
            noGiStackLayout.Children.Add(noGiTitle);
            noGiStackLayout.Children.Add(noGiPrice);
            noGiStackLayout.Children.Add(noGiBody);
            noGiStackLayout.Children.Add(noGiImageFrame);
            noGiStackLayout.Orientation = StackOrientation.Vertical;
#if __IOS__
            innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
            innerGrid.Children.Add(giFrame, 0, 1);
            innerGrid.Children.Add(noGiFrame, 0, 2);
            innerGrid.Children.Add(backBtn, 0, 3);
#endif
#if __ANDROID__
            innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
            innerGrid.Children.Add(giFrame, 0, 1);
            innerGrid.Children.Add(noGiFrame, 0, 2);
#endif
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                #if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 10, 10, 10);
#endif                
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
#if __IOS__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                innerGrid.Children.Add(giFrame, 1, 0);
                innerGrid.Children.Add(noGiFrame, 2, 0);
                innerGrid.Children.Add(backBtn, 1, 1);
#endif
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                innerGrid.Children.Add(giFrame, 1, 0);
                innerGrid.Children.Add(noGiFrame, 2, 0);
#endif

            }
            else
            {
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

#if __IOS__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                innerGrid.Children.Add(giFrame, 0, 1);
                innerGrid.Children.Add(noGiFrame, 0, 2);
                innerGrid.Children.Add(backBtn, 0, 3);
#endif
#if __ANDROID__
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });

                innerGrid.Children.Add(giAndNoGiFrame, 0, 0);
                innerGrid.Children.Add(giFrame, 0, 1);
                innerGrid.Children.Add(noGiFrame, 0, 2);
#endif
            }
        }
    }
}

