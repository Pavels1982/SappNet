using SappNET.Core;
using SappNET.Core.Layers.Conv;
using System;
using System.Collections.Generic;
using System.Linq;
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

            Conv conv5_44x44 = new Conv();

            conv5_44x44.AddMap(new Map(new Kernel(Kernel.X5())));

            var res= 8;

        }
    }
}
