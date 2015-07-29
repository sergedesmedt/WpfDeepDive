using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Bindings
{
    class SimpleValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "unset":
                    // only this is considered an invalid value
                    return DependencyProperty.UnsetValue;
                case "null":
                    return null;
                case "exception":
                    throw new Exception();
                case "donothing":
                    return Binding.DoNothing;
                default:
                    return "CONVERTED: " + value.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (false)
            {
                return value;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
