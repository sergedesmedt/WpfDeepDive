using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Bindings
{
    class MyMultiBindingConverter : IMultiValueConverter
    {
        static string[] stringSeparators = new string[] { "_" };

        bool m_allowConvertBack = true;

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("MyMultiBindingConverter.Convert");
            string one = values[0] as string;
            string two = values[1] as string;
            string three = values[2] as string;
            if (!string.IsNullOrEmpty(one) && !string.IsNullOrEmpty(two) && !string.IsNullOrEmpty(three))
            {
                return one + "_" + two + "_" + three;
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("MyMultiBindingConverter.ConvertBack");
            if (m_allowConvertBack)
            {
                string valueToConvert = value as string;
                object[] result = valueToConvert.Split(stringSeparators, StringSplitOptions.None);
                return result;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
