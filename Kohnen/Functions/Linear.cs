using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohnen.Functions
{
    public class Linear : IExcFunction
    {
        public double Derivative(double y)
        {
            return 1;
        }

        public double Execute(double input)
        {
            return input;
        }
    }
}
