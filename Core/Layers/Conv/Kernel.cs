using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Kernel
    {
        public int[] weight;
        public int Height { get; set; }
        public int Width { get; set; }

        public Kernel(int height, int width)
        {
            this.Width = width;
            this.Height = height;
            this.weight = new int[this.Width * this.Height];
        }

        public Kernel(int[] weight)
        {

            this.weight = weight;
            var size = (int)Math.Sqrt(weight.Length);
            this.Width = size;
            this.Height = size;
        }

        public int[] GetWeight() => this.weight;


        public void RandomWeight(int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i <= weight.Length - 1; i++)
            {
                this.weight[i] = rnd.Next(min, max);
            }

        }


    }
}
