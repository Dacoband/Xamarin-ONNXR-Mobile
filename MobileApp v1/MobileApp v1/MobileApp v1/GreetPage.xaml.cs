using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp_v1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        Button goodButton;
        StackLayout layout = new StackLayout();
        public GreetPage()
        {
            InitializeComponent();
            goodButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "GOD MAN"
            };
            goodButton.Clicked += GoodButton_Clicked;
            layout.Children.Add(goodButton);
            Content = layout;
        }

        private void GoodButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("GOD", "Hell", "oke");
        }
    }
}