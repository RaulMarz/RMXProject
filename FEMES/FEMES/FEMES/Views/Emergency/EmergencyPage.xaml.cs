using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEMES.Views.Emergency
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmergencyPage : ContentPage
	{
		public EmergencyPage ()
		{
			InitializeComponent ();

            var Repository = new Data.Repositories.EmergencyRepository();
            var emergencies = Repository.GetEmergencyAsync().Result;

            lstEmergency.ItemsSource = emergencies;
        }

        private async Task btnDetail_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.Emergency.EmergencyDetailPage());
        }

        private async Task lstEmergency_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Data.Entities.Emergency)e.SelectedItem;
            //await DisplayAlert("ItemSelected", item.Description, "Ok");

            await Navigation.PushModalAsync(new Views.Emergency.EmergencyDetailPage(item.ID.ToString()));

        }
    }
}