using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Bindings
{
    public class SpecifyingThePathDataContext : INotifyPropertyChanged //, INotifyCollectionChanged
    {
        public class SubClass : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public bool NotifyPropertyChanged
            {
                get;
                set;
            }

            string m_subnotifyingProperty;
            public string SubNotifyingProperty
            {
                get { return m_subnotifyingProperty; }
                set
                {
                    m_subnotifyingProperty = value;

                    if (!NotifyPropertyChanged)
                        return;

                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("SubNotifyingProperty"));
                }
            }

            public CollectionView SubSimpleCollectionView
            {
                get;
                set;
            }
        }

        public bool NotifyPropertyChanged
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        SubClass m_subclassproperty;
        public SubClass SubclassProperty
        {
            get { return m_subclassproperty; }
            set
            {
                m_subclassproperty = value;

                if (!NotifyPropertyChanged)
                    return;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SubclassProperty"));
            }
        }

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

        public ObservableCollection<String> SimpleObservableCollectionProperty
        {
            get;
            set;
        }

        public List<String> SimpleMuteCollectionProperty
        {
            get;
            set;
        }

        public ObservableCollection<SubClass> ComplexObservableCollectionProperty
        {
            get;
            set;
        }

        public CollectionView SimpleCollectionView
        {
            get;
            set;
        }

        public CollectionView ComplexCollectionView
        {
            get;
            set;
        }

        public string[] SingleDimensionalArrayProperty
        {
            get;
            set;
        }

        public string[,] MultiDimensionalArrayProperty
        {
            get;
            set;
        }

        public string this[int i, int j]
        { 
            get 
            {
                return MultiDimensionalArrayProperty[i, j]; 
            }
            set
            {
                MultiDimensionalArrayProperty[i, j] = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(Binding.IndexerName));

//                if(CollectionChanged != null)
//                {
//                    NotifyCollectionChangedEventArgs e = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace,  MultiDimensionalArrayProperty[i, j]);
//                    CollectionChanged(this, e);
//                }
            }
        }

//        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
