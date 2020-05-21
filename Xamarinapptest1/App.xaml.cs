using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarinapptest1.Services;
using Xamarinapptest1.Views;

namespace Xamarinapptest1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
