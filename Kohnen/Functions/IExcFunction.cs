using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohnen.Functions
{
    public interface IExcFunction
    {
        double Execute(double input);
        double Derivative(double o);
    }
}
