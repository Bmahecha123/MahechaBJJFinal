using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class PlaylistCreatePage : ContentPage
    {
        Grid outerGrid;
        Grid innerGrid;
        Label playListNameLbl;
        Entry playListNameEntry;
        Label playListDescriptionLbl;
        Editor playListDescriptionEditor;
        Frame editorFrame;
        Button backBtn;
        Button createBtn;

        public PlaylistCreatePage()
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			//View objects
			Title = "Create Playlist";
			Padding = new Thickness(10, 30, 10, 10);

            //Layout
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
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}



				},
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            //View objects
            playListNameLbl = new Label
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Name:",
                FontSize = lblSize * 2
			};
            playListNameEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Placeholder = "Leg Lasso List",
                FontSize = lblSize,
				
			};
            playListDescriptionLbl = new Label
            {
                Text = "Description:",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = lblSize * 2

			};
            playListDescriptionEditor = new Editor
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Editor)),
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                 
			};
			editorFrame = new Frame
			{
                Content = playListDescriptionEditor,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
			};
            backBtn = new Button
			{
				Text = "Back",
				BorderWidth = 3,
				BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};
            createBtn = new Button
            {
				Text = "Create",
				BorderWidth = 3,
				BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = btnSize * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black
			};

            //events
            backBtn.Clicked += GoBack;
            createBtn.Clicked += CreatePlaylist;

            //building grid
            innerGrid.Children.Add(playListNameLbl, 0, 0);
            playListNameLbl.VerticalTextAlignment = TextAlignment.Center;
            playListNameLbl.HorizontalTextAlignment = TextAlignment.Center;
            Grid.SetColumnSpan(playListNameLbl, 2);
            innerGrid.Children.Add(playListNameEntry, 0, 1);
            Grid.SetColumnSpan(playListNameEntry, 2);
            innerGrid.Children.Add(playListDescriptionLbl, 0, 2);
            Grid.SetColumnSpan(playListDescriptionLbl, 2);
            playListDescriptionLbl.VerticalTextAlignment = TextAlignment.Center;
            playListDescriptionLbl.HorizontalTextAlignment = TextAlignment.Center;
            innerGrid.Children.Add(editorFrame, 0, 3);
            Grid.SetRowSpan(editorFrame, 3);
            Grid.SetColumnSpan(editorFrame, 2);
            innerGrid.Children.Add(backBtn, 0, 7);
            innerGrid.Children.Add(createBtn, 1, 7);

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        //functions
        public void GoBack(object sender, EventArgs e) 
        {
            Navigation.PopModalAsync();
        }

        public async void CreatePlaylist(object sender, EventArgs e)
        {
            //TODO pull in account information with Account object
            //TODO look up user with that information
            //TODO update the backend with the updated User object
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
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(playListNameLbl, 0, 0);
                innerGrid.Children.Add(playListNameEntry, 1, 0);
                innerGrid.Children.Add(playListDescriptionLbl, 0, 1);
                innerGrid.Children.Add(editorFrame, 1, 1);
                innerGrid.Children.Add(backBtn, 0, 2);
                innerGrid.Children.Add(createBtn, 1, 2);
			}
			else
			{
				Padding = new Thickness(10, 30, 10, 10);
				innerGrid.RowDefinitions.Clear();
				innerGrid.ColumnDefinitions.Clear();
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				//building grid
				innerGrid.Children.Add(playListNameLbl, 0, 0);
				playListNameLbl.VerticalTextAlignment = TextAlignment.Center;
				playListNameLbl.HorizontalTextAlignment = TextAlignment.Center;
				Grid.SetColumnSpan(playListNameLbl, 2);
				innerGrid.Children.Add(playListNameEntry, 0, 1);
				Grid.SetColumnSpan(playListNameEntry, 2);
				innerGrid.Children.Add(playListDescriptionLbl, 0, 2);
				Grid.SetColumnSpan(playListDescriptionLbl, 2);
				playListDescriptionLbl.VerticalTextAlignment = TextAlignment.Center;
				playListDescriptionLbl.HorizontalTextAlignment = TextAlignment.Center;
				innerGrid.Children.Add(editorFrame, 0, 3);
				Grid.SetRowSpan(editorFrame, 3);
				Grid.SetColumnSpan(editorFrame, 2);
				innerGrid.Children.Add(backBtn, 0, 7);
				innerGrid.Children.Add(createBtn, 1, 7);
			}
		}
    }
}

