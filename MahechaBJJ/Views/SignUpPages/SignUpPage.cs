using System;
using System.Collections.ObjectModel;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel.CommonPages;
using MahechaBJJ.ViewModel.EntryPages;
using MahechaBJJ.Resources;
using Xamarin.Forms;
using Xamarin.Auth;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using MahechaBJJ.Views.SignUpPages;
using MahechaBJJ.ViewModel.SignUpPages;
using System.Threading.Tasks;
#if __ANDROID__
using MahechaBJJ.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using Android.Text.Method;
#endif

namespace MahechaBJJ.Views.SignUpPages
{
    public class SignUpPage : ContentPage
    {
        //ViewModel
        private BaseViewModel _baseViewModel;
        private SummaryPageViewModel _summaryPageViewModel;
        //declare objects
        private Package package;
        private Label nameLbl;
        private Entry nameEntry;
        private Label beltLbl;
        private Picker beltPicker;
        private ObservableCollection<string> beltList;
        private Label emailAddressLbl;
        private Entry emailAddressEntry;
        private Label passWordLbl;
        private Entry passWordEntry;
        private Label secretQuestionLbl;
        private Picker secretQuestionPicker;
        private Entry secretQuestionEntry;
        private Button nextBtn;
        private Button backBtn;
        private Button clearBtn;
        private User user;
        private ObservableCollection<string> secretQuestionList;
        private TableView tableView;
        private StackLayout stackLayout;
        private ScrollView scrollView;
        private Grid innerGrid;
        private Grid outerGrid;
        private Grid buttonGrid;
        private bool hasPackage;
        private Account _account;
#if __ANDROID__
        Android.Widget.EditText androidNameEntry;
        Android.Widget.TextView androidBeltLbl;
        Android.Widget.EditText androidEmailAddressEntry;
        Android.Widget.EditText androidPassWordEntry;
        Android.Widget.TextView androidSecretQuestionsLbl;
        Android.Widget.EditText androidSecretQuestionEntry;
        Android.Widget.Button androidNextBtn;
#endif

        public SignUpPage(Package package)
        {
            BackgroundColor = Color.FromHex("#F1ECCE");
            _baseViewModel = new BaseViewModel();
            this.hasPackage = true;
#if __ANDROID__
            Padding = new Thickness(5, 5, 5, 5);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            this.package = package;
            SetContent();
        }

        public SignUpPage()
        {
            BackgroundColor = Color.FromHex("#F1ECCE");
            _summaryPageViewModel = new SummaryPageViewModel();
            _baseViewModel = new BaseViewModel();
            this.hasPackage = false;
#if __ANDROID__
            Padding = new Thickness(10, 10, 10, 10);
#endif
#if __IOS__
            Padding = new Thickness(10, 30, 10, 10);
#endif
            SetContent();
        }

        //functions
        private void SetContent()
        {

            var btnSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            var lblSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            var entrySize = Device.GetNamedSize(NamedSize.Large, typeof(Entry));

            //View objects
            beltLbl = new Label
            {
                Text = "Belt",
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = new Thickness(0, -5, 0, -5),
#endif
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            beltList = new ObservableCollection<string>();
            beltList.Add("White");
            beltList.Add("Blue");
            beltList.Add("Purple");
            beltList.Add("Brown");
            beltList.Add("Black");
            beltPicker = new Picker
            {
                Title = "Choose Your Rank",
                ItemsSource = beltList
            };
            nameLbl = new Label
            {

#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = new Thickness(0, -5, 0, -5),
#endif
                Text = "Name",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nameEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = entrySize * .5,
                Margin = new Thickness(0, -5, 0, -5),
#endif
                Placeholder = "Brian Mahecha",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            emailAddressLbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = lblSize,
                Margin = new Thickness(0, -5, 0, -5),
#endif
                Text = "E-Mail Address",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };
            emailAddressEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
                FontSize = entrySize * .5,
#endif
                Placeholder = "admin@Mahechabjj.com",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            passWordLbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
                FontSize = lblSize,
#endif
                Text = "Password",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            passWordEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
                FontSize = entrySize * .5,
#endif
                IsPassword = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            secretQuestionLbl = new Label
            {
#if __IOS__
                FontFamily = "AmericanTypewriter-Bold",
                FontSize = lblSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
                FontSize = lblSize,
#endif
                Text = "Secret Questions",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            secretQuestionList = new ObservableCollection<String>();
            secretQuestionList.Add("What city were you born in?");
            secretQuestionList.Add("What city was your high school?");
            secretQuestionList.Add("Name of favorite instructor.");
            secretQuestionPicker = new Picker
            {
                Title = "Select a secret question to answer!",
                ItemsSource = secretQuestionList
            };
            secretQuestionEntry = new Entry
            {
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = entrySize,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                Margin = new Thickness(0, -5, 0, -5),
                FontSize = entrySize * .5,
#endif
                Placeholder = "Answer for your own security!",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nextBtn = new Button
            {
                Style = (Style)Application.Current.Resources["common-blue-btn"],
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
                FontSize = btnSize * 1.5,
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
                FontSize = btnSize,
#endif
                Text = "Next",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            backBtn = new Button
            {
                Style = (Style)Application.Current.Resources["common-red-btn"],
                Image = "trash.png",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            clearBtn = new Button
            {
                Style = (Style)Application.Current.Resources["common-red-btn"],
#if __IOS__
				FontFamily = "AmericanTypewriter-Bold",
#endif
#if __ANDROID__
                FontFamily = "Roboto Bold",
#endif
                Text = "Clear",
                FontSize = btnSize
            };

#if __ANDROID__
            var pd = new PaintDrawable(Android.Graphics.Color.Rgb(58, 93, 174));
            pd.SetCornerRadius(100);

            androidNameEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidNameEntry.Hint = "Name";
            androidNameEntry.Typeface = Constants.COMMONFONT;
            androidNameEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidNameEntry.SetTextColor(Android.Graphics.Color.Black);
            androidNameEntry.Gravity = Android.Views.GravityFlags.Start;
            androidNameEntry.InputType = Android.Text.InputTypes.TextVariationPersonName;

            androidBeltLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidBeltLbl.Text = "Belt";
            androidBeltLbl.Typeface = Constants.COMMONFONT;
            androidBeltLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidBeltLbl.SetTextColor(Android.Graphics.Color.Black);
            androidBeltLbl.Gravity = Android.Views.GravityFlags.Start;

            androidEmailAddressEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidEmailAddressEntry.Hint = "E-Mail Address";
            androidEmailAddressEntry.Typeface = Constants.COMMONFONT;
            androidEmailAddressEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidEmailAddressEntry.SetTextColor(Android.Graphics.Color.Black);
            androidEmailAddressEntry.Gravity = Android.Views.GravityFlags.Start;
            androidEmailAddressEntry.InputType = Android.Text.InputTypes.TextVariationEmailAddress;

            androidPassWordEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidPassWordEntry.Hint = "Password";
            androidPassWordEntry.Typeface = Constants.COMMONFONT;
            androidPassWordEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidPassWordEntry.SetTextColor(Android.Graphics.Color.Black);
            androidPassWordEntry.Gravity = Android.Views.GravityFlags.Start;
            androidPassWordEntry.InputType = Android.Text.InputTypes.TextVariationPassword;
            androidPassWordEntry.TransformationMethod = new PasswordTransformationMethod();


            androidSecretQuestionsLbl = new Android.Widget.TextView(MainApplication.ActivityContext);
            androidSecretQuestionsLbl.Text = "Secret Questions";
            androidSecretQuestionsLbl.Typeface = Constants.COMMONFONT;
            androidSecretQuestionsLbl.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidSecretQuestionsLbl.SetTextColor(Android.Graphics.Color.Black);
            androidSecretQuestionsLbl.Gravity = Android.Views.GravityFlags.Start;

            androidSecretQuestionEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidSecretQuestionEntry.Hint = "Answer for your own security!";
            androidSecretQuestionEntry.Typeface = Constants.COMMONFONT;
            androidSecretQuestionEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidSecretQuestionEntry.SetTextColor(Android.Graphics.Color.Black);
            androidSecretQuestionEntry.Gravity = Android.Views.GravityFlags.Start;
            androidSecretQuestionEntry.InputType = Android.Text.InputTypes.TextVariationShortMessage;

            androidNextBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidNextBtn.Text = "Next";
            androidNextBtn.Typeface = Constants.COMMONFONT;
            androidNextBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidNextBtn.SetBackground(pd);
            androidNextBtn.SetTextColor(Android.Graphics.Color.Rgb(242, 253, 255));
            androidNextBtn.Gravity = Android.Views.GravityFlags.Center;
            androidNextBtn.Click += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Validate();
                ToggleButtons();
            };
            androidNextBtn.SetAllCaps(false);

            /*androidBlogBtn = new Android.Widget.Button(MainApplication.ActivityContext);
            androidBlogBtn.Text = "Learn More";
            androidBlogBtn.SetAutoSizeTextTypeWithDefaults(Android.Widget.AutoSizeTextType.Uniform);
            androidBlogBtn.SetBackgroundColor(Android.Graphics.Color.Rgb(58, 93, 174));
            androidBlogBtn.SetTextColor(Android.Graphics.Color.Black);
            androidBlogBtn.Gravity = Android.Views.GravityFlags.Center; 

            androidEmailEntry = new Android.Widget.EditText(MainApplication.ActivityContext);
            androidEmailEntry.Hint = "E-Mail Address";
            androidEmailEntry.SetTextSize(Android.Util.ComplexUnitType.Fraction, 75);
            androidEmailEntry.SetPadding(0, 0, 0, 0);
            androidEmailEntry.SetTextColor(Android.Graphics.Color.Black);
            androidEmailEntry.InputType = Android.Text.InputTypes.TextVariationEmailAddress;*/
#endif

            //Events
            nextBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Validate();
                ToggleButtons();
            };
            backBtn.Clicked += async (object sender, EventArgs e) =>
            {
                ToggleButtons();
                await Navigation.PopModalAsync();
                ToggleButtons();
            };
            //passWordRepeatEntry.Unfocused += PasswordMatch;
            //TODO add specific validation events to make sure entries are correct.

            tableView = new TableView();
            tableView.Intent = TableIntent.Form;
            tableView.BackgroundColor = Color.White;
            tableView.Root = new TableRoot()
            {
                new TableSection() {
                    new ViewCell {
                        View = nameLbl
                    },
                    new ViewCell {
                        View = nameEntry
                    },
                    new ViewCell {
                        View = emailAddressLbl
                    },
                    new ViewCell {
                        View = emailAddressEntry
                    },
                    new ViewCell {
                        View = beltLbl
                    },
                    new ViewCell {
                        View = beltPicker
                    },
                    new ViewCell {
                        View = passWordLbl
                    },
                    new ViewCell {
                        View = passWordEntry
                    },
                    new ViewCell {
                        View = secretQuestionLbl
                    },
                    new ViewCell {
                        View = secretQuestionPicker
                    },
                    new ViewCell {
                        View = secretQuestionEntry
                    }
                }
            };
#if __IOS__
            buttonGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
				},
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
				}
			};
            buttonGrid.Children.Add(backBtn, 0, 0);
            buttonGrid.Children.Add(nextBtn, 1, 0);
#endif
#if __ANDROID__
            buttonGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };
            buttonGrid.Children.Add(androidNextBtn.ToView(), 0, 0);
#endif

            scrollView = new ScrollView();
#if __IOS__
            stackLayout = new StackLayout
            {
                Children = {
                    tableView
                }
            };
#endif
#if __ANDROID__
            stackLayout = new StackLayout
            {
                Children = {
                    androidNameEntry.ToView(),
                    androidEmailAddressEntry.ToView(),
                    androidBeltLbl.ToView(),
                    beltPicker,
                    androidPassWordEntry.ToView(),
                    androidSecretQuestionsLbl.ToView(),
                    secretQuestionPicker,
                    androidSecretQuestionEntry.ToView()
                }
            };
#endif
            scrollView.Content = stackLayout;
#if __ANDROID__
            scrollView.IsClippedToBounds = true;
#endif

#if __IOS__
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(9, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
#endif
#if __ANDROID__
            innerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(9, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
#endif
            outerGrid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
            innerGrid.Children.Add(scrollView, 0, 0);
            innerGrid.Children.Add(buttonGrid, 0, 1);
            outerGrid.Children.Add(innerGrid);
            Content = outerGrid;
        }

        private async Task Validate()
        {
            if (this.hasPackage)
            {
#if __ANDROID__
                if (!string.IsNullOrWhiteSpace(androidNameEntry.Text) || !string.IsNullOrWhiteSpace(androidEmailAddressEntry.Text) || !string.IsNullOrWhiteSpace(androidPassWordEntry.Text)
                    || !string.IsNullOrWhiteSpace(androidSecretQuestionEntry.Text))
#endif
#if __IOS__
                if (!string.IsNullOrWhiteSpace(nameEntry.Text) || !string.IsNullOrWhiteSpace(emailAddressEntry.Text) || !string.IsNullOrWhiteSpace(passWordEntry.Text)
                    || !string.IsNullOrWhiteSpace(secretQuestionEntry.Text))
#endif
                {
                    CreateUser();
                    await Navigation.PushModalAsync(new SummaryPage(user));
                }
                else
                {
                    await DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
                }
            }
            else
            {
                _account = _baseViewModel.GetAccountInformation();
                if (_account.Properties["Package"] == "Gi")
                {
                    this.package = Package.Gi;
                }
                else if (_account.Properties["Package"] == "NoGi")
                {
                    this.package = Package.NoGi;
                }
                else
                {
                    this.package = Package.GiAndNoGi;
                }

#if __ANDROID__
                if (androidNameEntry.Text != null || androidEmailAddressEntry.Text != null || androidPassWordEntry.Text != null
                || androidSecretQuestionEntry.Text != null)
#endif
#if __IOS__
                if (nameEntry.Text != null || emailAddressEntry.Text != null || passWordEntry.Text != null
                || secretQuestionEntry.Text != null)
#endif
                {
                    CreateUser();
                    await _summaryPageViewModel.CreateUser(user);
                    _baseViewModel.DeleteCredentials();
                    _baseViewModel.SaveCredentials(_summaryPageViewModel.User);
                    Application.Current.MainPage = new MainTabbedPage(true);
                }
                else
                {
                    await DisplayAlert("Sign Up Error", "Make sure all fields are filled in!", "Okay, got it.");
                }
            }
        }

        private void ToggleButtons()
        {
#if __ANDROID__
            androidNextBtn.Clickable = !androidNextBtn.Clickable;
#endif
            backBtn.IsEnabled = !backBtn.IsEnabled;
            nextBtn.IsEnabled = !nextBtn.IsEnabled;
        }

        private void CreateUser()
        {
            user = new User();
#if __IOS__
            user.Name = nameEntry.Text;
            user.Email = emailAddressEntry.Text;
            Packages packages = new Packages();
            if (package == Package.Gi)
            {
                packages.GiJiuJitsu = true;
            }
            else if (package == Package.NoGi)
            {
                packages.NoGiJiuJitsu = true;
            }
            else
            {
                packages.GiAndNoGiJiuJitsu = true;
            }
            user.Packages = packages;
            user.Password = passWordEntry.Text;
            user.SecretQuestion = secretQuestionPicker.SelectedItem.ToString();
            user.SecretQuestionAnswer = secretQuestionEntry.Text.ToLower();
            user.Belt = beltPicker.SelectedItem.ToString();
#endif
#if __ANDROID__
            user.Name = androidNameEntry.Text;
            user.Email = androidEmailAddressEntry.Text;
            Packages packages = new Packages();
            if (package == Package.Gi)
            {
                packages.GiJiuJitsu = true;
            }
            else if (package == Package.NoGi)
            {
                packages.NoGiJiuJitsu = true;
            }
            else
            {
                packages.GiAndNoGiJiuJitsu = true;
            }
            user.Packages = packages;
            user.Password = androidPassWordEntry.Text;
            user.SecretQuestion = secretQuestionPicker.SelectedItem.ToString();
            user.SecretQuestionAnswer = androidSecretQuestionEntry.Text.ToLower();
            user.Belt = beltPicker.SelectedItem.ToString();
#endif
        }

#if __ANDROID__
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (width > height)
            {
                Padding = new Thickness(5, 5, 5, 5);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });


                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
            }
            else
            {

                Padding = new Thickness(5, 5, 5, 5);
                innerGrid.Children.Clear();
                innerGrid.RowDefinitions.Clear();
                innerGrid.ColumnDefinitions.Clear();

                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(9, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

                innerGrid.Children.Add(scrollView, 0, 0);
                innerGrid.Children.Add(buttonGrid, 0, 1);
            }
        }
#endif
    }
}

