using System;
using Xamarin.Forms;

namespace AccessXAMLElement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            rotatingLable.Text = _quotes[0];
            rotatingLable.TextColor = _colors[0];
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                AutoNextQuote();
                return true;
            });
        }
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "\"Life is like riding a bicycle. To keep your balance, you must keep moving.\"",
            "\"Anyone who has never made a mistake has never tried anything new.\"",
            "\"Try not to become a man of success. Rather become a man of value.\"",
            "\"Logic will get you from A to Z; imagination will get you everywhere.\"",
        };
        private Color[] _colors = new Color[]
        {
            Color.Black,
            Color.Red,
            Color.Blue,
            Color.Aqua,
            Color.Brown,
            Color.Crimson,
            Color.Pink,
            Color.DarkOrange,
            Color.DarkGreen
        };

        private void slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int index = (int)Math.Round(slider2.Value);
            if (index >= 0 && index < _colors.Length)
            {
                rotatingLable.TextColor = _colors[index];
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await rotatingLable.FadeTo(0, 500); 
            _index++;
            if (_index == _quotes.Length)
            {
                _index = 0;
            }
            rotatingLable.Text = _quotes[_index];
            await rotatingLable.FadeTo(1, 500);
        }

        private async void AutoNextQuote()
        {
            await rotatingLable.FadeTo(0, 500); 
            _index++;
            if (_index == _quotes.Length)
            {
                _index = 0;
            }
            rotatingLable.Text = _quotes[_index];
            await rotatingLable.FadeTo(1, 500); 
        }
    }
}
