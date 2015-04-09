using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class DependencyPropertyDataClass : DependencyObject
    {
        public static readonly DependencyProperty MyDependencyPropertyProperty =
            DependencyProperty.Register("MyDependencyProperty", typeof(bool), typeof(DependencyPropertyDataClass), new PropertyMetadata(false));

        public bool MyDependencyProperty
        {
            get { return (bool)GetValue(MyDependencyPropertyProperty); }
            set { SetValue(MyDependencyPropertyProperty, value); }
        }

    }
}
