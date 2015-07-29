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
    /// Interaction logic for PriorityBinding.xaml
    /// </summary>
    public partial class PriorityBinding : Window
    {
        SomeNotifyPropertyChangedImplementingClass m_dataContext = new SomeNotifyPropertyChangedImplementingClass();
        public PriorityBinding()
        {
            m_dataContext.ObjectProperty = Brushes.Blue;

            this.DataContext = m_dataContext;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PriorityBindingAsync async = new PriorityBindingAsync();
            async.ShowDialog();
        }

        private void ChangeObjectPropertyToBrush_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.ObjectProperty = Brushes.Blue;
        }

        private void ChangeObjectPropertyToAlignment_Click(object sender, RoutedEventArgs e)
        {
            m_dataContext.ObjectProperty = HorizontalAlignment.Right;
        }
    }
}
