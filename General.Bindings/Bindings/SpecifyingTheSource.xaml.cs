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
    /// Interaction logic for SpecifyingTheSource.xaml
    /// </summary>
    public partial class SpecifyingTheSource : Window
    {
        public SpecifyingTheSource()
        {
            InitializeComponent();

            var dataContext = new SomeNotifyPropertyChangedImplementingClass();
            dataContext.NotifyingProperty = "Notifying Property value from start";

            this.DataContext = dataContext;
        }
    }
}
