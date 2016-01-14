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
using System.Windows.Shapes;

namespace WpfVisualCustomization.Templating
{
    /// <summary>
    /// Interaction logic for ControlPartsWindow.xaml
    /// </summary>
    public partial class ControlPartsWindow : Window
    {
        public class TheSource
        {
            public List<string> ComboxSource
            {
                get;
                set;
            }
        }

        public ControlPartsWindow()
        {
            InitializeComponent();

            var dataSource = new TheSource();
            dataSource.ComboxSource = new List<string>();
            dataSource.ComboxSource.Add("Entry 1");
            dataSource.ComboxSource.Add("Entry 2");
            dataSource.ComboxSource.Add("Entry 3");

            this.DataContext = dataSource;
        }


    }
}
