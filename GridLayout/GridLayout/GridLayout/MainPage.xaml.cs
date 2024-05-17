using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Grid myGrid = new Grid()
            {
                BackgroundColor = Color.WhiteSmoke,
                RowSpacing =1,
                ColumnSpacing =3,
                RowDefinitions =
                {
                    new RowDefinition{ Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition{ Height = new GridLength(75)},
                    new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{ Height = new GridLength(150)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(75)},
                    new ColumnDefinition (),
                    new ColumnDefinition {Width = new GridLength(2, GridUnitType.Star)}
                }
            };
            Label lbl1 = new Label { Text= "YuLocKii", BackgroundColor = Color.White};
            Label lbl2 = new Label { Text = "ConLocVoTan", BackgroundColor = Color.White };
            Label lbl3 = new Label { Text = "Fukasa Mikenko", BackgroundColor = Color.White };
            Label lbl4 = new Label { Text = "Emi Fukada", BackgroundColor = Color.White };
            Label lbl5 = new Label { Text = "Romeo", BackgroundColor = Color.White };
            Label lbl6 = new Label { Text = "Juliette", BackgroundColor = Color.White };
            Label lbl7 = new Label { Text = "Black Storm", BackgroundColor = Color.White };
            Label lbl8 = new Label { Text = "Rye", BackgroundColor = Color.White };

            myGrid.Children.Add(lbl1, 0, 0);
            myGrid.Children.Add(lbl2, 0, 1);
            myGrid.Children.Add(lbl3, 0, 2);
            myGrid.Children.Add(lbl4, 0, 3);
            myGrid.Children.Add(lbl5, 1, 0);
            myGrid.Children.Add(lbl6, 1, 1);
            myGrid.Children.Add(lbl7, 1, 2);
            myGrid.Children.Add(lbl8, 2, 0);

            Grid.SetRowSpan(lbl8, 3);
            Grid.SetColumnSpan(lbl4, 3);

            Content = myGrid;
        }
    }
}
