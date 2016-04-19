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

        private void WindowWithButton_Click(object sender, RoutedEventArgs e)
        {
            WindowWithButton window = new WindowWithButton();
            window.Show();
        }

        private void ControlBasedTemplating_Click(object sender, RoutedEventArgs e)
        {
            ControlBasedWindow window = new ControlBasedWindow();
            window.Show();
        }

        private void ControlParts_Click(object sender, RoutedEventArgs e)
        {
            ControlPartsWindow window = new ControlPartsWindow();
            window.Show();
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            EventsInTemplatesWindow window = new EventsInTemplatesWindow();
            window.Show();
        }

        private void DataTemplates_Click(object sender, RoutedEventArgs e)
        {
            DataTemplatesWindow window = new DataTemplatesWindow();
            window.Show();
        }

        private void HierarchicalDataTemplates_Click(object sender, RoutedEventArgs e) {
            HierarchicalDataTemplatesWindow window = new HierarchicalDataTemplatesWindow();
            window.Show();
        }

        private void ItemsControlBasedTemplating_Click(object sender, RoutedEventArgs e)
        {
            ItemsControlBasedWindow window = new ItemsControlBasedWindow();
            window.Show();
        }

        private void TabControlBasedTemplating_Click(object sender, RoutedEventArgs e)
        {
            TabControlBasedWindow window = new TabControlBasedWindow();
            window.Show();
        }

        private void SomeDefaultTemplates_Click(object sender, RoutedEventArgs e)
        {
            ItemsControlBasedWindow window = new ItemsControlBasedWindow();
            window.Show();
        }
    }
}
