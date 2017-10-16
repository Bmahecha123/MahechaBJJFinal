using System;
using MahechaBJJ.Model;
using MahechaBJJ.Views.BlogPages;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Frame giFrame;
        private Label giLbl;
        private Image giImage;
        private TapGestureRecognizer giTap;
        private Frame noGiFrame;
        private Label noGiLbl;
        private Image noGiImage;
        private TapGestureRecognizer noGiTap;
        private Frame blogFrame;
        private Label blogLbl;
        private Image blogImage;
        private TapGestureRecognizer blogTap;


        public BrowsePage()
        {
            Title = "Browse";
#if __IOS__
            Icon = "openbook.png";
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
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};

			outerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};

			noGiLbl = new Label
			{
				Text = "Gi",
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

			noGiTap = new TapGestureRecognizer();
			noGiTap.Tapped += (sender, e) =>
			{
                Navigation.PushModalAsync(new BrowseDetailPage(noGiLbl.Text));
			};
			noGiLbl.GestureRecognizers.Add(noGiTap);

			noGiImage = new Image
			{
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromFile("bottom.jpg")
			};
			noGiFrame = new Frame
			{
				Content = noGiImage,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
			};

			//bottom objects
			giLbl = new Label
			{
				Text = "No-Gi",
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

			giTap = new TapGestureRecognizer();
			giTap.Tapped += (sender, e) =>
			{
				Navigation.PushModalAsync(new BrowseDetailPage(giLbl.Text));
			};
			giLbl.GestureRecognizers.Add(giTap);

			giImage = new Image
			{
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromFile("nogi.png")
			};
			giFrame = new Frame
			{
				Content = giImage,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
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
			innerGrid.Children.Add(noGiFrame, 0, 0);
			innerGrid.Children.Add(noGiLbl, 0, 0);
			innerGrid.Children.Add(giFrame, 0, 1);
			innerGrid.Children.Add(giLbl, 0, 1);
			innerGrid.Children.Add(blogFrame, 0, 2);
			innerGrid.Children.Add(blogLbl, 0, 2);
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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				//building grid
				innerGrid.Children.Add(noGiFrame, 0, 0);
				innerGrid.Children.Add(noGiLbl, 0, 0);
				innerGrid.Children.Add(giFrame, 0, 1);
				innerGrid.Children.Add(giLbl, 0, 1);
				innerGrid.Children.Add(blogFrame, 1, 0);
				Grid.SetRowSpan(blogFrame, 2);
				innerGrid.Children.Add(blogLbl, 1, 0);
				Grid.SetRowSpan(blogLbl, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				//building grid
				innerGrid.Children.Add(noGiFrame, 0, 0);
				innerGrid.Children.Add(noGiLbl, 0, 0);
				innerGrid.Children.Add(giFrame, 0, 1);
                innerGrid.Children.Add(giLbl, 0, 1);
                innerGrid.Children.Add(blogFrame, 0, 2);
                innerGrid.Children.Add(blogLbl, 0, 2);
			}
		}
    }
}

