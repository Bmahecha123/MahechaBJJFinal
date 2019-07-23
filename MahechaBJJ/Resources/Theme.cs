using System;
using Xamarin.Forms;

namespace MahechaBJJ.Resources
{
    public class Theme
    {
        public static Color Red { get
            {
                return Color.FromRgb(124, 37, 41);
            }
        }

        public static Color Blue { get
            {
                return Color.FromRgb(58, 93, 174);
            }
        }

        public static Color Black { get
            {
                return Color.FromHex("#070d18");
            }
        }

        public static Color White { get
            {
                return Color.FromHex("#F1ECCE");
            }
        }

        public static Color Azure {  get
            {
                return Color.FromHex("#F2FDFF");
            }
         }

        public static string Font { get
            {
#if __ANDROID__
                return "american_typewriter_bold_bt.ttf#american_typewriter_bold_bt";
#endif
#if __IOS__
				return "AmericanTypewriter-Bold";
#endif

            }
        }

        public static Style BlueButton
        {
            get
            {
                var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));

                return new Style(typeof(Button))
                {
                    Class = "Common_Blue_Button",
                    Setters =
                    {
                        new Setter
                        {
                            Property = VisualElement.BackgroundColorProperty,
                            Value = Theme.Blue
                        },
                        new Setter
                        {
                            Property = Button.FontSizeProperty,
                            Value = size
                        },
                        new Setter
                        {
                            Property = Button.TextColorProperty,
                            Value = Theme.Azure
                        },
                        new Setter
                        {
                            Property = Button.FontFamilyProperty,
                            Value = Theme.Font
                        }
                    }
                };
            }
        }

        public static Style RedButton
        {
            get
            {
                var size = Device.GetNamedSize(NamedSize.Large, typeof(Button));

                return new Style(typeof(Button))
                {
                    Class = "Common_Red_Button",
                    Setters =
                    {
                        new Setter
                        {
                            Property = VisualElement.BackgroundColorProperty,
                            Value = Theme.Red
                        },
                        new Setter
                        {
                            Property = Button.FontSizeProperty,
                            Value = size
                        },
                        new Setter
                        {
                            Property = Button.TextColorProperty,
                            Value = Theme.Azure
                        },
                        new Setter
                        {
                            Property = Button.FontFamilyProperty,
                            Value = Theme.Font
                        }
                    }
                };
            }
        }

        public static Thickness Thickness { get
            {
#if __ANDROID__
                return new Thickness(20, 20, 20, 20);
#endif
#if __IOS__
                return new Thickness(20, 30, 20, 20);
#endif
            }
        }

        public Theme()
        {
        }
    }
}
