using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers.Conv
{
    public class Conv
    {
        public List<Map> Maps { get; private set; }

        public Conv()
        {
            this.Maps = new List<Map>();
        }
        public void AddMap(Map map)
        {
            this.Maps.Add(map);
        }

        public void InputValues(float[] input)
        {
            foreach (var map in Maps)
            {
                map.InputValues(input);
            }
        
        }

        public List<Map> GetMaps() => this.Maps;

    }
}
