using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SappNET.Core.Layers
{
    public interface ILayer
    {
        void InputValues(float[,] input);
        float[,] GetValues();

    }
}
