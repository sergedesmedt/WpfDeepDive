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
    /// Interaction logic for UpdateSourceTrigger.xaml
    /// </summary>
    public partial class UpdateSourceTrigger : Window
    {
        public UpdateSourceTrigger()
        {
            InitializeComponent();
        }

        private void ButtonTriggerText_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = TextEplicit.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

        private void ButtonTriggerSlider_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = SliderExplicit.GetBindingExpression(Slider.ValueProperty);
            binding.UpdateSource();
        }
    }
}
