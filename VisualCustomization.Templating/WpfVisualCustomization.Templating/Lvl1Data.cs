using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVisualCustomization.Templating {
    public class Lvl1Data {
        public string Name { get; set; }

        public List<Lvl2Data> Lvl2Children { get; set; }
        public List<Lvl2Data> Children { get { return Lvl2Children; } }
    }
}
