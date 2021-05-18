using SappNET.Core.Layers.Conv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Pool
{
    [Serializable]
    public class Pool
    {
        public List<float[,]> Maps { get; private set; } = new List<float[,]>();


        public Pool() 
        {
          //  this.maps = maps;
        
        }

        public void InputMaps(List<Map> inputMaps)
        {
            foreach (var map in inputMaps)
            {
                float[,] result = new float[map.Height / 2 , map.Width / 2];
                int indX = 0, indY = 0;
                int l_0 = map.Value.GetLength(0);
                int l_1 = map.Value.GetLength(1);
                for (int iy = 0; iy < l_0; iy+=2, indY++)
                {
                    indX = 0;
                    for (int ix = 0; ix < l_1; ix+=2, indX++)
                    {
                        float max = 0;
                        if (ix + 1 >= l_1 || iy + 1 >= l_0) { break; }
                        for (int ky = 0; ky < 2; ky++)
                        {
                            for (int kx = 0; kx < 2; kx++)
                            {
                                int indexX = ix + kx;
                                int indexY = iy + ky;
                                var val = map.Value[indexY, indexX];
                                if (val > max) max = val;
                               // Debug.Write($"{indexY},{indexX},");
                            }
                        }
                        //Debug.WriteLine($"max={max}");
                        result[indY, indX] = max;
                        
                    }
                   

                }
                this.Maps.Add(result);
            }
        }

            
     }
}
