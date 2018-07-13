using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Resources;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.PlaylistPages;
using Xamarin.Auth;

using Xamarin.Forms;

#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using MahechaBJJ.Droid;
#endif

namespace MahechaBJJ.Views.PlaylistPages
{
    public class PlaylistCreatePage : ContentPage
    {
        private BaseViewModel _baseViewModel;
        private PlaylistCreatePageViewModel _playlistCreatePageViewModel;
        private string FINDUSER = Constants.FINDUSER;
        private Grid outerGrid;
        private Grid innerGrid;
        private Label playListNameLbl;
        private Entry playListNameEntry;
        private Label playListDescriptionLbl;
        private Editor playListDescriptionEditor;
        private Frame editorFrame;
        private Button backBtn;
        private Button createBtn;
        private Account account;
        private User user;
        private PlayList playlist;

#if __ANDROID__
        private Android.Widget.EditText androidPlaylistNameEntry;
        private Android.Widget.EditText androidPlaylistDescriptionEntry;
        private Android.Widget.Button androidCreateBtn;

        private ContentView contentViewAndroidPlaylistNameEntry;
        private ContentView contentViewAndroidPlaylistDescriptionEntry;
        private ContentView contentViewAndroidCreateBtn;
#endif

        public PlaylistCreatePage()
        {
            _baseViewModel = new BaseViewModel();
            _playlistCreatePageViewModel = new PlaylistCreatePageViewModel();
            BackgroundColor = Color.FromHex("#F1ECCE");

            //View objects
            Title = "Create Playlist";
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif

            BuildPageObjects();
        }

        //functions
        public void BuildPageObjects()
        {
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));

            //Layout
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    #if __ANDROID__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
#endif
#if __IOS__
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
#endif
                  
                },
#if __IOS__
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
#endif
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
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
                Text = "Name:"
            };
            playListNameEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize * .75,
#endif
                Placeholder = "Leg Lasso List"

            };
            playListDescriptionLbl = new Label
            {
                Text = "Description:",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = -5,
#endif
            };
            playListDescriptionEditor = new Editor
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Editor)),
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                BackgroundColor = Color.White
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
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                BackgroundColor = Color.FromRgb(124, 37, 41),
                TextColor = Color.Black
            };
            createBtn = new Button
            {
                Text = "Create",
                BorderWidth = 3,
                BorderColor = Color.Black,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 2,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize * 1.25,
#endif
                BackgroundColor = Color.FromRgb(58, 93, 174),
                TextColor = Color.Black
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidPlaylistNameEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidPlaylistNameEntry.Hint = "Enter Name";
            androidPlaylistNameEntry.Typeface = Constants.COMMONFONT;
            androidPlaylistNameEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 100);
            androidPlaylistNameEntry.SetTextColor(Android.Graphics.Color.Black);
            androidPlaylistNameEntry.Gravity = Android.Views.GravityFlags.Start;
            androidPlaylistNameEntry.InputType = Android.Text.InputTypes.TextFlagNoSuggestions;

            androidPlaylistDescriptionEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidPlaylistDescriptionEntry.Hint = "Enter Description";
            androidPlaylistDescriptionEntry.Typeface = Constants.COMMONFONT;
            androidPlaylistDescriptionEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidPlaylistDescriptionEntry.SetTextColor(Android.Graphics.Color.Black);
            androidPlaylistDescriptionEntry.Gravity = Android.Views.GravityFlags.Start;
            androidPlaylistDescriptionEntry.InputType = Android.Text.InputTypes.TextVariationLongMessage;

            androidCreateBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidCreateBtn.Text = "Create Playlist";
            androidCreateBtn.Typeface = Constants.COMMONFONT;
            androidCreateBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidCreateBtn.SetTextColor(Android.Graphics.Color.Black);
            androidCreateBtn.SetBackground(pd);
            androidCreateBtn.Gravity = Android.Views.GravityFlags.Center;
            androidCreateBtn.SetAllCaps(false);
            androidCreateBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await CreatePlaylist(sender, e);
                ToggleButtons();
            };


            contentViewAndroidPlaylistNameEntry = new ContentView();
            contentViewAndroidPlaylistNameEntry.Content = androidPlaylistNameEntry.ToView();
            contentViewAndroidPlaylistDescriptionEntry = new ContentView();
            contentViewAndroidPlaylistDescriptionEntry.Content = androidPlaylistDescriptionEntry.ToView();
            contentViewAndroidCreateBtn = new ContentView();
            contentViewAndroidCreateBtn.Content = androidCreateBtn.ToView();
#endif

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
#endif
#if __ANDROID__
            //building grid
            innerGrid.Children.Add(contentViewAndroidPlaylistNameEntry, 0, 2);
            innerGrid.Children.Add(contentViewAndroidPlaylistDescriptionEntry, 0, 3);
            innerGrid.Children.Add(contentViewAndroidCreateBtn, 0, 6);
#endif

            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }

        public async Task CreatePlaylist(object sender, EventArgs e)
        {
#if __IOS__
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
#endif
#if __ANDROID__
            if (!string.IsNullOrWhiteSpace(androidPlaylistNameEntry.Text))
            {
                playlist = new PlayList();
                playlist.Name = androidPlaylistNameEntry.Text;
                playlist.Description = androidPlaylistDescriptionEntry.Text;
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
                androidPlaylistNameEntry.RequestFocus();
            }
#endif
        }

        private void ToggleButtons()
        {
            backBtn.IsEnabled = !backBtn.IsEnabled;
            createBtn.IsEnabled = !createBtn.IsEnabled;
#if __ANDROID__
            androidCreateBtn.Clickable = !androidCreateBtn.Clickable;
#endif
        }

        //Orientation
#if __IOS__
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
#if __ANDROID__
                Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
                Padding = new Thickness(10, 30, 10, 10);
#endif
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
#endif
    }
}

