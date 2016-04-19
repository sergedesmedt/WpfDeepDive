using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfVisualCustomization.Templating
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is CustomData)
            {
                CustomData taskitem = item as CustomData;

                if (taskitem.XCoord >= taskitem.YCoord)
                    return
                        element.FindResource("XCoordIsBiggerThenOrEqualToYCoord") as DataTemplate;
                else
                    return
                        element.FindResource("XCoordIsSmallerThenYCoord") as DataTemplate;
            }

            return null;
        }
    }
}
