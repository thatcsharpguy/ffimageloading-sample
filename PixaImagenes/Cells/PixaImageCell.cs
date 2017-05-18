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
            Height = 80;
            _tagsLabel = new Label()
            {
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.Center,
                Margin = 0
            };
            _image = new Image()
            {
                Aspect = Aspect.AspectFill
            };

            _grid = new Grid()
            {
                HeightRequest = Height,
                RowSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition { Height = Height - 15 },
                    new RowDefinition { Height = 15 }
                }
            };

            _grid.Children.Add(_image);
            Grid.SetRow(_tagsLabel, 1);
            _grid.Children.Add(_tagsLabel);

            View = _grid;
        }

        protected override void OnBindingContextChanged()
        {
            var image = BindingContext as PixaImage;
            if (image != null)
            {
                _image.Source = image.WebformatUrl;
                _tagsLabel.Text = image.Tags;
            }
        }
    }
}
