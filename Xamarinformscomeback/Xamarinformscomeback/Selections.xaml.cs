using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarinformscomeback
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Selections : ContentPage
    {
       

       ( IEnumerable<Models> contacts,string placehold) Getcontact(string searchtext=null)
        {
           
            ObservableCollection<Models> infor = new ObservableCollection<Models>()
            {
                new Models() {Name = "Humphry", Status = "Student"},
                new Models() {Name = "Isaac", Status = "Senior Student"},
                new Models() {Name = "Celestine", Status = "Pupil"}
            };
           
            if (string.IsNullOrEmpty(searchtext)) return (infor,searchtext);
            return ( infor.Where(m => m.Name.StartsWith(searchtext)),searchtext);
        }

      public Selections ()
		{
			InitializeComponent ();
            MyListView.ItemsSource = Getcontact().contacts;
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var response= e.SelectedItem as Models;
           DisplayAlert("Selected", response.Name, "Okay","Cancel");
        }

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var response = e.Item as Models;
            DisplayAlert("Tapped", response.Name, "Okay", "Cancel");
        }

        private void  Call(object sender, EventArgs e)
        {
            var selected = sender as MenuItem;
            var castasmodel = selected.CommandParameter as Models;
            DisplayAlert("Call ", castasmodel.Name, "Okay");
        }

      private void  RefreshList(object sender, EventArgs e)
        {
            MyListView.ItemsSource = Getcontact().contacts;
            MyListView.EndRefresh();
        }

      private void  Search(object sender, TextChangedEventArgs e)
      {
          Getcontact(e.NewTextValue);
      }
    private  void Delete(object sender, EventArgs e)
      {
          var itemtoremove = (sender as MenuItem).CommandParameter as Models;
          Getcontact().contacts.Where(c => c.Name.Equals(itemtoremove));

      }
    }
}