using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVisualCustomization.Templating {
    public class TopLevelData {
        public string Name { get; set; }

        public List<Lvl1Data> Lvl1Children { get; set; }
        public List<Lvl1Data> Children { get { return Lvl1Children; } }
    }
}
