using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class MyCustomButtonWithDataContext : Button
    {
        public MyCustomButtonWithDataContext()
        {
            this.DataContext = new MyCustomButton();
        }

        public static readonly DependencyProperty TypedDataContextProperty =
            DependencyProperty.Register("MyDependencyProperty", typeof(MyCustomButton), typeof(MyCustomButtonWithDataContext), new PropertyMetadata(null));

        public MyCustomButton TypedDataContext
        {
            get { return (MyCustomButton)GetValue(TypedDataContextProperty); }
            set { SetValue(TypedDataContextProperty, value); }
        }
    }
}
