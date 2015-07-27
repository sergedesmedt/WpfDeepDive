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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ControlBasedTemplating_Click(object sender, RoutedEventArgs e)
        {
            ControlBasedWindow window = new ControlBasedWindow();
            window.Show();
        }

        private void ItemsControlBasedTemplating_Click(object sender, RoutedEventArgs e)
        {
            ItemsControlBasedWindow window = new ItemsControlBasedWindow();
            window.Show();
        }
    }
}
