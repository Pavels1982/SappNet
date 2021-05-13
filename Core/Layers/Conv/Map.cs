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
        public int Height { get; private set; }
        public int Width { get; private set; }
        public float[,] Value { get; set; }
        public Kernel Kernel { get; set; }
        public int InputSizeX { get; set; }


        public Map(Kernel kernel, int inputHeight, int inputWidth)
        {
            this.Kernel = kernel;
            InputSizeX = inputWidth;
            this.Height = (inputHeight - this.Kernel.Height + 1);
            this.Width = (inputWidth - this.Kernel.Width + 1);
            this.Value = new float[this.Height, this.Width];
        }

        public float[,] GetValue() => this.Value;

        public void InputValues(float[,] inputValue)
        {
            
            for (int iy = 0; iy < inputValue.GetLength(0) - this.Kernel.Height + 1; iy++)
            {
                for (int ix = 0; ix < inputValue.GetLength(1) - this.Kernel.Width + 1; ix++)
                {

                    float sum = 0;
                    for (int ky = 0; ky < this.Kernel.Height; ky++)
                    {
                        for (int kx = 0; kx < this.Kernel.Width; kx++)
                        {
                            int indexX = ix + kx;
                            int indexY = iy + ky;
                            sum += inputValue[indexX, indexY] * this.Kernel.weight[kx, ky];
                          //  Debug.Write($"{indexY},{indexX}|");
                        }
                    }
                    //Debug.WriteLine($"");
                    this.Value[iy, ix] = sum;
                }
            }
          
        }


        //public void InputValues(float[] inputValue)
        //{
        //    int offset, w;
        //    float sum = 0;
        //    var tmp = 0;
        //    int indexValue = 0;
        //    int index = 0;

        //    for (int y = 0; y < inputValue.Length; y++, tmp++)
        //    {
        //        offset = y; w = 0;

        //        if (tmp == InputSizeX) tmp = 0;

        //        if (tmp <= InputSizeX - this.Kernel.Width)
        //        {

        //            for (int i = 0; i < this.Kernel.weight.Length; i++)
        //            {
        //                index = offset + i;
        //                sum += this.Kernel.weight[i] * inputValue[index];
        //                w++;
        //                if (w >= this.Kernel.Width) { w = 0; offset += InputSizeX - this.Kernel.Width; }
        //                Debug.Write($"{index},");
        //            }
        //            Debug.WriteLine($"");
        //            if (sum < 0) sum = 0;
        //            this.Value[indexValue++] = sum;
        //            sum = 0;
        //            if (index == inputValue.Length - 1) break;

        //        }
        //    }

        //}



    }
}
