using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gd_cplatform_app
{
    public partial class App : Application
    {
        public App()
        {
           MainPage = new NavigationPage(new MainPage());
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
