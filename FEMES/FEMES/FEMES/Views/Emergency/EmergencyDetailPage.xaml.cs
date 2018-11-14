﻿using System;
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

            lblDetail.Text = "Detalle para emergencia: " + ID;

        }
    }
}