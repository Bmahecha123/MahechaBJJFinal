﻿using System;
using MahechaBJJ.Model;
using MahechaBJJ.Views.BlogPages;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Frame bottomFrame;
        private Label bottomLbl;
        private Image bottomImage;
        private Frame topFrame;
        private Label topLbl;
        private Image topImage;
        private Frame blogFrame;
        private Label blogLbl;
        private Image blogImage;
        private TapGestureRecognizer blogTap;


        public BrowsePage()
        {
			Title = "Browse";
            Icon = "002-open-book.png";
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

			topLbl = new Label
			{
				Text = "Top",
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
			topImage = new Image
			{
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromFile("kevin.jpg")
			};
			topFrame = new Frame
			{
				Content = topImage,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Black,
				HasShadow = false,
				Padding = 3
			};

			//bottom objects
			bottomLbl = new Label
			{
				Text = "Bottom",
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
			bottomImage = new Image
			{
				Aspect = Aspect.AspectFill,
				Source = ImageSource.FromFile("bottom.jpg")
			};
			bottomFrame = new Frame
			{
				Content = bottomImage,
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
			innerGrid.Children.Add(topFrame, 0, 0);
			innerGrid.Children.Add(topLbl, 0, 0);
			innerGrid.Children.Add(bottomFrame, 0, 1);
			innerGrid.Children.Add(bottomLbl, 0, 1);
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
				innerGrid.Children.Add(topFrame, 0, 0);
				innerGrid.Children.Add(topLbl, 0, 0);
				innerGrid.Children.Add(bottomFrame, 0, 1);
				innerGrid.Children.Add(bottomLbl, 0, 1);
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
				innerGrid.Children.Add(topFrame, 0, 0);
				innerGrid.Children.Add(topLbl, 0, 0);
				innerGrid.Children.Add(bottomFrame, 0, 1);
                innerGrid.Children.Add(bottomLbl, 0, 1);
                innerGrid.Children.Add(blogFrame, 0, 2);
                innerGrid.Children.Add(blogLbl, 0, 2);
			}
		}
    }
}

