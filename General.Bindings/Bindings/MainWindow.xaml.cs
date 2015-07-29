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

namespace Bindings
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

        private void ButtonMuteProperties_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new BindingToMuteProperties();
            dialog.ShowDialog();
        }

        private void ButtonNotifyingProperties_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new BindingToNotifyingProperties();
            dialog.ShowDialog();
        }

        private void SpecifyingTheSource_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SpecifyingTheSource();
            dialog.ShowDialog();
        }

        private void SpecifyingThePath_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SpecifyingThePath();
            dialog.ShowDialog();
        }

        private void BindingMode_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new BindingMode();
            dialog.ShowDialog();
        }

        private void MultiBinding_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MultiBinding();
            dialog.ShowDialog();
        }

        private void PriorityBinding_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new PriorityBinding();
            dialog.ShowDialog();
        }

        private void UpdateSourceTrigger_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new UpdateSourceTrigger();
            dialog.ShowDialog();
        }
    }
}
