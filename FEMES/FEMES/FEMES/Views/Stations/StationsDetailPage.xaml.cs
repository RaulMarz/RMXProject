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
	public partial class StationsDetailPage : ContentPage
	{
		public StationsDetailPage (string ID = "0")
        {
			InitializeComponent ();

            contentPageStationDetail.Title = "Estación No. " + ID;
        }
	}
}