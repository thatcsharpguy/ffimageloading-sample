using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PixaImagenes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {

            PixaClient client = new PixaClient("5392706-f5e479ff283c464487f394f41");
            var list = await client.GetPhotos();
            ImageLink.ItemsSource = list.Hits;
            base.OnAppearing();
        }
    }
}
