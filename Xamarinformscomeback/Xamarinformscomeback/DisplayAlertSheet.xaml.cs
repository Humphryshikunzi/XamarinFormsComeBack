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
	public partial class DisplayAlertSheet : ContentPage
	{
		public DisplayAlertSheet ()
		{ 
			InitializeComponent ();
		}

        private void Sheet(object sender, EventArgs e)
        {
            DisplayActionSheet("Select", "Cancel", "Delete", "Make Phone Call",
                "Copy link", "SendEmail", "SendMessage", "Save link");
        }

        private void  Alert3(object sender, EventArgs e)
        {
            DisplayAlert("Select", "Contact", "cancel");
        }

        private void  Alert4(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Contact", "Okay", "Cancel");
        }
    }
}