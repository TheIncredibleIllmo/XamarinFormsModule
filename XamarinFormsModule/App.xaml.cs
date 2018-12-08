using System;
using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.Services;
using XamarinFormsModule.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsModule
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<INavigationService, NavigationService>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));


            MainPage = new NavigationPage(new MenuPage());

            //MainPage = new MainPage();
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
