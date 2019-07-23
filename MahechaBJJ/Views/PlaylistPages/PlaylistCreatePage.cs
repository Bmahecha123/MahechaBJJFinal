using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistCreatePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private PlaylistCreatePageViewModel _playlistCreatePageViewModel;
        private string FINDUSER = Constants.FINDUSER;
        private FlexLayout flexLayout;
        private StackLayout buttonStackLayout;
        private Entry playListNameEntry;
        private Editor playListDescriptionEditor;
        private Button backBtn;
        private Button createBtn;
        private Account account;
        private User user;
        private PlayList playlist;

        public PlaylistCreatePage()
        {
            _baseViewModel = new BaseViewModel();
            _playlistCreatePageViewModel = new PlaylistCreatePageViewModel();
            BackgroundColor = Theme.White;
            Padding = Theme.Thickness;
            Visual = VisualMarker.Material;

            Title = "Create Playlist";

            BuildPageObjects();

            Content = flexLayout;
        }

        //functions
        public void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //Layout
            flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Column;
            flexLayout.JustifyContent = FlexJustify.SpaceEvenly;

            buttonStackLayout = new StackLayout();
            buttonStackLayout.Orientation = StackOrientation.Horizontal;

            //View objects
            playListNameEntry = new Entry
            {
				FontFamily = Theme.Font,
                FontSize = lblSize,
                TextColor = Theme.Black,
                Placeholder = "Playlist Name",
                PlaceholderColor = Theme.Black,
                BackgroundColor = Theme.Azure

            };
            playListDescriptionEditor = new Editor
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Editor)),
				FontFamily = Theme.Font,
                TextColor = Theme.Black,
                BackgroundColor = Theme.Azure,
                Placeholder = "Description",
                PlaceholderColor = Theme.Black
            };
            backBtn = new Button
            {
                Style = Theme.RedButton,
                ImageSource = "back.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            createBtn = new Button
            {
                Style = Theme.BlueButton,
                Text = "Create",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            //events
            backBtn.Clicked += async (object sender, EventArgs e) => {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            createBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await CreatePlaylist(sender, e);
                ToggleButtons();
            };

#if __IOS__
            buttonStackLayout.Children.Add(backBtn);
#endif
            buttonStackLayout.Children.Add(createBtn);

            FlexLayout.SetBasis(playListNameEntry, 1);
            FlexLayout.SetBasis(playListDescriptionEditor, 1);

            FlexLayout.SetGrow(playListNameEntry, 1);
            FlexLayout.SetGrow(playListDescriptionEditor, 1);

            flexLayout.Children.Add(playListNameEntry);
            flexLayout.Children.Add(playListDescriptionEditor);
            flexLayout.Children.Add(buttonStackLayout);
        }

        public async Task CreatePlaylist(object sender, EventArgs e)
        {
            if (playListNameEntry.Text != null)
            {
                playlist = new PlayList();
                playlist.Name = playListNameEntry.Text;
                playlist.Description = playListDescriptionEditor.Text;
                account = _baseViewModel.GetAccountInformation();
                user = await _baseViewModel.FindUserByIdAsync(FINDUSER, account.Properties["Id"]);
                await _playlistCreatePageViewModel.CreatePlaylist(playlist, user.Id);
                if (_playlistCreatePageViewModel.Successful)
                {
                    await Navigation.PopModalAsync();
                }
                else
                {
                    await DisplayAlert("Playlist Not Added", playlist.Name + " has not been added. Check your network connectivity!", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Error", "Name cannot be empty, fill it in!", "Ok");
                playListNameEntry.Focus();
            }
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            createBtn.IsEnabled = !createBtn.IsEnabled;
        }
    }
}

