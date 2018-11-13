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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();

            string userName = "";
            string userGender = "";
            string userRH = "";

            var Repository = new Data.Repositories.UserInfoRepository();
            var userInfo = Repository.GetUserInfoAsync();

            if (userInfo.Count > 0)
            {
                userName = userInfo[0].Name;
                userGender = userInfo[0].Gender;
                userRH = userInfo[0].RH;
            }

            txtName.Text = userName;
            txtGender.Text = userGender;
            txtRH.Text = userRH;
        }

        private async Task btnUpdateUserInfo_ClickedAsync(object sender, EventArgs e)
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
                Repository.UpdateUserInfoAsync(userInfo);
            }

            

        }

    }
}