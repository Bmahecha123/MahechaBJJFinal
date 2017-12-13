using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views.CommonPages
{
    public class BrowseDetailPage : ContentPage
    {
		private Grid outerGrid;
		private Grid innerGrid;
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
        private Button backBtn;
        private string type;

		public BrowseDetailPage(string type)
        {
			Title = "Browse";
			Padding = new Thickness(10, 30, 10, 10);
            this.type = type;
            SetContent();
        }

        public void SetContent()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 2;
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)) * 2;


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
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};

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
                Navigation.PushModalAsync(new SearchPage(sweepLbl.Text));
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
				Navigation.PushModalAsync(new SearchPage(takeDownLbl.Text));
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
				Navigation.PushModalAsync(new SearchPage(submissionLbl.Text));
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
				Navigation.PushModalAsync(new SearchPage(guardPassLbl.Text));
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
				Navigation.PushModalAsync(new SearchPage(defenseLbl.Text));
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
				Navigation.PushModalAsync(new SearchPage(backTakeLbl.Text));
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

			backBtn = new Button
			{
				Text = "Back",
				BorderWidth = 3,
				BorderColor = Color.Black,
				TextColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize,
				BackgroundColor = Color.FromRgb(124, 37, 41)
			};

            backBtn.Clicked += GoBack;

            innerGrid.Children.Add(sweepFrame, 0, 0);
            innerGrid.Children.Add(takeDownFrame, 0, 1);
            innerGrid.Children.Add(submissionFrame, 0, 2);
            innerGrid.Children.Add(guardPassFrame, 0, 3);
            innerGrid.Children.Add(defenseFrame, 0, 4);
            innerGrid.Children.Add(backTakeFrame, 0, 5);
			innerGrid.Children.Add(backBtn, 0, 6);
			outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        private void GoBack(object sender, EventArgs e)
        {
			backBtn.IsEnabled = false;
			Navigation.PopModalAsync();
        }
    }
}

