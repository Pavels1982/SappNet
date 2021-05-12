using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int[] Value { get; set; }
        public Kernel Kernel { get; set; }

        public Map(Kernel kernel)
        {
            this.Kernel = kernel;
        }

        public int[] GetValue() => this.Value;

        public void Process(int[] inputValue)
        {
            int InputSizeX = (int)Math.Sqrt(inputValue.Length);

            this.Value = new int[(InputSizeX - this.Kernel.Height + 1) * (InputSizeX - this.Kernel.Width + 1)];
            int offset, w;
            int sum = 0;
            var tmp = 0;
            int indexValue = 0;
            int index=0;

            for (int y = 0; y < inputValue.Length; y++, tmp++)
            {
                offset = y;   w = 0;

               if (tmp == InputSizeX) tmp = 0;

               if (tmp <= InputSizeX - this.Kernel.Width)
               {
                    
                  for (int i = 0; i < this.Kernel.weight.Length; i++)
                  {
                        index = offset + i;
                        sum += this.Kernel.weight[i] * inputValue[index];
                        w++;
                        if (w >= this.Kernel.Width) { w = 0; offset += InputSizeX - this.Kernel.Width; }
                        //Debug.Write($"{index},");
                  }
                  //Debug.WriteLine($"");
                  this.Value[indexValue++] = sum;
                  sum = 0;
                  if (index == inputValue.Length - 1) break;
               
               }
            }
   
        }


    }
}
