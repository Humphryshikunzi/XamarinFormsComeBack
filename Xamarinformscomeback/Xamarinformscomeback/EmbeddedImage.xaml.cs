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
	public partial class EmbeddedImage : ContentPage
	{
		public EmbeddedImage ()
		{
			InitializeComponent ();
        Myimage.Source = ImageSource.FromResource("Xamarinformscomeback.Images.IMG_20180926_153910.jpg");

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}