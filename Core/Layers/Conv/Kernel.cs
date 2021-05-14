using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Kernel
    {
        public static float[] X5() 
        {
            Random rnd = new Random();

            float[] result = new float[25];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (float)rnd.Next(-500, 500) / 1000;
            }
            return result;
        }

        public float[,] weight;
        public int Height { get; set; }
        public int Width { get; set; }

        public Kernel(int height, int width, bool createWeight = false)
        {
            this.Width = width;
            this.Height = height;
            this.weight = new float[this.Width, this.Height];
            if (createWeight) RandomWeight(-0.5f, 0.5f);
        }

        public Kernel(float[,] weight)
        {

            this.weight = weight;
            var size = (int)Math.Sqrt(weight.Length);
            this.Width = size;
            this.Height = size;
        }

        public float[,] GetWeight() => this.weight;


        public void RandomWeight(float min, float max)
        {

            Random rnd = new Random();
            for (int ky = 0; ky < this.Height; ky++)
            {
                for (int kx = 0; kx < this.Width; kx++)
                {
                    this.weight[ky, kx] = (float)rnd.Next((int)(min * 1000), (int)(max * 1000)) / 1000;

                }
            }

        }


    }
}
