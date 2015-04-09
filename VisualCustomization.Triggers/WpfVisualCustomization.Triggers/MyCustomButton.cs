using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class MyCustomButton : Button, INotifyPropertyChanged
    {
        bool mNotifyChangesProperty;
        public bool NotifyChangesProperty
        {
            get { return mNotifyChangesProperty; }
            set
            {
                mNotifyChangesProperty = value;
                OnPropertyChanged("NotifyChangesProperty");
            }
        }

        // This property provides no notification of
        //	any changes made to its value
        public bool MuteProperty
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
