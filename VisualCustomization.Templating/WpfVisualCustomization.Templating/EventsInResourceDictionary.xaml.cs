using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfVisualCustomization.Templating {
    partial class EventsInResourceDictionary : ResourceDictionary {
        private void Button_Click(object sender, RoutedEventArgs e) {
            if (sender is Button)
                MessageBox.Show("A button from within a resource was clicked");
            else
                MessageBox.Show("A control from within a resource was clicked with a type: " + sender.GetType());

            if (sender is DependencyObject) {
                Label parentLabel = FindAncestor<Label>(sender as DependencyObject);
                MessageBox.Show("A button was clicked from the Label with text: " + parentLabel.Content.ToString());
            }

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
