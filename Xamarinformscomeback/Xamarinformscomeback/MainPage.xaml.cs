using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarinformscomeback
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var imagesource=new UriImageSource{Uri=new Uri("http://lorempixel.com/1920/1080/sports/7/")};
            imagesource.CacheValidity=TimeSpan.FromDays(1);
            imagesource.CachingEnabled = false;
            Myimage.Source = imagesource;

        }

       
    }
}
