using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public interface IParameters
    {
        ParameterInfo[] GetDescription();

        void Parse(double[] parameters);
    }
}
