using BloodGroup.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BloodGroup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new HomePage());
            }
            else if (string.IsNullOrEmpty(Settings.UserName) && string.IsNullOrEmpty(Settings.Password))
            {
                MainPage = new NavigationPage(new SignInPage());
            }
        }

        protected override void OnStart()
        {
            //string androidAppSecret = "524215be-1128-47f0-aee2-b508cf605bd5";
            //AppCenter.Start($"andorid={androidAppSecret}", typeof(Crashes));
            AppCenter.Start("5ecce33b-569b-4290-9655-d55aff5a0ce1", typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
