using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VisualCustomization
{
    public class CustomButtonWithEventhandler : Button
    {
        public CustomButtonWithEventhandler()
        {
            this.Click += CustomButtonWithEventhandler_Click;
        }

        void CustomButtonWithEventhandler_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("I'm the constructor attached eventhandler, and I'm still invoked"); ;
        }
    }
}
