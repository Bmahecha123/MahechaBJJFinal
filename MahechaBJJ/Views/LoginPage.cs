using System;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class LoginPage : ContentPage
    {
        private readonly SignInPageViewModel _signInPageViewModel = new SignInPageViewModel();
        private readonly BaseViewModel _baseViewModel = new BaseViewModel();
        private const string VIMEOURL = "https://api.vimeo.com/me/videos?access_token=5d3d5a50aae149bd4765bbddf7d94952&per_page=2";
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
        private User user;


        public LoginPage()
        {
            Padding = new Thickness(10, 30, 10, 10);
            var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));
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
                FontSize = size * 2,
#if __IOS__
                FontFamily = "ChalkboardSE-Bold"
#endif
#if __ANDROID__
				FontFamily = "Roboto Bold",
#endif
			};
            emailEntry = new Entry
            {
                Placeholder = "SpiderGuard123@gmail.com",
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
				FontFamily = "Roboto Bold",
#endif
				FontSize = size
            };
            passwordLbl = new Label
            {
                Text = "Password",
				FontSize = size * 2,
#if __IOS__
				FontFamily = "ChalkboardSE-Bold"
#endif
#if __ANDROID__
				FontFamily = "Roboto Bold",
#endif
			};
            passwordEntry = new Entry
            {
				Placeholder = "SpiderGuard123@gmail.com",
                IsPassword = true,
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
				FontFamily = "Roboto Bold",
#endif
				FontSize = size
            };
            loginBtn = new Button
            {
                Text = "Login",
                FontSize = size * 2,
#if __IOS__
				FontFamily = "ChalkboardSE-Bold",
#endif
#if __ANDROID__
				FontFamily = "Roboto Bold",
#endif
				BackgroundColor = Color.Orange,
                TextColor = Color.Black
            };
            //Events
            loginBtn.Clicked += Login;

            innerGrid.Children.Add(mahechaLogo, 0, 0);
            innerGrid.Children.Add(emailLbl, 0, 1);
            innerGrid.Children.Add(emailEntry, 0, 2);
            innerGrid.Children.Add(passwordLbl, 0, 3);
            innerGrid.Children.Add(passwordEntry, 0, 4);
            innerGrid.Children.Add(loginBtn, 0, 5);
            outerGrid.Children.Add(innerGrid, 0, 0);

            Content = outerGrid;
        }
		//functions
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
                innerGrid.Children.Add(loginBtn, 1, 2);
                Grid.SetColumnSpan(loginBtn, 2);
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
                innerGrid.Children.Clear();
                innerGrid.Children.Add(mahechaLogo, 0, 0);
                innerGrid.Children.Add(emailLbl, 0, 1);
                innerGrid.Children.Add(emailEntry, 0, 2);
                innerGrid.Children.Add(passwordLbl, 0, 3);
                innerGrid.Children.Add(passwordEntry, 0, 4);
                innerGrid.Children.Add(loginBtn, 0, 5);
            }
		}
    }
}

