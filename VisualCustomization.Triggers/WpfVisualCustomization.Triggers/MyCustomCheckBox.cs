using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class MyCustomCheckBox : CheckBox
    {
        public MyCustomCheckBox()
        {
            this.DataContext = new NotifyPropertyChangedDataClass();
        }
    }
}
