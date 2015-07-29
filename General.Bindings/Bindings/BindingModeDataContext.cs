using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    class BindingModeDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string m_twoWayBindingProperty;
        public string TwoWayBindingProperty
        {
            get { return m_twoWayBindingProperty; }
            set
            {
                m_twoWayBindingProperty = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("TwoWayBindingProperty"));
            }
        }

        string m_readOnlyProperty;
        public string ReadOnlyProperty
        {
            get { return m_readOnlyProperty; }
        }

        string m_oneWayBindingProperty;
        public string OneWayBindingProperty
        {
            get { return m_oneWayBindingProperty; }
        }

        public string OneWayBindingPropertySetter
        {
            set { m_oneWayBindingProperty = value; }
        }


        string m_oneWayBindingPropertyFullProp;
        public string OneWayBindingPropertyFullProp
        {
            get { return m_oneWayBindingPropertyFullProp; }
            set
            {
                m_oneWayBindingPropertyFullProp = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("OneWayBindingPropertyFullProp"));
            }
        }

        string m_oneWayToSourceBindingProperty;
        public string OneWayToSourceBindingProperty
        {
            get { return m_oneWayToSourceBindingProperty; }
            set
            {
                m_oneWayToSourceBindingProperty = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("OneWayToSourceBindingProperty"));
            }
        }

        public string OneWayToSourceBindingPropertyGetter
        {
            get { return m_oneWayToSourceBindingProperty; }
        }

        string m_oneWayToSourceGetIsCalledProperty;
        public string OneWayToSourceGetIsCalledProperty
        {
            get { return "From GET: " + m_oneWayToSourceGetIsCalledProperty; }
            set
            {
                m_oneWayToSourceGetIsCalledProperty = value;
            }
        }

        string m_oneTimeBindingProperty;
        public string OneTimeBindingProperty
        {
            get { return m_oneTimeBindingProperty; }
            set
            {
                m_oneTimeBindingProperty = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("OneTimeBindingProperty"));
            }
        }
    }
}
