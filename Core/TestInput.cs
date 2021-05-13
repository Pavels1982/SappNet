using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core
{
    public class TestInput
    {
        public float[] Value { get; set; }

        public TestInput(int height, int width,int value) 
        {
            Random rnd = new Random();
            this.Value = new float[height * width];
            for (int i = 0; i <= this.Value.Length - 1; i++)
            {
                this.Value[i] = (float)rnd.NextDouble();
            }
        }
    }
}
