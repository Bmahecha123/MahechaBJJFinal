using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views.EntryPages
{
    public class LoginPage : ContentPage
    {
        private readonly BaseViewModel _baseViewModel;
        private const string FINDUSER = "http://localhost:8080/user/findByEmail/";
        //declare objects
        private Grid outerGrid;
        private Grid innerGrid;
        private Image mahechaLogo;
        private Label emailLbl;
        private Entry emailEntry;
        private Label passwordLbl;
        private Entry passwordEntry;
        private Button loginBtn;
        private Button backBtn;
        private User user;


        public LoginPage()
        {
            _baseViewModel = new BaseViewModel();
            Padding = new Thickness(10, 30, 10, 10);
            BuildPageObjects();
        }

		//functions
        private void BuildPageObjects()
        {
			var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
			var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
			var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
			//Grid view definition
			outerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				}
			};
			innerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition { Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				},
				ColumnDefinitions = new ColumnDefinitionCollection {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};
			//View objects
			mahechaLogo = new Image
			{
				Source = ImageSource.FromResource("mahechabjjlogo.png"),
				Aspect = Aspect.AspectFit
			};
			emailLbl = new Label
			{
				Text = "E-Mail Address",
				FontSize = lblSize * 2,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center

			};
			emailEntry = new Entry
			{
				Placeholder = "SpiderGuard123@gmail.com",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize,
			};
			passwordLbl = new Label
			{
				Text = "Password",
				FontSize = lblSize * 2,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalTextAlignment = TextAlignment.Center
			};
			passwordEntry = new Entry
			{
				IsPassword = true,
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
				FontSize = entrySize
			};
			loginBtn = new Button
			{
				Text = "Login",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
				BackgroundColor = Color.Orange,
				TextColor = Color.Black,
				BorderWidth = 3,
				BorderColor = Color.Black
			};
			backBtn = new Button
			{
				Text = "Back",
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                FontSize = btnSize * 2,
                BackgroundColor = Color.Orange,
                TextColor = Color.Black,
                BorderWidth = 3,
                BorderColor = Color.Black
			};
			//Events
			loginBtn.Clicked += Validate;
			backBtn.Clicked += GoBack;

			innerGrid.Children.Add(mahechaLogo, 0, 0);
			Grid.SetColumnSpan(mahechaLogo, 2);
			innerGrid.Children.Add(emailLbl, 0, 1);
			Grid.SetColumnSpan(emailLbl, 2);
			innerGrid.Children.Add(emailEntry, 0, 2);
			Grid.SetColumnSpan(emailEntry, 2);
			innerGrid.Children.Add(passwordLbl, 0, 3);
			Grid.SetColumnSpan(passwordLbl, 2);
			innerGrid.Children.Add(passwordEntry, 0, 4);
			Grid.SetColumnSpan(passwordEntry, 2);
			innerGrid.Children.Add(backBtn, 0, 5);
			innerGrid.Children.Add(loginBtn, 1, 5);
			outerGrid.Children.Add(innerGrid, 0, 0);

			Content = outerGrid;
        }

        private void Validate(object sender, EventArgs e)
        {
            if(emailEntry.Text != null || passwordEntry.Text != null)
            {
                Login(sender, e);
            }
            else
            {
                DisplayAlert("Login Error!", "Make sure all fields are filled in!", "Ok, got it.");
            }
        }

        private async void Login(object sender, EventArgs e)
        {
            user = await _baseViewModel.FindUserByEmailAsync(FINDUSER, emailEntry.Text);
            if (user == null) {
                await DisplayAlert("User Not Found", "User " + emailEntry.Text + " does not exist.", "Got It");
            }
            else 
            {
				if (user.password == passwordEntry.Text)
				{
					_baseViewModel.SaveCredentials(user.Email, user.password, user.Id);
					Application.Current.MainPage = new MainTabbedPage();
				}
				else
				{
					await DisplayAlert("Wrong Password!", "Password for " + emailEntry.Text + " is incorrect.", "Ok");
				}
            }

        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

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
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetRowSpan(mahechaLogo, 3);
                innerGrid.Children.Add(emailLbl, 1, 0);
                innerGrid.Children.Add(emailEntry, 2, 0);
                innerGrid.Children.Add(passwordLbl, 1, 1);
                innerGrid.Children.Add(passwordEntry, 2, 1);
                innerGrid.Children.Add(backBtn, 1, 2);
                innerGrid.Children.Add(loginBtn, 2, 2);
            }
            else
            {
                Padding = new Thickness(10, 30, 10, 10);
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
				innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                Grid.SetColumnSpan(mahechaLogo, 2);
                innerGrid.Children.Add(emailLbl, 0, 1);
                Grid.SetColumnSpan(emailLbl, 2);
                innerGrid.Children.Add(emailEntry, 0, 2);
                Grid.SetColumnSpan(emailEntry, 2);
				innerGrid.Children.Add(passwordLbl, 0, 3);
                Grid.SetColumnSpan(passwordLbl, 2);
				innerGrid.Children.Add(passwordEntry, 0, 4);
                Grid.SetColumnSpan(passwordEntry, 2);
                innerGrid.Children.Add(backBtn, 0, 5);
				innerGrid.Children.Add(loginBtn, 1, 5);
            }
		}
    }
}

