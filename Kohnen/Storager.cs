using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kohnen
{
    internal class Storager
    {
        //считывание входных параметров
        public double[] Read(StreamReader sr)
        {
            //string hui = sr.ReadLine();
            var s = sr.ReadLine().Split(' ').Select(double.Parse).ToArray();

            
            //нормализованный массив
            double sum = s.Select(o => Math.Pow(o, 2)).Sum();
            return s.Select(x => (x / Math.Sqrt(sum))).ToArray();
            return s;

        }
        

    }
}
