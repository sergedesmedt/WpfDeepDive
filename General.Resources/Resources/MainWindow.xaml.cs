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

namespace Resources
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

        private void DynDemoButtonChangeInstanceStat_Click(object sender, RoutedEventArgs e)
        {
            DynamicDemos.Resources["BoundAsStaticResource"] = new MyCustomClass() { StringProperty = "BoundAsStaticResourceV2", IntegerPoperty = 1 };
        }

        private void DynDemoButtonChangeInstanceDyn_Click(object sender, RoutedEventArgs e)
        {
            DynamicDemos.Resources["BoundAsDynamicResource"] = new MyCustomClass() { StringProperty = "BoundAsDynamicResourceV2", IntegerPoperty = 1 };
        }

        private void DynDemoButtonChangeProperty_Click(object sender, RoutedEventArgs e)
        {
            var currentInstance = DynamicDemos.Resources["BoundAsDynamicResource"] as MyCustomClass;
            currentInstance.StringProperty = "BoundAsDynamicResourceChangePropertyV3";
        }
    }
}
