using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Hidden
{
    public class Hidden: ILayer
    {
        public Perceptron[] Perceptrons { get; set; }

        public Hidden(int neuronCount, bool createWeight = false, int countWeight = 0)
        {
            this.Perceptrons = new Perceptron[neuronCount];
            if (createWeight) CreateWeight(countWeight);
        }


        public void CreateWeight(int count)
        {
            for(int i =0; i< this.Perceptrons.Length;i++)
            {
                this.Perceptrons[i] = new Perceptron();
                this.Perceptrons[i].CreateWeight(count);
            }
        }

        public void InputValues(float[,] input)
        {
            throw new NotImplementedException();
        }

        public float[,] GetValues()
        {
            throw new NotImplementedException();
        }
    }
}
