using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class MyCustomClass
    {
        public string StringProperty { get; set; }
        public int IntegerPoperty { get; set; }

        public override string ToString()
        {
            return "This MyCustomClass instance has a value for StringProperty of [" + StringProperty + "] and a value of IntegerProperty of [" + IntegerPoperty + "]";
        }
    }
}
