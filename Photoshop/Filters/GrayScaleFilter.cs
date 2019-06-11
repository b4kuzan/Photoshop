using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public class GrayScaleFilter : PixelFilter<EmptyParameters>
    {
        public override Pixel ProcessPixel(Pixel original, EmptyParameters parameters)
        {
            return GetGrayScale(original);
        }

        private static Pixel GetGrayScale(Pixel pixel)
        {
            var color = pixel.Red * 0.299 + pixel.Green * 0.587 + pixel.Blue * 0.114;
            return new Pixel(color, color, color);
        }

        public override string ToString()
        {
            return "Черно-белый";
        }
    }
}
