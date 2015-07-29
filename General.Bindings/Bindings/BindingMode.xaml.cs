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
    /// Interaction logic for BindingMode.xaml
    /// </summary>
    public partial class BindingMode : Window
    {
        BindingModeDataContext m_dataContext;

        public BindingMode()
        {
            InitializeComponent();

            m_dataContext = new BindingModeDataContext();
            m_dataContext.TwoWayBindingProperty = "TwoWay initial value";
            m_dataContext.OneWayBindingPropertySetter = "OneWay initial value";
            m_dataContext.OneWayBindingPropertyFullProp = "OneWay initial value";
            m_dataContext.OneWayToSourceBindingProperty = "OneWayToSource initial value";
            m_dataContext.OneTimeBindingProperty = "OneTime initial value";
            DataContext = m_dataContext;
        }

        private void TwoWaySetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.TwoWayBindingProperty = "TwoWay: Some Text";
        }

        private void TwoWayGetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(m_dataContext.TwoWayBindingProperty);
        }

        private void OneWayGetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(m_dataContext.OneWayBindingProperty);
        }

        private void OneWayFullPropSetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.OneWayBindingPropertyFullProp = "OneWay: Some Text";
        }

        private void OneWayFullPropGetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(m_dataContext.OneWayBindingPropertyFullProp);
        }

        private void OneWayToSourceSetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.OneWayToSourceBindingProperty = "OneWayToSource: Some Text";
        }

        private void OneWayToSourceGetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(m_dataContext.OneWayToSourceBindingPropertyGetter);
        }

        private void OneTimeSetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.OneTimeBindingProperty = "OneTime: Some Text";
        }

        private void OneTimeGetPropertyValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(m_dataContext.OneTimeBindingProperty);
        }
    }
}
