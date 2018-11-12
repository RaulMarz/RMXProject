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
		}
        private async Task btnDetail_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.Stations.StationsDetailPage());
        }
    }
}