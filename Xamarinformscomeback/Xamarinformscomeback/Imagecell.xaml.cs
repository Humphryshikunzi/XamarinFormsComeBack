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
	public partial class Imagecell : ContentPage
	{
		public Imagecell ()
		{
			InitializeComponent ();
           Mylistview.ItemsSource = new List<Models>
            {
              
                    new Models
                    {
                        Name = "Cleophas", Status = "HighSchooler",
                        ImageUrl = "Xamarinformscomeback.Images.IMG_20180926_153910.jpg"
                    },
                
                    new Models
                    {
                        Name = "Humphry", Status = "Student", ImageUrl = "http://lorempixel.com/1920/1080/sports/7/"
                    },
                
               
               
            };
        }
	}
}