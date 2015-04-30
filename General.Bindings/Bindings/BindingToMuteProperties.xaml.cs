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
    /// Interaction logic for BindingToMuteProperties.xaml
    /// </summary>
    public partial class BindingToMuteProperties : Window
    {
        public BindingToMuteProperties()
        {
            InitializeComponent();

            var dataContext = new SomeMuteDataClass();
            dataContext.MuteProperty = "Mute Property value from start";

            this.DataContext = dataContext;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = (this.DataContext as SomeMuteDataClass).MuteProperty = "Mute Property new value";
        }
    }
}
