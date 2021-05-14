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

        public Hidden(int neuronCount, int countWeight = 0, bool createWeight = false )
        {
            this.Perceptrons = new Perceptron[neuronCount];
          
            if (createWeight)
                for (int i = 0; i < this.Perceptrons.Length; i++)
                {
                    this.Perceptrons[i] = new Perceptron(countWeight, true);
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
