using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS2_BonillaG_NovenoB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage (new Loggin());
            //MainPage = new MainPage();
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
