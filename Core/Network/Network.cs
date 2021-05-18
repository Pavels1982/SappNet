using SappNET.Core.Layers;
using SappNET.Core.Layers.Conv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Network
{
    [Serializable]
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
                if (Layers[l] != null) Layers[l].InputValues(Layers[l - 1].GetValues());
            }
        
        }


    }
}
