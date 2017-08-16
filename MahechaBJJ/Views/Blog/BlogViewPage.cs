using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.Blog;
using Xamarin.Forms;

namespace MahechaBJJ.Views.Blog
{
    public class BlogViewPage : ContentPage
    {
        //ViewModel
        private BlogViewPageViewModel _blogViewPageViewModel;
        //objects
        private Label viewBlogLbl;
        private ListView blogListView;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid listViewGrid;
        private Label blogLbl;
        private Image blogImage;
        private Frame blogFrame;
        private Button backBtn;
        private StackLayout layout;

        public BlogViewPage()
        {
            _blogViewPageViewModel = new BlogViewPageViewModel();
            Title = "Blog Posts";
            Padding = new Thickness(10, 30, 10, 10);
            FindBlogPosts();
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //View Objects
            innerGrid = new Grid
            {
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(7, GridUnitType.Star)},
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

            viewBlogLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Mahecha BJJ Blog",
				FontSize = lblSize * 2,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };
            blogListView = new ListView
            {
				HasUnevenRows = true,
				SeparatorVisibility = SeparatorVisibility.None
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

			//Events
			backBtn.Clicked += GoBack;
            blogListView.ItemSelected += LoadBlogpost;

            //building grid
            innerGrid.Children.Add(viewBlogLbl, 0, 0);
            innerGrid.Children.Add(blogListView, 0, 1);
            innerGrid.Children.Add(backBtn, 0, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
		}

        //functions
        public void GoBack(object sender, EventArgs e)
        {
			backBtn.IsEnabled = false;
			Navigation.PopModalAsync();
			backBtn.IsEnabled = true;
        }

		public void LoadBlogpost(object sender, SelectedItemChangedEventArgs e)
		{
			throw new NotImplementedException();
		}

        public async void FindBlogPosts()
        {
            await _blogViewPageViewModel.GetBlogPosts(Constants.LOADBLOGPOSTS);
            SetViewContents();
        }

        public void SetViewContents()
        {
            blogListView.ItemsSource = _blogViewPageViewModel.BlogPosts.response.posts;

            blogListView.ItemTemplate = new DataTemplate(() =>
            {
                listViewGrid = new Grid();
                listViewGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});

				blogLbl = new Label();
                blogLbl.SetBinding(Label.TextProperty, "summary");
                blogLbl.VerticalTextAlignment = TextAlignment.Center;
                blogLbl.HorizontalTextAlignment = TextAlignment.Center;
                blogLbl.TextColor = Color.YellowGreen;
                blogLbl.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
                blogLbl.LineBreakMode = LineBreakMode.TailTruncation;
#if __IOS__
				blogLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                blogLbl.FontFamily = "Roboto Bold";
#endif

                blogImage = new Image();
                blogImage.SetBinding(Image.SourceProperty, "photos[0].alt_sizes[1].url");
                blogImage.Aspect = Aspect.Fill;

				blogFrame = new Frame();
                blogFrame.BackgroundColor = Color.Black;
				blogFrame.HasShadow = false;
                blogFrame.OutlineColor = Color.Black;
				blogFrame.Padding = 3;
                blogFrame.Content = blogImage;

                //building Grid
                listViewGrid.Children.Add(blogFrame, 0, 0);
                listViewGrid.Children.Add(blogLbl, 0, 0);

                layout = new StackLayout
                {
					Orientation = StackOrientation.Vertical,
					Spacing = 0,
					Padding = new Thickness(0, 5, 0, 5),
					Children = {
                            listViewGrid
						}
                };

                ViewCell viewCell = new ViewCell();
                viewCell.View = layout;

                return viewCell;
			});
        }
    }
}

