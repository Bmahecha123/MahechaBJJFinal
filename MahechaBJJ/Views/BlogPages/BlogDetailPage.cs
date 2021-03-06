﻿using System;
using System.Text.RegularExpressions;
using MahechaBJJ.Model;
using Xamarin.Forms;
using MahechaBJJ.Resources;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using MahechaBJJ.Droid;
#endif

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

#if __ANDROID__
        private Android.Widget.TextView androidBlogContentLbl;
#endif

        public BlogDetailPage(BlogPosts.Post blogPost)
        {
            BackgroundColor = Color.FromHex("#F1ECCE");
            Title = "Blog Post";
            blogString = StripHtml(blogPost.caption);
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 30, 10, 10);
#endif            
            globalBlogPost = blogPost;
            BuildPageObjects();

        }

        //functions
        public void BuildPageObjects()
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
                BorderColor = Color.Black,
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
                Image = "back.png",
                Style = (Style)Application.Current.Resources["common-red-btn"]
            };

#if __ANDROID__

            androidBlogContentLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidBlogContentLbl.Text = blogString;
            androidBlogContentLbl.Typeface = Constants.COMMONFONT;
            androidBlogContentLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 50);
            androidBlogContentLbl.SetTextColor(Android.Graphics.Color.Black);
            androidBlogContentLbl.Gravity = Android.Views.GravityFlags.Start;
#endif

            scrollView = new ScrollView
            {
#if __ANDROID__
                Content = androidBlogContentLbl.ToView(),
                IsClippedToBounds = true
#endif
#if __IOS__
                    Content = blogContentLbl
#endif          
            };

            //Events
            backBtn.Clicked += GoBack;

            //building Grid
            innerGrid.Children.Add(blogFrame, 0, 0);
#if __ANDROID__
            innerGrid.Children.Add(scrollView, 0, 1);
            Grid.SetRowSpan(scrollView, 2);
#endif
#if __IOS__
            innerGrid.Children.Add(scrollView, 0, 1);
			innerGrid.Children.Add(backBtn, 0, 2);
#endif

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }


        public async void GoBack(object sender, EventArgs e)
        {
            backBtn.IsEnabled = false;
            await Navigation.PopModalAsync();
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
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 10, 10, 10);
#endif

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
                innerGrid.Children.Add(scrollView, 1, 0);
                Grid.SetRowSpan(scrollView, 3);
#if __ANDROID__
                Grid.SetRowSpan(blogFrame, 3);
#endif
#if __IOS__
                Grid.SetRowSpan(blogFrame, 2);
                innerGrid.Children.Add(backBtn, 0, 2);
#endif
            }
            else
            {
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 30, 10, 10);
#endif
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(6, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                //building Grid
                innerGrid.Children.Add(blogFrame, 0, 0);
#if __ANDROID__
                innerGrid.Children.Add(scrollView, 0, 1);
                Grid.SetRowSpan(scrollView, 2);
#endif
#if __IOS__
            innerGrid.Children.Add(scrollView, 0, 1);
            innerGrid.Children.Add(backBtn, 0, 2);
#endif
            }
        }
    }
}

