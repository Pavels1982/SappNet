using SappNET.Core.Layers.Conv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Pool
{
    public class Pool
    {
        private List<float[]> maps;


        public Pool() 
        {
          //  this.maps = maps;
        
        }

        public void InputMaps(List<Map> inputMaps)
        {
            foreach (var map in inputMaps)
            {
                float[,] result = new float[map.Height /2, map.Width/2];
                int indX = 0, indY = 0;
                for (int iy = 0; iy < map.Value.GetLength(0) - 3; iy+=2, indY++)
                {
                    
                    for (int ix = 0; ix < map.Value.GetLength(1) - 3; ix+=2, indX++)
                    {
                        float max = 0;
                        for (int ky = 0; ky < 2; ky++)
                        {
                            for (int kx = 0; kx < 2; kx++)
                            {
                                int indexX = ix + kx;
                                int indexY = iy + ky;
                                var val = map.Value[indexY, indexX];
                                if (val > max) max = val;
                                 Debug.Write($"{indY},{indX}|");
                            }
                          //  
                        }
                        Debug.WriteLine($"");
                        result[indY, indX] = max;

                    }
                   
                }
            }
        }

            
     }
}
