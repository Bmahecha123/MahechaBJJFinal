using System;
using System.Text.RegularExpressions;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views.BlogPages
{
    public class BlogDetailPage : ContentPage
    {
        private Grid innerGrid;
        private Grid outerGrid;
        private Image blogImage;
        private Frame blogFrame;
        private string blogString;
        private Button backBtn;
        private Label blogContentLbl;
        private ScrollView scrollView;
        private BlogPosts.Post globalBlogPost;

        public BlogDetailPage(BlogPosts.Post blogPost)
        {
			Title = "Blog Post";
            blogString = StripHtml(blogPost.caption);
            Padding = new Thickness(10, 30, 10, 10);
            globalBlogPost = blogPost;
            SetContent();

        }

		//functions
        public void SetContent()
        {
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

			//view objects
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(6, GridUnitType.Star)},
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

			blogImage = new Image
			{
				Aspect = Aspect.Fill,
                Source = globalBlogPost.photos[0].alt_sizes[1].url
			};
			blogFrame = new Frame
			{
				BackgroundColor = Color.Black,
				HasShadow = false,
				OutlineColor = Color.Black,
				Padding = 3,
				Content = blogImage
			};
			blogContentLbl = new Label
			{
				Text = blogString,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				VerticalTextAlignment = TextAlignment.Start,
				HorizontalTextAlignment = TextAlignment.Start,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};

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
				BackgroundColor = Color.Orange,
				BorderWidth = 3,
				TextColor = Color.Black
			};
			scrollView = new ScrollView
			{
				Content = blogContentLbl
			};


			//Events
			backBtn.Clicked += GoBack;

			//building Grid
			innerGrid.Children.Add(blogFrame, 0, 0);
			innerGrid.Children.Add(scrollView, 0, 1);
			innerGrid.Children.Add(backBtn, 0, 2);

			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }


		public void GoBack(object sender, EventArgs e)
		{
			backBtn.IsEnabled = false;
			Navigation.PopModalAsync();
			backBtn.IsEnabled = true;
		}
        public string StripHtml(string input)
        {
            return Regex.Replace(input, "<.*?>", "\n");
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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				//building grid
                innerGrid.Children.Add(blogFrame, 0, 0);
                Grid.SetRowSpan(blogFrame, 2);
                innerGrid.Children.Add(scrollView, 1, 0);
                Grid.SetRowSpan(scrollView, 3);
				innerGrid.Children.Add(backBtn, 0, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(6, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
				//building grid
                innerGrid.Children.Add(blogFrame, 0, 0);
                innerGrid.Children.Add(scrollView, 0, 1);
				innerGrid.Children.Add(backBtn, 0, 2);
			}
		}
    }
}

