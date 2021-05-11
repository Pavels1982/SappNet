﻿using SappNET.Core;
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
            TestInput Input = new TestInput(9, 9, 1);

            Map conv3_8x8 = new Map(new Kernel(new int[] {-1,0,1,-1,5,1,-1,0,1 }), 9, 9);

            var t = conv3_8x8.GetValue(Input.Value);
            var res = t;

        }
    }
}