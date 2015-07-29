using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Bindings
{
    /// <summary>
    /// Interaction logic for SpecifyingThePath.xaml
    /// </summary>
    public partial class SpecifyingThePath : Window
    {
        SpecifyingThePathDataContext dataContext = new SpecifyingThePathDataContext();

        public SpecifyingThePath()
        {

            dataContext.SubclassProperty = new SpecifyingThePathDataContext.SubClass();
            dataContext.SubclassProperty.SubNotifyingProperty = "Sub initial value";

            dataContext.NotifyPropertyChanged = true;
            dataContext.SubclassProperty.NotifyPropertyChanged = true;

            dataContext.SimpleObservableCollectionProperty = new ObservableCollection<string>();
            dataContext.SimpleObservableCollectionProperty.Add("Value at index 0");
            dataContext.SimpleObservableCollectionProperty.Add("Value at index 1");
            dataContext.SimpleObservableCollectionProperty.Add("Value at index 2");

            dataContext.SimpleMuteCollectionProperty = new List<string>();
            dataContext.SimpleMuteCollectionProperty.Add("Value at index 0");
            dataContext.SimpleMuteCollectionProperty.Add("Value at index 1");
            dataContext.SimpleMuteCollectionProperty.Add("Value at index 2");

            dataContext.ComplexObservableCollectionProperty = new ObservableCollection<SpecifyingThePathDataContext.SubClass>();
            dataContext.ComplexObservableCollectionProperty.Add(new SpecifyingThePathDataContext.SubClass() { SubNotifyingProperty = "Class value at index 0", NotifyPropertyChanged = true });
            dataContext.ComplexObservableCollectionProperty.Add(new SpecifyingThePathDataContext.SubClass() { SubNotifyingProperty = "Class value at index 1", NotifyPropertyChanged = true });
            dataContext.ComplexObservableCollectionProperty.Add(new SpecifyingThePathDataContext.SubClass() { SubNotifyingProperty = "Class value at index 2", NotifyPropertyChanged = true });

            dataContext.SingleDimensionalArrayProperty = new string[5];
            dataContext.SingleDimensionalArrayProperty[0] = "ArrayValue at [0]";
            dataContext.SingleDimensionalArrayProperty[1] = "ArrayValue at [1]";
            dataContext.SingleDimensionalArrayProperty[2] = "ArrayValue at [2]";
            dataContext.SingleDimensionalArrayProperty[3] = "ArrayValue at [3]";
            dataContext.SingleDimensionalArrayProperty[4] = "ArrayValue at [4]";

            dataContext.MultiDimensionalArrayProperty = new string[2, 3];
            dataContext.MultiDimensionalArrayProperty[0, 0] = "Value at [0,0]";
            dataContext.MultiDimensionalArrayProperty[0, 1] = "Value at [0,1]";
            dataContext.MultiDimensionalArrayProperty[0, 2] = "Value at [0,2]";
            dataContext.MultiDimensionalArrayProperty[1, 0] = "Value at [1,0]";
            dataContext.MultiDimensionalArrayProperty[1, 1] = "Value at [1,1]";
            dataContext.MultiDimensionalArrayProperty[1, 2] = "Value at [1,2]";

            dataContext.SimpleCollectionView = (CollectionView)CollectionViewSource.GetDefaultView(dataContext.SimpleMuteCollectionProperty);
            dataContext.SimpleCollectionView.MoveCurrentToFirst();


            List<SpecifyingThePathDataContext.SubClass>  complexList = new List<SpecifyingThePathDataContext.SubClass>();
            List<string> simpleList0 = new List<string>();
            simpleList0.Add("Nested Value at index 0.0");
            simpleList0.Add("Nested Value at index 0.1");
            simpleList0.Add("Nested Value at index 0.2");
            complexList.Add(new SpecifyingThePathDataContext.SubClass()
            { 
                SubNotifyingProperty = "Class value at index 0", 
                NotifyPropertyChanged = true,
                SubSimpleCollectionView = (CollectionView)CollectionViewSource.GetDefaultView(simpleList0)
            });

            List<string> simpleList1 = new List<string>();
            simpleList1.Add("Nested Value at index 1.0");
            simpleList1.Add("Nested Value at index 1.1");
            simpleList1.Add("Nested Value at index 1.2");
            complexList.Add(new SpecifyingThePathDataContext.SubClass()
            {
                SubNotifyingProperty = "Class value at index 1", 
                NotifyPropertyChanged = true,
                SubSimpleCollectionView = (CollectionView)CollectionViewSource.GetDefaultView(simpleList1)
            });

            List<string> simpleList2 = new List<string>();
            simpleList2.Add("Nested Value at index 2.0");
            simpleList2.Add("Nested Value at index 2.1");
            simpleList2.Add("Nested Value at index 2.2");
            complexList.Add(new SpecifyingThePathDataContext.SubClass()
            {
                SubNotifyingProperty = "Class value at index 2", 
                NotifyPropertyChanged = true,
                SubSimpleCollectionView = (CollectionView)CollectionViewSource.GetDefaultView(simpleList2)
            });

            dataContext.ComplexCollectionView = (CollectionView)CollectionViewSource.GetDefaultView(complexList);
            dataContext.ComplexCollectionView.MoveCurrentToFirst();

            this.DataContext = dataContext;

            InitializeComponent();

            CheckMainClassNotification.IsChecked = dataContext.NotifyPropertyChanged;
            CheckSubClassNotification.IsChecked = dataContext.SubclassProperty.NotifyPropertyChanged;
        }

        private void ButtonSet_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SubclassProperty.SubNotifyingProperty = "Sub new value";
        }

        private void ButtonGet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dataContext.SubclassProperty.SubNotifyingProperty);
        }

        private void ButtonSetObject_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SubclassProperty = new SpecifyingThePathDataContext.SubClass() { SubNotifyingProperty = "new Object" };
        }

        private void CheckSubClassNotification_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SubclassProperty.NotifyPropertyChanged = CheckSubClassNotification.IsChecked.Value;
        }

        private void CheckMainClassNotification_Click(object sender, RoutedEventArgs e)
        {
            dataContext.NotifyPropertyChanged = CheckMainClassNotification.IsChecked.Value;
        }

        private void ButtonChangeObservableColl_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SimpleObservableCollectionProperty[1] = "New Value at index 1";
        }

        private void ButtonDeleteObservableColl_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SimpleObservableCollectionProperty.RemoveAt(1);
        }

        private void ButtonChangeMuteColl_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SimpleMuteCollectionProperty[1] = "New Mute Value at index 1";
        }

        private void ButtonDeleteMuteColl_Click(object sender, RoutedEventArgs e)
        {
            dataContext.SimpleMuteCollectionProperty.RemoveAt(1);
        }

        private void ButtonChangeObservableColComplexChange_Click(object sender, RoutedEventArgs e)
        {
            dataContext.ComplexObservableCollectionProperty[1] = new SpecifyingThePathDataContext.SubClass() { SubNotifyingProperty = "New Class value at index 1", NotifyPropertyChanged = true };
        }

        private void ButtonChangeObservableCollComplexMove_Click(object sender, RoutedEventArgs e)
        {
            dataContext.ComplexObservableCollectionProperty.Move(0, 1);
        }

        private void ButtonChangeObservableCollComplexPropChange_Click(object sender, RoutedEventArgs e)
        {
            dataContext.ComplexObservableCollectionProperty[1].SubNotifyingProperty = "New Property value at index 1";
        }

        private void ButtonChangeGetMultiDim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dataContext[0, 1]);
        }

        private void ButtonChangeSetMultiDim_Click(object sender, RoutedEventArgs e)
        {
            dataContext[0, 1] = "New value at index [0,1]";
        }

        private void ButtonMoveCurrentSimpleView(object sender, RoutedEventArgs e)
        {
            dataContext.SimpleCollectionView.MoveCurrentToNext();
        }

        private void ButtonMoveCurrentComplexView(object sender, RoutedEventArgs e)
        {
            dataContext.ComplexCollectionView.MoveCurrentToNext();
        }

        private void ButtonMoveNestedCurrentComplexView(object sender, RoutedEventArgs e)
        {
            (dataContext.ComplexCollectionView.CurrentItem as SpecifyingThePathDataContext.SubClass).SubSimpleCollectionView.MoveCurrentToNext();
        }
    }
}
