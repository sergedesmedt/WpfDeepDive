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

namespace Bindings
{
    /// <summary>
    /// Interaction logic for BindingToNotifyingProperties.xaml
    /// </summary>
    public partial class BindingToNotifyingProperties : Window
    {
        public BindingToNotifyingProperties()
        {
            InitializeComponent();

            var dataContext = new SomeNotifyPropertyChangedImplementingClass();
            dataContext.NotifyingProperty = "Notifying Property value from start";

            this.DataContext = dataContext;

            chkPropertyNotPresent.DataContext = new SomeNotifyPropertyChangedImplementingClass();
            chkPropertyIsPresent.DataContext = new IsCheckedDataContext();

        }

        private void ButtonSet_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = (this.DataContext as SomeNotifyPropertyChangedImplementingClass).NotifyingProperty = "Notifying Property new value";
        }

        private void ButtonGet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((this.DataContext as SomeNotifyPropertyChangedImplementingClass).NotifyingProperty);
        }

        private void ToggleCheckBoxIsChecked_Click(object sender, RoutedEventArgs e)
        {
            chkPropertyNotPresent.IsChecked = !chkPropertyNotPresent.IsChecked;
        }

        private void ToggleDataContextIsChecked_Click(object sender, RoutedEventArgs e)
        {
            (chkPropertyIsPresent.DataContext as IsCheckedDataContext).IsChecked = !(chkPropertyIsPresent.DataContext as IsCheckedDataContext).IsChecked;
        }
    }
}
