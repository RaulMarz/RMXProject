using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEMES.Views.Stations
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StationsPage : ContentPage
	{
		public StationsPage ()
		{
			InitializeComponent ();

            var Repository = new Data.Repositories.StationRepository();
            var stations = Repository.GetStationAsync().Result;
            lstStations.ItemsSource = stations;
        }
        private async Task btnDetail_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Stations.StationsDetailPage());
        }

        private async Task lstStations_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Data.Entities.Station)e.SelectedItem;
            await Navigation.PushAsync(new Views.Stations.StationsDetailPage(item.ID.ToString()));

        }
    }
}