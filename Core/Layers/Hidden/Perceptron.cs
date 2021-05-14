using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Hidden
{
    public class Perceptron
    {
        public float[] weight { get; set; }
        public float Output { get; set; }

        public Perceptron()
        { 
        }
        public void CreateWeight(int count)
        {
            weight = new float[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            { 
            weight[i] = (float)rnd.Next((int)(-0.5 * 1000), (int)(0.5 * 1000)) / 1000;
            }
        }


        public void InputData(float[,] inputData)
        {
            int ind = 0;
            for (int y = 0; y < inputData.Length; y++)
            {
                for (int x = 0; x < inputData.Length; x++)
                {
                    weight[ind++] *= inputData[y, x];
                }
            }

            Output = weight.Sum() > 0 ? Output: 0;

        }

    }
}
