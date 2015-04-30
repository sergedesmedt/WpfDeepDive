using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class IsCheckedDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        bool m_isChecked;
        public bool IsChecked
        {
            get { return m_isChecked; }
            set
            {
                m_isChecked = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("IsChecked"));
            }
        }
    }
}
