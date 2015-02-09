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

namespace VisualCustomization
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnotherWindow anotherWindow = new AnotherWindow();
            anotherWindow.Show();
        }

        private void CustomButtonWithEventhandler_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I'm the window attached eventhandler, and I'm still invoked");
        }

        private void BrownButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Brown Button!");
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Red Button!");
        }

        private void ButtonInContainer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Button in the StackPanel!");
        }

        private void WowButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the Button inside theh component (or not?)!");
        }
    }
}
