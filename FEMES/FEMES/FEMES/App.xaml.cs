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

            if (checkForUserInfoAsync())
            {
                MainPage = new MasterDetPage.MainPage();
            }
            else
            {
                MainPage = new Views.RegisterPage();
            }

        }

        public bool checkForUserInfoAsync() {
            var Repository = new Data.Repositories.UserInfoRepository();
            var userInfo = Repository.GetUserInfoAsync();
            return userInfo.Count > 0;
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
