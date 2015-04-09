using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class MultiPropertyDataClass : INotifyPropertyChanged
    {
        bool mProperty1;
        public bool Property1
        {
            get { return mProperty1; }
            set
            {
                mProperty1 = value;
                OnPropertyChanged("Property1");
            }
        }

        bool mProperty2;
        public bool Property2
        {
            get { return mProperty2; }
            set
            {
                mProperty2 = value;
                OnPropertyChanged("Property2");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
