using System;

using Xamarin.Forms;

namespace MahechaBJJ.Views.SignUpPages
{
    public class AccountInfoPage : ContentPage
    {
        private Grid innerGrid;
        private Grid outerGrid;
        private StackLayout accountStackLayout;
        private StackLayout noAccountStackLayout;
        private ScrollView accountScrollView;
        private ScrollView noAccountScrollView;
        private Label headerLbl;
        private Frame accountFrame;
        private Frame noAccountGiFrame;
        private Button backBtn;
        private TapGestureRecognizer accountTap;
        private TapGestureRecognizer noAccountTap;
        private Label accountTitle;
        private Label accountInfo;
        private Label noAccountTitle;
        private Label noAccountInfo;

        public AccountInfoPage()
        {
            Padding = new Thickness();
            BuildPageObjects();
            SetContent();
        }

        private void BuildPageObjects()
        {
            innerGrid = new Grid();

            outerGrid = new Grid();

            accountScrollView = new ScrollView();

            noAccountScrollView = new ScrollView();

            accountStackLayout = new StackLayout();

            noAccountStackLayout = new StackLayout();

            headerLbl = new Label();
        }

        private void SetContent()
        {
            
        }
    }
}

