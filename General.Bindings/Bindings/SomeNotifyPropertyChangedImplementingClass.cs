using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class SomeNotifyPropertyChangedImplementingClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string m_notifyingProperty;
        public string NotifyingProperty
        {
            get { return m_notifyingProperty; }
            set
            {
                m_notifyingProperty = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("NotifyingProperty"));
            }
        }
    }
}
