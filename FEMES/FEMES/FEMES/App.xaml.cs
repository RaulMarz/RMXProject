using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FEMES
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            // TODO Check for user info on the database
            bool userRegistered = true;

            if (userRegistered){
                MainPage = new MasterDetPage.MainPage();
            }
            else {
                MainPage = new Views.RegisterPage();
            }
            
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
