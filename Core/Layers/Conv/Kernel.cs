using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Kernel
    {
        public static float[] X2() => new float[] { 1, 1, 1, 1 };
        public static float[] X3() => new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    //    public static float[] X5() => new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

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

        public float[] weight;
        public int Height { get; set; }
        public int Width { get; set; }

        public Kernel(int height, int width)
        {
            this.Width = width;
            this.Height = height;
            this.weight = new float[this.Width * this.Height];
        }

        public Kernel(float[] weight)
        {

            this.weight = weight;
            var size = (int)Math.Sqrt(weight.Length);
            this.Width = size;
            this.Height = size;
        }

        public float[] GetWeight() => this.weight;


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
