using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEMES.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private async Task btnSaveUserInfo_ClickedAsync(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userGender = txtGender.Text;
            string userRH = txtRH.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userGender) && !string.IsNullOrEmpty(userRH))
            {
                var userInfo = new Data.Entities.UserInfo
                {
                    ID = 1,
                    Name = userName,
                    Gender = userGender,
                    RH = userRH,
                };
                var Repository = new Data.Repositories.UserInfoRepository();
                Repository.CreateUserInfoAsync(userInfo);
            }

            await Navigation.PushModalAsync(new MasterDetPage.MainPage());

        }
    }
}