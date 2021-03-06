using SappNET.Core;
using SappNET.Core.Layers.Conv;
using SappNET.Core.Layers.Hidden;
using SappNET.Core.Layers.Pool;
using SappNET.Core.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SappNET
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TestInput Input = new TestInput(48, 48, 1);

            Network net = new Network();

            net.AddLayer(new Conv(190, 5, 5, 48, 48, true));
            net.AddLayer(new Conv(260, 5, 5, 44, 44, true));

            net.Process(Input.Value);

            long size = 0;

            using (Stream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, (object)net);
                size = stream.Length;
            }


            Conv conv1_44x44 = new Conv();

            Hidden fully_160 = new Hidden(160, 16, true);
            Pool pool = new Pool();
            
            conv1_44x44.AddMap(new Map(new Kernel(5,5),48,48));

            conv1_44x44.InputValues(Input.Value);

            pool.InputMaps(conv1_44x44.Maps);

            var res= 8;

        }
    }
}
