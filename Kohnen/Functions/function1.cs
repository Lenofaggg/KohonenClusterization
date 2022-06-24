using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kohnen.Functions
{
    internal class function1 : IExcFunction
    {
        public double Derivative(double o)
        {
            throw new NotImplementedException();
        }

        public double Execute(double input)
        {
            return 5 * input;
            //return Math.Sqrt(input);
            //return Math.Pow(input,2);
            //return input;
        }
    }
}
