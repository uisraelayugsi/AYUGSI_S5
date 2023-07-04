using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSI_S5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //  MainPage = new Page1();

            MainPage = new NavigationPage(new Page1());
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
