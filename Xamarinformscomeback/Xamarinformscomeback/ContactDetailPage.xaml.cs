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
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage (Models contact)
		{     
            if(contact==null) throw new ArgumentException();
            BindingContext = contact;
			InitializeComponent ();

		}
	}
}