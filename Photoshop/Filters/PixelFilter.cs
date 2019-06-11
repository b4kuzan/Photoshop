using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public abstract class PixelFilter<T> : ParametrizedFilter<T> where T : IParameters, new()
    {
        public abstract Pixel ProcessPixel(Pixel original, T parameters);

        public override Photo Process(Photo original, T parameters)
        {
            var result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
            {
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], parameters);
                }
            }

            return result;
        }
    }
}
