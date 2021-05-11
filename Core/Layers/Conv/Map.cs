using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Map
    {
        private int InputWidth { get; set; }
        private int InputHeight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int[] Value { get; set; }
        public Kernel Kernel { get; set; }

        public Map(Kernel kernel, int inputWidth, int inputHeight)
        {
            this.InputWidth = inputWidth;
            this.InputHeight = inputHeight;
            this.Kernel = kernel;
            this.Height = inputHeight - kernel.Height + 1;
            this.Width = inputWidth - kernel.Width + 1;
            this.Value = new int[this.Width  * this.Height];
        }

        public int[] GetValue(int[] inputValue)
        {

            int count = 0;
            int sum = 0;
            int index  = 0;
            for (int i = 0; i <= this.Value.Length - this.Kernel.weight.Length - 1; i+= this.Kernel.Width)
            {
                index++;

                for (int x = i; x <= i + this.Kernel.Width -1; x++)
                {
                    sum += inputValue[i] * this.Kernel.weight[count];
                    count++;
                }

                if (index == this.Kernel.Height)
                {
                    this.Value[i] = sum;
                    index = 0;
                    sum = 0;
                    count = 0;
                }

            }

            return this.Value;
        }


    }
}
