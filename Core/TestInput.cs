using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core
{
    public class TestInput
    {
        public int[] Value { get; set; }

        public TestInput(int height, int width,int value) 
        {
            this.Value = new int[height * width];
            for (int i = 0; i <= this.Value.Length - 1; i++)
            {
                this.Value[i] = value;
            }
        }
    }
}
