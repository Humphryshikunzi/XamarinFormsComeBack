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
	public partial class MasterDetailPage1 : ContentPage
    {
        private List<Models> contacts = new List<Models>()
        {
            new Models() {Name = "Humphry", Status = "Student"},
            new Models()
            {
                Name = "Cleophas", Status = "Student",

            },
            new Models() {Name = "Celestine", Status = "Pupil"}
        };
		public MasterDetailPage1 ()
		{
			InitializeComponent ();
            MyListView.ItemsSource = contacts;
        }

        private async void  ContactDetail(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Models;
         await   Navigation.PushAsync(new ContactDetailPage(contact));
        }
    }
    
}