using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KravnaGrupa.Model
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KravnaGrupa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewDonar : ContentPage
	{
		public NewDonar ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = expretienceEntry.Tex
            };
            sq
        }
    }
}