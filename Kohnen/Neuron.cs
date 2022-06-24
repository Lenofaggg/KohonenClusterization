using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kohnen.Functions;

namespace Kohnen
{
    public class Neuron
    {
        //public double bias;
        public double[] weights;
        public double[] input;

        private Func<double, double> _Activate;
        
        public double _output;

   

        //размер входных связей
        public Neuron( int size)
        {

            input = new double[size];
            weights = new double[size];


            RandomizeWeights(size);
        }

        private void RandomizeWeights(int size)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < size; i++)
            {
                Thread.Sleep(100);
               
                weights[i] = rnd.Next(-1000, 1000) / 1000d;
                if (weights[i] == 0)
                {
                    weights[i] = 1;
                }
            }
        }

        public void SetInput(double[] input)
        {
            this.input = input.ToArray();
        }

        public double CalcEuclidDist()
        {
            double sum=0;
            //перебор всех элементов входного вектора
            //и суммирование
            for (int i = 0; i < input.Length; i++)
            {
                sum += Math.Pow((input[i] - weights[i]),2);
            }

            return Math.Sqrt(sum);
        }
        
        public void CorrectWeights(  double learningRate)
        {            
            //изменения весов нейрона
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] += learningRate * (input[i] - weights[i]);
               
            }
        }
    }
}
