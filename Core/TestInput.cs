using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core
{
    public class TestInput
    {
        public float[,] Value { get; set; }
        private int height { get; set; }

        public TestInput(int height, int width,int value) 
        {
            Random rnd = new Random();
            this.Value = new float[height, width];

 
            for (int ky = 0; ky < Value.GetLength(0); ky++)
            {
                for (int kx = 0; kx < Value.GetLength(1); kx++)
                {
                    this.Value[ky, kx] = (float)rnd.NextDouble();

                }
            }

        }
    }
}
