using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Bindings
{
    class IntelligentMultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string one = values[0] as string;
            string two = values[1] as string;
            string three = values[2] as string;
            string result = one;
            if (string.IsNullOrEmpty(result) && !string.IsNullOrEmpty(two))
            {
                result = two;
            }
            else if (!string.IsNullOrEmpty(result) && !string.IsNullOrEmpty(two))
            {
                result = result + ", "+ two;
            }
            if (string.IsNullOrEmpty(result) && !string.IsNullOrEmpty(three))
            {
                result = three;
            }
            else if (!string.IsNullOrEmpty(result) && !string.IsNullOrEmpty(three))
            {
                result = result + ", " + three;
            }
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
