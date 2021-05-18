using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    [Serializable]
    public class Conv: ILayer
    {
        public List<Map> Maps { get; private set; } = new List<Map>();

        public Conv()
        {

        }

        public Conv(int countMap, int kernelHeight, int kernelWidth, int mapHeight, int mapWidth, bool createKernelWeight = false)
        {
            for (int i = 0; i < countMap; i++)
            {
                Maps.Add(new Map(new Kernel(kernelHeight, kernelWidth, createKernelWeight), mapHeight, mapWidth));
            }
        }


        public void AddMap(Map map)
        {
            this.Maps.Add(map);
        }

        public void InputValues(float[,] input)
        {
            foreach (var map in Maps)
            {
                map.InputValues(input);
            }
        
        }

        public List<Map> GetMaps() => this.Maps;

        public float[,] GetValues()
        {
            throw new NotImplementedException();
        }
    }
}
