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
	public partial class EmergencyDetailPage : ContentPage
	{
		public EmergencyDetailPage (string ID = "0" )
		{
            InitializeComponent ();
            contentPageEmergencyDetail.Title = "Emergencia No. " + ID;

            if (ID != "0")
            {
                var Repository = new Data.Repositories.EmergencyRepository();
                var emergency = Repository.GetEntityByIDAsync(Int32.Parse(ID)).Result;

                lblDescription.Text = "Descripción: " + emergency.Description;
                lblType.Text = "Tipo: " + emergency.Type;
                lblDate.Text = "Fecha: " + emergency.Date;
                lblHour.Text = "Hora: " + emergency.Hour;
                imgType.Source = emergency.LogoSource;


            }

        }
    }
}