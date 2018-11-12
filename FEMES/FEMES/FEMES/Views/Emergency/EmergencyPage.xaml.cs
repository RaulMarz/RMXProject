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
		}

        private async Task btnDetail_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.Emergency.EmergencyDetailPage());
        }
    }
}