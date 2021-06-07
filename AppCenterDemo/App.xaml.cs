using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace AppCenterDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=9e0a7c0e-4629-4765-845f-cdc25a62f738;" +
                     "uwp={Your UWP App secret here};" +
                     "ios=7de8d37b-3727-4770-a7f7-f3ec332cebcf",
                     typeof(Analytics), typeof(Crashes));

            Analytics.TrackEvent("application Started");
         
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
