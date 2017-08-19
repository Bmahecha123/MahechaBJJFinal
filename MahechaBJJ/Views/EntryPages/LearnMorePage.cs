using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class LearnMorePage : ContentPage
    {
        //objects
        private Grid innerGrid;
        private Grid outerGrid;
        private Label headerLbl;
        private Label contentLbl1;
        private Label contentLbl2;
        private Image videoImage;
        private Label videoLbl;
        private Frame videoFrame;
        private ScrollView scrollView1;
        private ScrollView scrollView2;

        public LearnMorePage()
        {
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			//View objects
			Title = "Learn More";

			Padding = new Thickness(10, 30, 10, 10);


		}

        //functions
        public void BuildViewObjects()
        {
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
                    //new RowDefinition { Height = new}
                }
            };
            outerGrid = new Grid
            {

            };
        }
    }
}

