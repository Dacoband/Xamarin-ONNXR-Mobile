using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyStackLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutinCode : ContentPage
    {
        public StackLayoutinCode()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                BackgroundColor = Color.Aqua,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(20, 20, 30, 20),
                Children =
                {
                    new Button{Text = "Button1"},
                    new Button{Text = "Button2"},
                    new Button{Text = "Button3"},
                    new StackLayout
                    {
                        BackgroundColor = Color.Yellow,
                        Children =
                        {
                            new Button{Text = "Button4"},
                            new Button{Text = "Button5"}
                        }

                    }
                }
            };
        }
    }
}