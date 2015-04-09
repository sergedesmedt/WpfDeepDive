using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfVisualCustomization.Styling.Triggers
{
    public class NotifyPropertyChangedDataClass : INotifyPropertyChanged
    {
        bool mIsChecked;
        public bool IsChecked
        {
            get { return mIsChecked; }
            set
            {
                mIsChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        public bool UseCorrectPropertyName
        {
            get;
            set;
        }

        public bool UseOtherPropertyName
        {
            get;
            set;
        }

        bool mPropertyWithName;
        public bool PropertyWithName
        {
            get { return mPropertyWithName; }
            set
            {
                mPropertyWithName = value;
                OnPropertyChanged(UseOtherPropertyName?
                    "PropertyWithOtherName"
                    :(UseCorrectPropertyName ? "PropertyWithName" : "PropertyWithWrongName"));
            }
        }

        bool mPropertyWithOtherName;
        public bool PropertyWithOtherName
        {
            get { return mPropertyWithOtherName; }
            set
            {
                mPropertyWithOtherName = value;
                OnPropertyChanged("PropertyWithOtherName");
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
