using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using FFImageLoading.Forms;
using PixaImagenes.Entities;
using Xamarin.Forms;

namespace PixaImagenes.Cells
{
    public class PixaGoodCell : ViewCell
    {
        private readonly CachedImage[] ImageControls;
        private readonly Grid _grid;

        public PixaGoodCell()
        {
            Height = 100;
            ImageControls = new CachedImage[5];

            _grid = new Grid()
            {
                HeightRequest = Height,
                ColumnSpacing = 0,
                ColumnDefinitions =
                {
                    new ColumnDefinition (),
                    new ColumnDefinition (),
                    new ColumnDefinition (),
                    new ColumnDefinition (),
                    new ColumnDefinition ()
                }
            };

            for (int i = 0; i < ImageControls.Length; i++)
            {
                ImageControls[i] = new CachedImage
                {
                    Aspect = Aspect.AspectFill,
                    LoadingPlaceholder = "wait.png"
                };
                Grid.SetColumn(ImageControls[i], i);
                _grid.Children.Add(ImageControls[i]);
            }


            View = _grid;
        }

        protected override void OnBindingContextChanged()
        {
            var image = BindingContext as PixaImage;
            if (image != null)
            {

                for (int i = 0; i < ImageControls.Length; i++)
                {
					ImageControls[i].Source = image.WebformatUrl;;
                }
            }
        }
    }
}
