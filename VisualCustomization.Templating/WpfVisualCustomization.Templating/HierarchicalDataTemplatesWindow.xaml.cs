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

namespace WpfVisualCustomization.Templating {
    /// <summary>
    /// Interaction logic for HierarchicalDataTemplatesWindow.xaml
    /// </summary>
    public partial class HierarchicalDataTemplatesWindow : Window {
        public HierarchicalDataTemplatesWindow() {
            InitializeComponent();

            List<TopLevelData> datasource = new List<TopLevelData>(){(new TopLevelData() {
                Name = "Top 1", 
                Lvl1Children = new List<Lvl1Data>() { 
                    new Lvl1Data(){ Name = "Lvl1 1.1", Lvl2Children = new List<Lvl2Data>(){ 
                        new Lvl2Data(){ Name = "Lvl2 1.1.1" },
                        new Lvl2Data(){ Name = "Lvl2 1.1.2" }} 
                    },
                    new Lvl1Data(){ Name = "Lvl1 1.2", Lvl2Children = new List<Lvl2Data>(){ 
                        new Lvl2Data(){ Name = "Lvl2 1.2.1" },
                        new Lvl2Data(){ Name = "Lvl2 1.2.2" }} 
                    } 
                }
            })};
            datasource.Add(new TopLevelData() { Name = "Top 2" });
            datasource.Add(new TopLevelData() { Name = "Top 3" });

            StandardTreeView.ItemsSource = datasource;
            ItemTemplatedAttemptOneTreeView.ItemsSource = datasource;
            ItemTemplatedAttemptTwoTreeView.ItemsSource = datasource;
            ItemTemplatedAttemptThreeTreeView.ItemsSource = datasource;
            ItemTemplatedAttemptThreeFailTreeView.ItemsSource = datasource;
            ItemTemplatedAttemptFour1TreeView.ItemsSource = datasource;
            ItemTemplatedAttemptFour2TreeView.ItemsSource = datasource;
            ItemTemplatedAttemptFourAlternativeTreeView.ItemsSource = datasource;
        }
    }
}
