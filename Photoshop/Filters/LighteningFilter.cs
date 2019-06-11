using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public class LighteningFilter : PixelFilter<LighteningParameters>
    {
        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        public override Pixel ProcessPixel(Pixel original, LighteningParameters parameters)
        {
            return original * parameters.Coefficient;
        }
    }
}

