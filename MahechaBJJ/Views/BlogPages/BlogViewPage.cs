using System;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.BlogPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views.BlogPages
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
		private Label timeOutLbl;
		private Frame timeOutFrame;
		private TapGestureRecognizer timeOutTap;
		private ActivityIndicator activityIndicator;

        public BlogViewPage()
        {
            _blogViewPageViewModel = new BlogViewPageViewModel();
            Title = "Blog Posts";
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
            SetContent();
			
		}

        //functions
        public void BuildPageObjects()
        {
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
				FontSize = lblSize * 1.5,
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
                BackgroundColor = Color.FromRgb(124, 37, 41),
				BorderWidth = 3,
				TextColor = Color.Black
			};
			timeOutLbl = new Label
			{
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				Text = "Network Has Timed Out! \n Click To Try Again!",
				LineBreakMode = LineBreakMode.WordWrap,
				FontSize = lblSize,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.White
			};
			timeOutFrame = new Frame
			{
				Content = timeOutLbl,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			timeOutTap = new TapGestureRecognizer();
			timeOutTap.Tapped += (sender, e) =>
			{
				SetContent();
			};
			timeOutLbl.GestureRecognizers.Add(timeOutTap);
			activityIndicator = new ActivityIndicator
			{
				IsRunning = false,
				IsEnabled = true,
				IsVisible = true
			};

			//Events
			backBtn.Clicked += GoBack;
			blogListView.ItemSelected += LoadBlogpost;



			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        public void GoBack(object sender, EventArgs e)
        {
			backBtn.IsEnabled = false;
			Navigation.PopModalAsync();
			backBtn.IsEnabled = true;
        }

		public void LoadBlogpost(object sender, SelectedItemChangedEventArgs e)
		{
            BlogPosts.Post blogPost = (BlogPosts.Post)((ListView)sender).SelectedItem;
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
            Navigation.PushModalAsync(new BlogDetailPage(blogPost));
		}

        public async void SetContent()
        {
            innerGrid.Children.Clear();
            activityIndicator.IsRunning = true;
            innerGrid.Children.Add(activityIndicator, 0, 0);
            Grid.SetRowSpan(activityIndicator, 3);

            if (_blogViewPageViewModel.BlogPosts == null)
            {
				await _blogViewPageViewModel.GetBlogPosts(Constants.LOADBLOGPOSTS);
			}
            if (_blogViewPageViewModel.Successful)
            {
				blogListView.ItemsSource = _blogViewPageViewModel.BlogPosts.response.posts;

				blogListView.ItemTemplate = new DataTemplate(() =>
				{
					listViewGrid = new Grid();
					listViewGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
					listViewGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

					blogLbl = new Label();
					blogLbl.SetBinding(Label.TextProperty, "summary");
					blogLbl.VerticalTextAlignment = TextAlignment.Center;
					blogLbl.HorizontalTextAlignment = TextAlignment.Center;
					blogLbl.TextColor = Color.Black;
					blogLbl.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
					blogLbl.LineBreakMode = LineBreakMode.WordWrap;
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
					listViewGrid.Children.Add(blogLbl, 0, 1);

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

                //building grid
                innerGrid.Children.Clear();
				innerGrid.Children.Add(viewBlogLbl, 0, 0);
				innerGrid.Children.Add(blogListView, 0, 1);
				innerGrid.Children.Add(backBtn, 0, 2);

            } else {
                innerGrid.Children.Clear();
				innerGrid.Children.Add(timeOutFrame, 0, 0);
                innerGrid.Children.Add(backBtn, 0, 2);
				Grid.SetRowSpan(timeOutFrame, 3);
				Grid.SetRowSpan(timeOutLbl, 3);
            }
			
        }

		//page reloading
		protected override async void OnAppearing()
		{
			base.OnAppearing();
            BlogViewPageViewModel vm = new BlogViewPageViewModel();
            await vm.GetBlogPosts(Constants.LOADBLOGPOSTS);
            blogListView.ItemsSource = vm.BlogPosts.response.posts;

		}

		//Orientation
		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height); //must be called

			if (width > height)
			{
                if (_blogViewPageViewModel.BlogPosts != null)
                {
					Padding = new Thickness(10, 10, 10, 10);
					innerGrid.RowDefinitions.Clear();
					innerGrid.ColumnDefinitions.Clear();
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
					innerGrid.Children.Clear();
					//building grid
					innerGrid.Children.Add(viewBlogLbl, 0, 0);
					innerGrid.Children.Add(blogListView, 1, 0);
					Grid.SetRowSpan(blogListView, 3);
					innerGrid.Children.Add(backBtn, 0, 2);
                }
			}
			else
			{
				if (_blogViewPageViewModel.BlogPosts != null)
                {
					Padding = new Thickness(10, 30, 10, 10);
					innerGrid.RowDefinitions.Clear();
					innerGrid.ColumnDefinitions.Clear();
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Star) });
					innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
					innerGrid.Children.Clear();
					//building grid
					innerGrid.Children.Add(viewBlogLbl, 0, 0);
					innerGrid.Children.Add(blogListView, 0, 1);
					innerGrid.Children.Add(backBtn, 0, 2);
                }
			}
		}
    }
}

