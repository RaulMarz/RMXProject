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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async Task btnEmergency_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Emergency.EmergencyPage());
        }

        private async Task btnEmergencyMap_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Emergency.EmergencyMapPage());
        }

        private async Task btnStations_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Stations.StationsPage());
        }

        private async Task btnInfo_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Info.InfoPage());
        }
    }
}