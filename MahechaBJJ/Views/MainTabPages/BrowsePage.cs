using System;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.Resources;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class BrowsePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private Account account;
        private FlexLayout flexLayout;
        private Button backTakeBtn;
        private Button takeDownBtn;
        private Button sweepBtn;
        private Button defenseBtn;
        private Button guardPassBtn;
        private Button submissionBtn;
        private Button drillsBtn;
        private double width;
        private double height;

        public BrowsePage()
        {
            _baseViewModel = new BaseViewModel();
            account = _baseViewModel.GetAccountInformation();
            BackgroundColor = Theme.White;
            Visual = VisualMarker.Material;

            IconImageSource = "openbook.png";
            Padding = Theme.Thickness;

            width = this.Width;
            height = this.Height;

            SetContent();
            UpdateLayout();

            Content = flexLayout;
        }

        //Functions
        private void SetContent()
        {
            flexLayout = new FlexLayout();

            backTakeBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Back Take"
            };

            takeDownBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Take Down"
            };

            sweepBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Sweep"
            };

            defenseBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Defense"
            };

            guardPassBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Guard Pass"
            };

            submissionBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Submission"
            };

            drillsBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Drills"
            };

            sweepBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiSweep));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiSweep));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Sweep));
                }
                ToggleButtons();
            };

            takeDownBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiTakeDown));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiTakeDown));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.TakeDown));
                }
                ToggleButtons();
            };

            submissionBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiSubmission));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiSubmission));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Submission));
                }
                ToggleButtons();
            };

            guardPassBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiGuardPass));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiGuardPass));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GuardPass));
                }
                ToggleButtons();
            };

            defenseBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiDefense));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiDefense));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Defense));
                }
                ToggleButtons();
            };

            backTakeBtn.Clicked += async (sender, e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiBackTake));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiBackTake));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.BackTake));
                }
                ToggleButtons();
            };

            drillsBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                account = _baseViewModel.GetAccountInformation();

                if (account.Properties["Package"] == "Gi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.GiDrills));
                }
                else if (account.Properties["Package"] == "NoGi")
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.NoGiDrills));
                }
                else
                {
                    await Navigation.PushModalAsync(new SearchPage(Album.Drills));
                }
                ToggleButtons();
            };

            //adding children
            flexLayout.Children.Add(sweepBtn);
            flexLayout.Children.Add(takeDownBtn);
            flexLayout.Children.Add(submissionBtn);
            flexLayout.Children.Add(guardPassBtn);
            flexLayout.Children.Add(defenseBtn);
            flexLayout.Children.Add(backTakeBtn);
            flexLayout.Children.Add(drillsBtn);
        }

        private void ToggleButtons()
        {
            sweepBtn.IsEnabled = !sweepBtn.IsEnabled;
            backTakeBtn.IsEnabled = !backTakeBtn.IsEnabled;
            takeDownBtn.IsEnabled = !takeDownBtn.IsEnabled;
            guardPassBtn.IsEnabled = !guardPassBtn.IsEnabled;
            submissionBtn.IsEnabled = !submissionBtn.IsEnabled;
            defenseBtn.IsEnabled = !defenseBtn.IsEnabled;
            drillsBtn.IsEnabled = !drillsBtn.IsEnabled;
        }

        private void PortraitLayout()
        {
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
            flexLayout.AlignContent = FlexAlignContent.Stretch;
            flexLayout.AlignItems = FlexAlignItems.Stretch;
        }

        private void LandscapeLayout()
        {
            flexLayout.Direction = FlexDirection.Row;
            flexLayout.Wrap = FlexWrap.Wrap;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;
            flexLayout.AlignContent = FlexAlignContent.SpaceAround;
            flexLayout.AlignItems = FlexAlignItems.Center;
        }

        private void UpdateLayout()
        {
            if (this.Width > this.Height)
                LandscapeLayout();
            else
                PortraitLayout();
        }

        //Orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                UpdateLayout();
            }
        }
    }
}

