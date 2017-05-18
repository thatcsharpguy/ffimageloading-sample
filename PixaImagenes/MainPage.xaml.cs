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
        public MainPage(DataTemplate template)
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);

            ImageList.ItemTemplate = template;
        }

        private async void ImageSerachBarSearchButtonPressed(object sender, EventArgs e)
        {
            var list = await App.PixaClient.GetPhotos(ImageSearchBar.Text);
            ImageList.ItemsSource = list.Hits;
        }
    }
}
