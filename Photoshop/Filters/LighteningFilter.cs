using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public class LighteningFilter : PixelFilter
    {
        public LighteningFilter() : base(new LighteningParameters()) { }

        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            return original * (parameters as LighteningParameters).Coefficient;
        }
    }
}

