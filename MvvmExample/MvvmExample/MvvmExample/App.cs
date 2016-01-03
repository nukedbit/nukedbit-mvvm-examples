using Autofac;
using MvvmExample.Views;
using Xamarin.Forms;

namespace MvvmExample
{
    public class App : Application
    {
        public App(Ioc ioc)
        {
            // The root page of your application
            var container = ioc.Build();
            
            var nav = new NavigationPage(container.ResolveNamed<ContentPage>("HomeView"));

            MainPage = nav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
