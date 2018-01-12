using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Views.BlogPages;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Auth;
using Xamarin.Forms;

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


        public BrowsePage()
        {
            _baseViewModel = new BaseViewModel();
            account = _baseViewModel.GetAccountInformation();
#if __IOS__
            Icon = "openbook.png";
            Title = "Browse";
#endif
#if __ANDROID__
            Icon = "openbook.png";
#endif
            Padding = new Thickness(10,30,10,10);
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

            sweepLbl = new Label
            {
                Text = "Sweep",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            sweepTap = new TapGestureRecognizer();
            sweepTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiSweep));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiSweep));
                }
                else 
                {
                    Navigation.PushModalAsync(new SearchPage(Album.Sweep));
                }
            };
            sweepLbl.GestureRecognizers.Add(sweepTap);

            sweepFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = sweepLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            takeDownLbl = new Label
            {
                Text = "Take Down",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            takeDownTap = new TapGestureRecognizer();
            takeDownTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiTakeDown));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiTakeDown));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.TakeDown));
                }
            };
            takeDownLbl.GestureRecognizers.Add(takeDownTap);


            takeDownFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = takeDownLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            submissionLbl = new Label
            {
                Text = "Submission",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            submissionTap = new TapGestureRecognizer();
            submissionTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiSubmission));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiSubmission));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.Submission));
                }
            };
            submissionLbl.GestureRecognizers.Add(submissionTap);


            submissionFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = submissionLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            guardPassLbl = new Label
            {
                Text = "Guard Pass",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            guardPassTap = new TapGestureRecognizer();
            guardPassTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiGuardPass));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiGuardPass));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GuardPass));
                }
            };
            guardPassLbl.GestureRecognizers.Add(guardPassTap);


            guardPassFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = guardPassLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            defenseLbl = new Label
            {
                Text = "Defense",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            defenseTap = new TapGestureRecognizer();
            defenseTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiDefense));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiDefense));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.Defense));
                }
            };
            defenseLbl.GestureRecognizers.Add(defenseTap);


            defenseFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = defenseLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            backTakeLbl = new Label
            {
                Text = "Back Take",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            backTakeTap = new TapGestureRecognizer();
            backTakeTap.Tapped += (sender, e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiBackTake));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiBackTake));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.BackTake));
                }
            };
            backTakeLbl.GestureRecognizers.Add(backTakeTap);


            backTakeFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = backTakeLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

            drillsLbl = new Label
            {
                Text = "Drills",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = lblSize,
                LineBreakMode = LineBreakMode.NoWrap,
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold"
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold"
#endif
            };

            drillsTap = new TapGestureRecognizer();
            drillsTap.Tapped += (object sender, EventArgs e) => {
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.GiDrills));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    Navigation.PushModalAsync(new SearchPage(Album.NoGiDrills));
                }
                else
                {
                    Navigation.PushModalAsync(new SearchPage(Album.Drills));
                }
            };
            drillsLbl.GestureRecognizers.Add(drillsTap);

            drillsFrame = new Frame
            {
                BackgroundColor = Color.FromRgb(58, 93, 174),
                HasShadow = false,
                OutlineColor = Color.Black,
                Content = drillsLbl,
                Padding = new Thickness(10, 10, 10, 10)
            };

			//blog objects
			blogLbl = new Label
			{
				Text = "Blog",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = lblSize * 2,
				TextColor = Color.White,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			blogTap = new TapGestureRecognizer();
			blogTap.Tapped += (sender, e) =>
			{
				Navigation.PushModalAsync(new BlogViewPage());
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
				OutlineColor = Color.Black,
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

            innerGrid.Children.Add(scrollView, 0, 0);
			innerGrid.Children.Add(blogFrame, 0, 1);
			innerGrid.Children.Add(blogLbl, 0, 1);
			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
				Padding = new Thickness(10, 10, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                //building grid
                innerGrid.Children.Add(scrollView, 0, 0);
				innerGrid.Children.Add(blogFrame, 1, 0);
				//Grid.SetRowSpan(blogFrame, 2);
				innerGrid.Children.Add(blogLbl, 1, 0);
				//Grid.SetRowSpan(blogLbl, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.Children.Clear();
                //building grid
                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(blogFrame, 0, 1);
                innerGrid.Children.Add(blogLbl, 0, 1);
			}
		}
    }
}

