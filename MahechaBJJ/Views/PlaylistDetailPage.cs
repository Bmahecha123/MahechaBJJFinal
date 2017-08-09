using System;
using MahechaBJJ.Model;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class PlaylistDetailPage : ContentPage
    {
        private Label playlistNameLbl;
        private ListView videosListView;
        private Button backBtn;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid videoGrid;
        private Frame videoFrame;
        private Image videoImage;
        private Label videoLbl;

        public PlaylistDetailPage(PlayList playlist)
        {
            Title = playlist.Name;
            Padding = new Thickness(10, 30, 10, 10);
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

            playlistNameLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = playlist.Name,
				FontSize = lblSize * 2,
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
            };

            videosListView = new ListView
            {
                ItemsSource = playlist.Videos,
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.None,
                ItemTemplate = new DataTemplate(() =>
                {
                    videoGrid = new Grid();
                    videoGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});

                    videoImage = new Image();
                    videoImage.SetBinding(Image.SourceProperty, "Image");

                    videoLbl = new Label();
#if __IOS__
                    videoLbl.FontFamily = "AmericanTypewriter-Bold";
#endif
#if __ANDROID__
                    videoLbl.FontFamily = "Roboto Bold";
#endif
                    videoLbl.SetBinding(Label.TextProperty, "Name");
                    videoLbl.VerticalTextAlignment = TextAlignment.Center;
                    videoLbl.HorizontalTextAlignment = TextAlignment.Center;
                    videoLbl.TextColor = Color.White;
                    videoLbl.FontSize = lblSize;

                    videoFrame = new Frame();
                    videoFrame.Content = videoImage;
                    videoFrame.OutlineColor = Color.Black;
                    videoFrame.BackgroundColor = Color.Black;
                    videoFrame.HasShadow = false;
                    videoFrame.Padding = 3;

                    videoGrid.Children.Add(videoFrame, 0, 0);
                    videoGrid.Children.Add(videoLbl, 0, 0);

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Vertical,
                            Spacing = 0,
                            Padding = new Thickness(0, 20, 0, 20),
                            Children = {
                                videoGrid
                            }
                        }
                    };
                })
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

            //Building Grid
            innerGrid.Children.Add(playlistNameLbl, 0, 0);
            innerGrid.Children.Add(videosListView, 0, 1);
            innerGrid.Children.Add(backBtn, 0, 2);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
		}

        //Functions
        public void GoBack(Object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(playlistNameLbl, 0, 0);
                innerGrid.Children.Add(backBtn, 0, 2);
                innerGrid.Children.Add(videosListView, 1, 0);
                Grid.SetRowSpan(videosListView, 3);
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(playlistNameLbl, 0, 0);
                innerGrid.Children.Add(videosListView, 0, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
            }
        }
    }
}

