using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using PixaImagenes.Entities;
using Xamarin.Forms;

namespace PixaImagenes.Cells
{
    public class PixaImageCell : ViewCell
    {
        private readonly Label _tagsLabel;
        private readonly Image _image;
        private readonly Grid _grid;

        public PixaImageCell()
        {
            Height = 200;
            _tagsLabel = new Label();
            _image = new Image();

            _grid = new Grid()
            {
                HeightRequest = 200
            };

            _grid.Children.Add(_image);
            _grid.Children.Add(_tagsLabel);

            View = _grid;
        }

        protected override void OnBindingContextChanged()
        {
            var image = BindingContext as PixaImage;
            if (image != null)
            {
                _image.Source = image.PreviewUrl;
                _tagsLabel.Text = image.Tags + " " + image.PreviewWidth + " " + image.PreviewHeight;
                _grid.HeightRequest = image.PreviewHeight;
                Height = image.PreviewHeight;
                ForceUpdateSize();
            }
        }
    }
}
