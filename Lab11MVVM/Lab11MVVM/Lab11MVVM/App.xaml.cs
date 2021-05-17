using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab11MVVM.Views;

namespace Lab11MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new Operations();
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
