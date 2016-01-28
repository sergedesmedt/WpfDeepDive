using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfVisualCustomization.Templating
{
    public class CustomContext
    {
        public Brush DataContextBrush { get; set; }

        public CustomData TheData { get; set; }
    }
}
