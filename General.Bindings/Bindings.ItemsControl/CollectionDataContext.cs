using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings.ItemsControl
{
    class CollectionDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> ObservableSource
        {
            get;
            set;
        }

        public List<string> ListSource
        {
            get;
            set;
        }

        public ObservableCollection<ComplexClass> ComplexObservableSource
        {
            get;
            set;
        }

        ComplexClass m_selectedInObservable;
        public ComplexClass SelectedInObservable
        {
            get { return m_selectedInObservable; }
            set
            {
                m_selectedInObservable = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedInObservable"));
            }
        }

        string m_selectedValueInObservable;
        public string SelectedValueInObservable
        {
            get { return m_selectedValueInObservable; }
            set
            {
                m_selectedValueInObservable = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedValueInObservable"));
            }
        }

        public List<ComplexClass> ComplexListSource
        {
            get;
            set;
        }
    }
}
