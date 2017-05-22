using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FFImageLoading.Transformations;

namespace PixaImagenes
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BigImagePage : ContentPage
    {
        public BigImagePage()
        {
            InitializeComponent();
        }

        void BigImage_Clicked(object sender, System.EventArgs e)
        {
            Image.Source = "http://orig15.deviantart.net/a2f2/f/2016/223/2/8/cavalier_king_charles_spaniel___deviantart__3840x2_by_stevecampbell-dadgq6s.jpg";
        }

        void BadImage_Clicked(object sender, System.EventArgs e)
        {
            Image.Source = "http://twitter.com";
        }

        void NormalImage_Clicked(object sender, System.EventArgs e)
        {
            Image.Source = "https://i.redd.it/e0clw4wsouyy.jpg";
        }

        void Transform_Clicked(object sender, System.EventArgs e)
        {
            var grayscale = new GrayscaleTransformation();
            var blur = new BlurredTransformation(5);
            var corners = new CornersTransformation(4, CornerTransformType.AllCut);
            Image.Transformations.Add(grayscale);
            Image.Transformations.Add(blur);
            Image.Transformations.Add(corners);
            Image.ReloadImage();
        }
    }
}
