using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyStackLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutinCode();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
