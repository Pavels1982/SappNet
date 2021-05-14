using SappNET.Core.Layers;
using SappNET.Core.Layers.Conv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Network
{
    public class Network
    {
        public List<ILayer> Layers = new List<ILayer>();

        public void AddLayer(ILayer layer)
        {
            this.Layers.Add(layer);
          
        }

        public void Process(float[,] data)
        {
            Layers[0].InputValues(data);

            var name = Layers[0].GetType().Name;
            for (int l = 1; l < Layers.Count; l++)
            {
               // name = Layers[l].GetType().Name;
            }
        
        }


    }
}
