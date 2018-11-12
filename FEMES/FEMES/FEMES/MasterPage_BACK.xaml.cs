using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEMES
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return ListView; } }

		public MasterPage ()
		{
			InitializeComponent ();

            var masterPageItem = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Home",
                    IconSource = "icon.png",
                    TargetType = typeof(Views.HomePage)
                },

                new MasterPageItem
                {
                    Title = "Perfil",
                    IconSource = "icon.png",
                    TargetType = typeof(Views.ProfilePage)
                }
            };

            listView.ItemsSource = masterPageItem;
        }
	}
}