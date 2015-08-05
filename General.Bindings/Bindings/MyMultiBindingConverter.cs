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

        public string InstanceId { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("MyMultiBindingConverter.Convert[" + (string.IsNullOrEmpty(InstanceId) ? "Global" : InstanceId) + "]");
            string one = values[0] as string;
            string two = values[1] as string;
            string three = values[2] as string;
            Debug.WriteLine("MyMultiBindingConverter.Convert[" + (string.IsNullOrEmpty(InstanceId) ? "Global" : InstanceId) + "]"
                + "[1:" + (string.IsNullOrEmpty(one) ? "NULL" : one) + "]"
                + "[2:" + (string.IsNullOrEmpty(two) ? "NULL" : two) + "]"
                + "[3:" + (string.IsNullOrEmpty(three) ? "NULL" : three) + "]"
            );
            if (!string.IsNullOrEmpty(one) && !string.IsNullOrEmpty(two) && !string.IsNullOrEmpty(three))
            {
                return one + "_" + two + "_" + three;
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string valueToConvert = value as string;
            Debug.WriteLine("MyMultiBindingConverter.ConvertBack[" + (string.IsNullOrEmpty(InstanceId) ? "Global" : InstanceId) + "]");
            Debug.WriteLine("MyMultiBindingConverter.ConvertBack[" + (string.IsNullOrEmpty(InstanceId) ? "Global" : InstanceId) + "]"
                + "[in:" + (string.IsNullOrEmpty(valueToConvert) ? "NULL" : valueToConvert) + "]"
            );
            if (m_allowConvertBack)
            {
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
