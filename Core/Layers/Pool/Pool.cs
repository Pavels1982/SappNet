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
            maps = new List<float[]>();
            foreach (var map in inputMaps)
            {
                float[] result = new float[map.InputSizeX / 2];
                int offset, w;
                float sum = 0;
                var tmp = 0;
                int indexValue = 0;
                int index = 0;

                for (int y = 0; y < map.Value.Length; y += 2, tmp += 2)
                {
                    offset = y; w = 0;

                    if (tmp == map.InputSizeX) { tmp = 0; y += map.InputSizeX; offset += map.InputSizeX; }

                    if (tmp <= map.InputSizeX - 2)
                    {

                        for (int i = 0; i <2; i++)
                        {
                            index = offset + i;
                            sum += map.Value[index];
                            w++;
                            if (w >= 2) { w = 0; offset += map.InputSizeX - 2; }
                            Debug.Write($"{index},");
                        }
                        Debug.WriteLine($"");
                        if (sum < 0) sum = 0;
                        result[indexValue++] = sum;
                        sum = 0;

                        if (index == map.Value.Length - 1) break;
                       
                    }
                }
                maps.Add(result);
            }
        }

            
     }
}
