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
    /// Interaction logic for ItemsControlBasedWindow.xaml
    /// </summary>
    public partial class ItemsControlBasedWindow : Window
    {
        public ItemsControlBasedWindow()
        {
            InitializeComponent();

            List<CustomData> dataSource = new List<CustomData>();
            dataSource.Add(new CustomData() { XCoord = 10, YCoord = 10, DataMember1 = 1, DataMember2 = "String1"});
            dataSource.Add(new CustomData() { XCoord = 100, YCoord = 20, DataMember1 = 2, DataMember2 = "String2" });

            StandardItemsControl.ItemsSource = dataSource;
            StandardListView.ItemsSource = dataSource;
            ItemTemplatedListView.ItemsSource = dataSource;
            TemplatedItemsControl1.ItemsSource = dataSource;
            TemplatedItemsControl2.ItemsSource = dataSource;
        }
    }
}
