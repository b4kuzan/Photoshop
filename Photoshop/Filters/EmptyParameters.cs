using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public class EmptyParameters : IParameters
    {
        public double Coefficient { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new ParameterInfo[0];
        }

        public void Parse(double[] parameters)
        {
        }
    }
}
