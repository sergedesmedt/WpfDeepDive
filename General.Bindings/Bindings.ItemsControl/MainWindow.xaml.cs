using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bindings.ItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollectionDataContext m_dataContext;

        public MainWindow()
        {
            m_dataContext = new CollectionDataContext();

            m_dataContext.ObservableSource = new ObservableCollection<string>();

            m_dataContext.ObservableSource.Add("Observable Value 1");
            m_dataContext.ObservableSource.Add("Observable Value 2");
            m_dataContext.ObservableSource.Add("Observable Value 3");
            m_dataContext.ObservableSource.Add("Observable Value 4");

            m_dataContext.ListSource = new List<string>();

            m_dataContext.ListSource.Add("List Value 1");
            m_dataContext.ListSource.Add("List Value 2");
            m_dataContext.ListSource.Add("List Value 3");
            m_dataContext.ListSource.Add("List Value 4");

            m_dataContext.ComplexObservableSource = new ObservableCollection<ComplexClass>();

            m_dataContext.ComplexObservableSource.Add(new ComplexClass() { MuteProperty = "Mute 1", NotifyingProperty = "Notify 1" });
            m_dataContext.ComplexObservableSource.Add(new ComplexClass() { MuteProperty = "Mute 2", NotifyingProperty = "Notify 2" });
            m_dataContext.ComplexObservableSource.Add(new ComplexClass() { MuteProperty = "Mute 3", NotifyingProperty = "Notify 3" });
            m_dataContext.ComplexObservableSource.Add(new ComplexClass() { MuteProperty = "Mute 4", NotifyingProperty = "Notify 4" });

            m_dataContext.ComplexListSource = new List<ComplexClass>();

            m_dataContext.ComplexListSource.Add(new ComplexClass() { MuteProperty = "Mute 1", NotifyingProperty = "Notify 1" });
            m_dataContext.ComplexListSource.Add(new ComplexClass() { MuteProperty = "Mute 2", NotifyingProperty = "Notify 2" });
            m_dataContext.ComplexListSource.Add(new ComplexClass() { MuteProperty = "Mute 3", NotifyingProperty = "Notify 3" });
            m_dataContext.ComplexListSource.Add(new ComplexClass() { MuteProperty = "Mute 4", NotifyingProperty = "Notify 4" });

            this.DataContext = m_dataContext;

            InitializeComponent();
        }

        private void AddToObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ObservableSource.Add("Added value");
        }

        private void RemoveFromObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ObservableSource.RemoveAt(0);
        }

        private void ChangeInObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ObservableSource[0] = "Changed value";
        }

        private void AddToListSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ListSource.Add("Added value");
        }

        private void RemoveFromListSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ListSource.RemoveAt(0);
        }

        private void ChangeInListSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ListSource[0] = "Changed value";
        }

        private void AddToComplexObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ComplexObservableSource.Add(new ComplexClass() { MuteProperty = "Added mute value", NotifyingProperty = "Added notifying value" });
        }

        private void RemoveFromComplexObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ComplexObservableSource.RemoveAt(0);
        }

        private void ChangeItemInComplexObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ComplexObservableSource[0] = new ComplexClass() { MuteProperty = "Changed Mute", NotifyingProperty = "Changed Notify" };
        }

        private void ChangeMuteInComplexObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ComplexObservableSource[0].MuteProperty = "Changed mute value";
        }

        private void ChangeNotifyingInComplexObservableSource(object sender, RoutedEventArgs e)
        {
            m_dataContext.ComplexObservableSource[0].NotifyingProperty = "Changed notifying value";
        }

        private void GetSelectedItemNoSync(object sender, RoutedEventArgs e)
        {
            if (ListSyncNoSyncing.SelectedItem == null)
                MessageBox.Show("There is no current Item");
            else
                MessageBox.Show((ListSyncNoSyncing.SelectedItem as ComplexClass).NotifyingProperty);
        }

        private void GetCurrentItemNoSync(object sender, RoutedEventArgs e)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(m_dataContext.ComplexObservableSource);
            if(view.CurrentItem == null)
                MessageBox.Show("There is no current Item");
            else
                MessageBox.Show((view.CurrentItem as ComplexClass).NotifyingProperty);
        }

        private void GetSelectedItemWtSync(object sender, RoutedEventArgs e)
        {
            if (ListSyncWtSyncing.SelectedItem == null)
                MessageBox.Show("There is no current Item");
            else
                MessageBox.Show((ListSyncWtSyncing.SelectedItem as ComplexClass).NotifyingProperty);
        }

        private void GetCurrentItemWtSync(object sender, RoutedEventArgs e)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(m_dataContext.ComplexObservableSource);
            if (view.CurrentItem == null)
                MessageBox.Show("There is no current Item");
            else
                MessageBox.Show((view.CurrentItem as ComplexClass).NotifyingProperty);
        }

        private void SetSelectedInObservable(object sender, RoutedEventArgs e)
        {
            m_dataContext.SelectedInObservable = m_dataContext.ComplexObservableSource[2];
        }

        private void SetSelectedValueInObservable(object sender, RoutedEventArgs e)
        {
            m_dataContext.SelectedValueInObservable = m_dataContext.ComplexObservableSource[2].NotifyingProperty;
        }
    }
}
