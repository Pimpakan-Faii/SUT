using SUT.Services;
using SUT.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SUT
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Views.LoginPage())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.Black
            };
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
