using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.BlogPages;
using MahechaBJJ.Resources;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Auth;
using Xamarin.Forms;
#if __ANDROID__
using MahechaBJJ.Droid;
using Xamarin.Forms.Platform.Android;
#endif

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        //declare objects
        private BaseViewModel _baseViewModel;
        private Account account;
        private Grid outerGrid;
        private Grid innerGrid;
        private StackLayout stackLayout;
        private ScrollView scrollView;
        private Frame backTakeFrame;
        private Label backTakeLbl;
        private TapGestureRecognizer backTakeTap;
        private Frame takeDownFrame;
        private Label takeDownLbl;
        private TapGestureRecognizer takeDownTap;
        private Frame sweepFrame;
        private Label sweepLbl;
        private TapGestureRecognizer sweepTap;
        private Frame defenseFrame;
        private Label defenseLbl;
        private TapGestureRecognizer defenseTap;
        private Frame guardPassFrame;
        private Label guardPassLbl;
        private TapGestureRecognizer guardPassTap;
        private Frame submissionFrame;
        private Label submissionLbl;
        private TapGestureRecognizer submissionTap;
        private Frame drillsFrame;
        private Label drillsLbl;
        private TapGestureRecognizer drillsTap;
        private Frame blogFrame;
        private Label blogLbl;
        private Image blogImage;
        private TapGestureRecognizer blogTap;
#if __ANDROID__
        private Android.Widget.TextView androidBlogLbl;
#endif


        public BrowsePage()
        {
            _baseViewModel = new BaseViewModel();
            account = _baseViewModel.GetAccountInformation();
            BackgroundColor = Color.FromHex("#F1ECCE");
#if __IOS__
            Icon = "openbook.png";
            Title = "Browse";
            Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
            Icon = "openbook.png";
            Padding = new Thickness(5, 5, 5, 5);
#endif
            SetContent();

        }

        //Functions
        private void SetContent()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
                }
            };

            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            stackLayout = new StackLayout();
            scrollView = new ScrollView();

            #if __ANDROID__
            androidBlogLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidBlogLbl.Text = "Blog";
            androidBlogLbl.Typeface = Constants.COMMONFONT;
            androidBlogLbl.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidBlogLbl.SetTextColor(Android.Graphics.Color.Rgb(241, 236, 206));
            androidBlogLbl.Gravity = Android.Views.GravityFlags.Center;
            androidBlogLbl.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new BlogViewPage());
                ToggleButtons();
            };

#endif

            sweepLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Sweep",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            sweepTap = new TapGestureRecognizer();
            sweepTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiSweep));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiSweep));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Sweep));
                }
                ToggleButtons();
            };
            sweepLbl.GestureRecognizers.Add(sweepTap);

            sweepFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = sweepLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            takeDownLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Take Down",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            takeDownTap = new TapGestureRecognizer();
            takeDownTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiTakeDown));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiTakeDown));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.TakeDown));
                }
                ToggleButtons();
            };
            takeDownLbl.GestureRecognizers.Add(takeDownTap);


            takeDownFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = takeDownLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            submissionLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Submission",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            submissionTap = new TapGestureRecognizer();
            submissionTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiSubmission));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiSubmission));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Submission));
                }
                ToggleButtons();
            };
            submissionLbl.GestureRecognizers.Add(submissionTap);


            submissionFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = submissionLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            guardPassLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Guard Pass",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            guardPassTap = new TapGestureRecognizer();
            guardPassTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiGuardPass));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiGuardPass));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GuardPass));
                }
                ToggleButtons();
            };
            guardPassLbl.GestureRecognizers.Add(guardPassTap);


            guardPassFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = guardPassLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            defenseLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Defense",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            defenseTap = new TapGestureRecognizer();
            defenseTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiDefense));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiDefense));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Defense));
                }
                ToggleButtons();
            };
            defenseLbl.GestureRecognizers.Add(defenseTap);


            defenseFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = defenseLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            backTakeLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Back Take",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            backTakeTap = new TapGestureRecognizer();
            backTakeTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiBackTake));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiBackTake));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.BackTake));
                }
                ToggleButtons();
            };
            backTakeLbl.GestureRecognizers.Add(backTakeTap);


            backTakeFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
#if __ANDROID__
                Content = backTakeLbl,
#endif
#if __IOS__
                Content = backTakeLbl,
#endif
                Padding = new Thickness(10, 10, 10, 10)
            };

            drillsLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-blue-lbl"],
                Text = "Drills",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize
#endif
#if __ANDROID__
                FontFamily = "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt",
                FontSize = lblSize * 1.5,
                FontAttributes = FontAttributes.Bold
#endif
            };

            drillsTap = new TapGestureRecognizer();
            drillsTap.Tapped += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiDrills));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiDrills));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Drills));
                }
                ToggleButtons();
            };
            drillsLbl.GestureRecognizers.Add(drillsTap);

            drillsFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                BorderColor = Color.Black,
                Content = drillsLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            //blog objects
            blogLbl = new Label
            {
                Style = (Style)Application.Current.Resources["common-technique-lbl"],
                Text = "Blog",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
                FontSize = lblSize * 2
            };
            blogTap = new TapGestureRecognizer();
            blogTap.Tapped += async (sender, e) =>
            {
                ToggleButtons();
                await Navigation.PushModalAsync(new BlogViewPage());
                ToggleButtons();
            };
            blogLbl.GestureRecognizers.Add(blogTap);
            blogImage = new Image
            {
                Aspect = Aspect.AspectFill,
                Source = ImageSource.FromFile("blog.jpg")
            };
            blogFrame = new Frame
            {
                Content = blogImage,
                BorderColor = Color.Black,
                BackgroundColor = Color.Black,
                HasShadow = false,
                Padding = 3
            };

            //Events
            //adding children
            stackLayout.Children.Add(sweepFrame);
            stackLayout.Children.Add(takeDownFrame);
            stackLayout.Children.Add(submissionFrame);
            stackLayout.Children.Add(guardPassFrame);
            stackLayout.Children.Add(defenseFrame);
            stackLayout.Children.Add(backTakeFrame);
            stackLayout.Children.Add(drillsFrame);
            scrollView.Content = stackLayout;
#if __ANDROID__
            scrollView.IsClippedToBounds = true;
#endif

            innerGrid.Children.Add(scrollView, 0, 0);
            innerGrid.Children.Add(blogFrame, 0, 1);
#if __ANDROID__
            innerGrid.Children.Add(androidBlogLbl.ToView(), 0, 1);
#endif
#if __IOS__

            innerGrid.Children.Add(blogLbl, 0, 1);
#endif
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private void ToggleButtons()
        {
#if __ANDROID__
            androidBlogLbl.Clickable = !androidBlogLbl.Clickable;
#endif
            sweepLbl.IsEnabled = !sweepLbl.IsEnabled;
            backTakeLbl.IsEnabled = !backTakeLbl.IsEnabled;
            takeDownLbl.IsEnabled = !takeDownLbl.IsEnabled;
            guardPassLbl.IsEnabled = !guardPassLbl.IsEnabled;
            submissionLbl.IsEnabled = !submissionLbl.IsEnabled;
            defenseLbl.IsEnabled = !defenseLbl.IsEnabled;
            drillsLbl.IsEnabled = !drillsLbl.IsEnabled;
            blogLbl.IsEnabled = !blogLbl.IsEnabled;
        }

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
#if __IOS__
                Padding = new Thickness(10, 10, 10, 10);
#endif
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                //building grid
                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(blogFrame, 1, 0);
#if __ANDROID__
                innerGrid.Children.Add(androidBlogLbl.ToView(), 1, 0);
#endif
#if __IOS__
                innerGrid.Children.Add(blogLbl, 1, 0);
#endif
            }
            else
            {
#if __IOS__
            
                Padding = new Thickness(10, 30, 10, 10);
#endif
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                innerGrid.Children.Clear();
                //building grid
                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(blogFrame, 0, 1);
#if __ANDROID__
                innerGrid.Children.Add(androidBlogLbl.ToView(), 0, 1);
#endif
#if __IOS__

            innerGrid.Children.Add(blogLbl, 0, 1);
#endif

            }
        }
    }
}

