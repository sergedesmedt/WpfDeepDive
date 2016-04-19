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
    /// Interaction logic for EventsInTemplatesWindow.xaml
    /// </summary>
    public partial class EventsInTemplatesWindow : Window {
        public EventsInTemplatesWindow() {
            InitializeComponent();
        }

        private void ButtonFromResourceSection_Click(object sender, RoutedEventArgs e) {
            if(sender is Button)
                MessageBox.Show("A button was clicked");
            else
                MessageBox.Show("A control was clicked with a type: " + sender.GetType());

            if (sender is DependencyObject) {
                Label parentLabel = FindAncestor<Label>(sender as DependencyObject);
                MessageBox.Show("A button was clicked from the Label with text: " + parentLabel.Content.ToString());
            }
                
        }

        private void ButtonInsideLocalTemplate_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("The local button was clicked");
        }

        public static T FindAncestor<T>(DependencyObject dependencyObject) where T : class {
            DependencyObject target = dependencyObject;
            do {
                target = VisualTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));
            return target as T;
        }
    }
}
