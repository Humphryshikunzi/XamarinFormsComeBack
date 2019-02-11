using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarinformscomeback
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToolBar : ContentPage
	{
		public ToolBar ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_OnActivated(object sender, EventArgs e)
        {
            // Icon is missing ,will update it when I get it
        }
    }
}