using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kohnen.Functions;

namespace Kohnen
{
    public class KohenNet
    {
        
        public Neuron[] Neurons;

        private double error;

        public double learningRate;
        public int size;
        public int inputCount;

        //private double learningRate;

        //число нейронов на слое, скорость обучения
        public KohenNet( double lr, int inpCnt,int neuCnt)
        {
            inputCount = inpCnt;
            learningRate = lr;
            

            Neurons = new Neuron[neuCnt];
            //инициализация нейронов
            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron(inputCount);
            }
        }

        //установка входных значений к нейрону
        public void SetFirstInput(double[] inp)
        {
            foreach (var neuron in Neurons)
            {
                neuron.SetInput(inp);
            }
        }

        #region Обучение сети

        public int FindWinner()
        {
            double res = double.MaxValue;
            int indWin = 0;
            
            //перебор нейронов i 
            for (int i = 0; i < Neurons.Length; i++)
            {
                double g = Neurons[i].CalcEuclidDist();
                //поиск победителя с наименьшей хуйнёй
                if (g < res)
                {
                    res = g;
                    indWin = i;
                }
            }
           
            return indWin;
        }

        public void Learn()
        {
            Neurons[FindWinner()].CorrectWeights(learningRate);
        }

        #endregion

        #region Работа сети

        public void Compute()
        {
            FindWinner();
        }

        #endregion

    }
}
