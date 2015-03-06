using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ApBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public enum NestedEnum
        {
            One,
            Two
        }
    }

    public static class NestedEnumSource
    {
        public static IEnumerable<MainWindow.NestedEnum> Members
        {
            get
            {
                return Enum.GetValues(typeof(MainWindow.NestedEnum))
                           .Cast<MainWindow.NestedEnum>();
            }
        }
    }
}
