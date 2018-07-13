using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.MainTabPages;
using Xamarin.Auth;
using Xamarin.Forms;
#if __ANDROID__
using MahechaBJJ.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
#endif

namespace MahechaBJJ.Views.CommonPages
{
    public class PurchasePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private PurchasePageViewModel _purchasePageViewModel;
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
        private Image giImage;
        private Frame giImageFrame;
        private Label noGiTitle;
        private Label noGiPrice;
        private Label noGiBody;
        private Image noGiImage;
        private Frame noGiImageFrame;
        private Button backBtn;
        private Button purchaseBtn;
        private Package package;
        private bool isLoggedIn;
#if __ANDROID__
        private Android.Widget.TextView androidGiTitle;
        private Android.Widget.TextView androidGiPrice;
        private Android.Widget.TextView androidGiBody;
        private Android.Widget.TextView androidNoGiTitle;
        private Android.Widget.TextView androidNoGiPrice;
        private Android.Widget.TextView androidNoGiBody;
        private Android.Widget.Button androidPurchaseBtn;

        private ContentView contentViewGiTitle;
        private ContentView contentViewGiPrice;
        private ContentView contentViewGiBody;
        private ContentView contentViewNoGiTitle;
        private ContentView contentViewNoGiPrice;
        private ContentView contentViewNoGiBody;
        private ContentView contentViewPurchaseBtn;
#endif

        public PurchasePage(Package package, bool hasAccount)
        {
            _baseViewModel = new BaseViewModel();
            _purchasePageViewModel = new PurchasePageViewModel();
            account = _baseViewModel.GetAccountInformation();
            BackgroundColor = Color.FromHex("#F1ECCE");

            this.package = package;
            this.isLoggedIn = hasAccount;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
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
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
#if __ANDROID__
                    new RowDefinition { Height = new GridLength(6, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
#endif
#if __IOS__
                    new RowDefinition { Height = new GridLength(9, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
#endif
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
#if __ANDROID__
            androidGiTitle = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidGiTitle.Text = "Gi";
            androidGiTitle.Typeface = Constants.COMMONFONT;
            androidGiTitle.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidGiTitle.SetTextColor(Android.Graphics.Color.Black);
            androidGiTitle.Gravity = Android.Views.GravityFlags.Start;
            androidGiTitle.SetTypeface(androidGiTitle.Typeface, Android.Graphics.TypefaceStyle.Bold);
            contentViewGiTitle = new ContentView();
            contentViewGiTitle.Content = androidGiTitle.ToView();

            androidGiPrice = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidGiPrice.Text = "$19.99";
            androidGiPrice.Typeface = Constants.COMMONFONT;
            androidGiPrice.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidGiPrice.SetTextColor(Android.Graphics.Color.Black);
            androidGiPrice.Gravity = Android.Views.GravityFlags.Start;
            androidGiPrice.SetTypeface(androidGiPrice.Typeface, Android.Graphics.TypefaceStyle.Bold);
            contentViewGiPrice = new ContentView();
            contentViewGiPrice.Content = androidGiPrice.ToView();

            androidGiBody = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidGiBody.Text = "This library is growing constantly and there is no end in sight. The beauty of this package is that you get to follow our system as we develop and implement new transitions and positions. We’re constantly pushing the barrier in terms of our style and approach to Jiu-Jitsu. Every position that gets posted has been drilled to death and executed at the highest levels of competition. We’re proud of this; something I see wrong with other instructional resources is positions are shown that I know they have never ever hit in a competition or anything. You never have to worry about that with our techniques. One of the biggest advantages of our app is that you have direct access to us, if you have any questions or concerns; contacting us is a click away. Let’s grow and develop our Jiu Jitsu together!";
            androidGiBody.Typeface = Constants.COMMONFONT;
            androidGiBody.SetTextSize(Android.Util.ComplexUnitType.Fraction, 50);
            androidGiBody.SetTextColor(Android.Graphics.Color.Black);
            androidGiBody.Gravity = Android.Views.GravityFlags.Start;
            androidGiBody.SetTypeface(androidGiBody.Typeface, Android.Graphics.TypefaceStyle.Bold);

            contentViewGiTitle = new ContentView();
            contentViewGiTitle.Content = androidGiBody.ToView();
            contentViewGiPrice = new ContentView();
            contentViewGiPrice.Content = androidGiPrice.ToView();
            contentViewGiBody = new ContentView();
            contentViewGiBody.Content = androidGiBody.ToView();
#endif

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
                Text = "$19.99 (One Time Purchase)",
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
                Text = "This library is growing constantly and there is no end in sight. The beauty of this package is that you get to follow our system as we develop and implement new transitions and positions. We’re constantly pushing the barrier in terms of our style and approach to Jiu-Jitsu. Every position that gets posted has been drilled to death and executed at the highest levels of competition. We’re proud of this; something I see wrong with other instructional resources is positions are shown that I know they have never ever hit in a competition or anything. You never have to worry about that with our techniques. One of the biggest advantages of our app is that you have direct access to us, if you have any questions or concerns; contacting us is a click away. Let’s grow and develop our Jiu Jitsu together!",
                FontSize = lblSize,
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

            giScrollView = new ScrollView
            {
                BackgroundColor = Color.FromRgb(57, 172, 166),
                Content = giStackLayout,
#if __ANDROID__
                IsClippedToBounds = true
#endif
            };

            giFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
                #if __ANDROID__
                Padding = 0,
#endif
#if __IOS__
                Padding = 5,
#endif
                Content = giScrollView,
                HasShadow = false
            };
            #endregion
            #region NOGI
#if __ANDROID__
            androidNoGiTitle = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidNoGiTitle.Text = "No-Gi";
            androidNoGiTitle.Typeface = Constants.COMMONFONT;
            androidNoGiTitle.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidNoGiTitle.SetTextColor(Android.Graphics.Color.Black);
            androidNoGiTitle.Gravity = Android.Views.GravityFlags.Start;
            androidNoGiTitle.SetTypeface(androidNoGiTitle.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidNoGiPrice = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidNoGiPrice.Text = "$19.99";
            androidNoGiPrice.Typeface = Constants.COMMONFONT;
            androidNoGiPrice.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidNoGiPrice.SetTextColor(Android.Graphics.Color.Black);
            androidNoGiPrice.Gravity = Android.Views.GravityFlags.Start;
            androidNoGiPrice.SetTypeface(androidNoGiPrice.Typeface, Android.Graphics.TypefaceStyle.Bold);

            androidNoGiBody = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidNoGiBody.Text = "Just like the other packages, the No-Gi library is constantly being updated. So that means you’ll grow along with us. As we come up with new tweaks and transitions you’ll see it first as we are constantly updating our libraries. Through these techniques and positions your game will be brought to a new technical level. All the while being exposed to a unique point of view on approaching Jiu Jitsu. Some of the biggest advantages of this package is that you have direct access to us, the ones who implement and recorded these techniques. We love to hear from our members and never ignore anyone. Lets grow together!";
            androidNoGiBody.Typeface = Constants.COMMONFONT;
            androidNoGiBody.SetTextSize(Android.Util.ComplexUnitType.Fraction, 50);
            androidNoGiBody.SetTextColor(Android.Graphics.Color.Black);
            androidNoGiBody.Gravity = Android.Views.GravityFlags.Start;
            androidNoGiBody.SetTypeface(androidNoGiBody.Typeface, Android.Graphics.TypefaceStyle.Bold);

            contentViewNoGiTitle = new ContentView();
            contentViewNoGiTitle.Content = androidNoGiTitle.ToView();
            contentViewNoGiPrice = new ContentView();
            contentViewNoGiPrice.Content = androidNoGiPrice.ToView();
            contentViewNoGiBody = new ContentView();
            contentViewNoGiBody.Content = androidNoGiBody.ToView();
#endif

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
                Text = "$19.99 (One Time Purchase)",
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
                Text = "Just like the other packages, the No-Gi library is constantly being updated. So that means you’ll grow along with us. As we come up with new tweaks and transitions you’ll see it first as we are constantly updating our libraries. Through these techniques and positions your game will be brought to a new technical level. All the while being exposed to a unique point of view on approaching Jiu Jitsu. Some of the biggest advantages of this package is that you have direct access to us, the ones who implement and recorded these techniques. We love to hear from our members and never ignore anyone. Lets grow together!",
                FontSize = lblSize,
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

            noGiScrollView = new ScrollView
            {
                BackgroundColor = Color.FromRgb(57, 172, 166),
                Content = noGiStackLayout,
#if __ANDROID__
                IsClippedToBounds = true,
                Padding = new Thickness(5, 5, 5, 0)
#endif
            };

            noGiFrame = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Black,
#if __ANDROID__
                Padding = 0,
#endif
#if __IOS__
                Padding = 5,
#endif
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
                FontSize = btnSize * 1.5,
#endif
                Text = "Purchase",
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidPurchaseBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidPurchaseBtn.Text = "Purchase";
            androidPurchaseBtn.Typeface = Constants.COMMONFONT;
            androidPurchaseBtn.SetBackground(pd);
            androidPurchaseBtn.SetTextColor(Android.Graphics.Color.Black);
            androidPurchaseBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidPurchaseBtn.Gravity = Android.Views.GravityFlags.Center;
            androidPurchaseBtn.SetAllCaps(false);
            androidPurchaseBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await PurchasePackage();
                ToggleButtons();
            };

            contentViewPurchaseBtn = new ContentView();
            contentViewPurchaseBtn.Content = androidPurchaseBtn.ToView();
#endif

            //events
            backBtn.Clicked += (object sender, EventArgs e) =>
            {
                ToggleButtons();
                Navigation.PopModalAsync();
                ToggleButtons();
            };
            purchaseBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await PurchasePackage();
                ToggleButtons();
            };

#if __ANDROID__
            giStackLayout.Children.Add(contentViewGiTitle);
            giStackLayout.Children.Add(contentViewGiPrice);
            giStackLayout.Children.Add(contentViewGiBody);
            giStackLayout.Children.Add(giImageFrame);
            giStackLayout.Orientation = StackOrientation.Vertical;
            noGiStackLayout.Children.Add(contentViewNoGiTitle);
            noGiStackLayout.Children.Add(contentViewNoGiPrice);
            noGiStackLayout.Children.Add(contentViewNoGiBody);
            noGiStackLayout.Children.Add(noGiImageFrame);
            noGiStackLayout.Orientation = StackOrientation.Vertical;
#endif
#if __IOS__
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(purchaseBtn, 1, 0);

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
#endif

            if (this.package == Package.Gi)
            {
                innerGrid.Children.Add(giFrame, 0, 0);
            }
            else
            {
                innerGrid.Children.Add(noGiFrame, 0, 0);
            }

#if __ANDROID__
            innerGrid.Children.Add(contentViewPurchaseBtn, 0, 1);
            outerGrid.Children.Add(innerGrid, 0, 0);
#endif
#if __IOS__
            innerGrid.Children.Add(buttonGrid, 0, 1);
            outerGrid.Children.Add(innerGrid, 0, 0);
#endif

            Content = outerGrid;
        }

        private async Task PurchasePackage()
        {
            bool purchased = false;

            //bool purchased = true;
            purchased = await _purchasePageViewModel.PurchasePackage(FindPackageName());

            if (purchased)
            {
                //insert logic for Itunes or Play Store APIS
                account.Properties.Remove("Package");
                account.Properties.Add("Package", "GiAndNoGi");
                await _baseViewModel.UpdateCredentialsToFullAccess(account, isLoggedIn);
                await _purchasePageViewModel.Disconnect();
                await Navigation.PopModalAsync();
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }

        private void ToggleButtons()
        {
            purchaseBtn.IsEnabled = !purchaseBtn.IsEnabled;
            backBtn.IsEnabled = !backBtn.IsEnabled;
#if __ANDROID__
            androidPurchaseBtn.Clickable = !androidPurchaseBtn.Clickable;
#endif
        }

        private string FindPackageName()
        {
            if (package == Package.Gi)
            {
                return Constants.GIPACKAGE;
            }
            else if (package == Package.NoGi)
            {
                return Constants.NOGIPACKAGE;
            }
            else
            {
                return Constants.GIANDNOGIPACKAGE;
            }
        }
    }
}

