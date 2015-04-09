using System;
using System.Collections.Generic;
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

namespace WpfVisualCustomization.Styling.Triggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NotifyPropertyChangedDataClass dataClass = new NotifyPropertyChangedDataClass();

            chkWithDataContextPropertyWithName.DataContext = dataClass;
            chkWithDataContextOtherPropertyWithWrongName.DataContext = dataClass;
            chkWithDataContextOtherPropertyWithName.DataContext = dataClass;

            chkWithDependecyObjectDataContext.DataContext = new DependencyPropertyDataClass();

            btnPropTriggerNotifyChangesProperty.DataContext = new CheckBox();
        }

        private void PropTriggerNotifyChangedPropertyOnClickHandler(object sender, RoutedEventArgs e)
        {
			// toggle the state of the checkbox
            (btnPropTriggerNotifyChangesProperty.DataContext as CheckBox).IsChecked = !(btnPropTriggerNotifyChangesProperty.DataContext as CheckBox).IsChecked;
        }

        private void NotifyChangedPropertyOnClickHandler(object sender, RoutedEventArgs e)
        {
            btnNotifyChangesProperty.NotifyChangesProperty = !btnNotifyChangesProperty.NotifyChangesProperty;
        }

        private void DataContextNotifyChangedPropertyOnClickHandler(object sender, RoutedEventArgs e)
        {
            (btnDataContextNotifyChangesProperty.DataContext as MyCustomButton).NotifyChangesProperty = !(btnDataContextNotifyChangesProperty.DataContext as MyCustomButton).NotifyChangesProperty;
        }

        private void MutePropertyOnClickHandler(object sender, RoutedEventArgs e)
        {
            //btnMuteProperty.MuteProperty = !btnMuteProperty.MuteProperty;
        }

        private void DataContextMutePropertyOnClickHandler(object sender, RoutedEventArgs e)
        {
            (btnDataContextNotifyChangesProperty.DataContext as MyCustomButton).MuteProperty = !(btnDataContextNotifyChangesProperty.DataContext as MyCustomButton).MuteProperty;
        }

        private void CheckCheckBox(object sender, RoutedEventArgs e)
        {
            chkWithDataContext.IsChecked = !chkWithDataContext.IsChecked;
        }

        private void CheckCheckBoxDataContext(object sender, RoutedEventArgs e)
        {
            (chkWithDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked = !(chkWithDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked;
        }

        private void CheckCheckBoxWithControlBinding(object sender, RoutedEventArgs e)
        {
            chkWithDataContextBindToControl.IsChecked = !chkWithDataContextBindToControl.IsChecked;
        }

        private void ToggleCheckBoxDependencyDataContext(object sender, RoutedEventArgs e)
        {
            (chkWithDependecyObjectDataContext.DataContext as DependencyPropertyDataClass).MyDependencyProperty = !(chkWithDependecyObjectDataContext.DataContext as DependencyPropertyDataClass).MyDependencyProperty;
        }

        private void ToggleIsCheckCheckBoxDataContext1(object sender, RoutedEventArgs e)
        {
            (chkWithMultiDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked = !(chkWithMultiDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked;
        }

        private void TogglePropertyWithOtherNameCheckBoxDataContext1(object sender, RoutedEventArgs e)
        {
            (chkWithMultiDataContext.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName = !(chkWithMultiDataContext.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName;
        }

        private void ToggleIsCheckCheckBoxDataContext2(object sender, RoutedEventArgs e)
        {
            (chkWithMultiBindingDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked = !(chkWithMultiBindingDataContext.DataContext as NotifyPropertyChangedDataClass).IsChecked;
        }

        private void TogglePropertyWithOtherNameCheckBoxDataContext2(object sender, RoutedEventArgs e)
        {
            (chkWithMultiBindingDataContext.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName = !(chkWithMultiBindingDataContext.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName;
        }

        private void SwitchByPropertyName(object sender, RoutedEventArgs e)
        {
            // We have a binding on PropertyWithName and will use this correct name 
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseOtherPropertyName = false;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseCorrectPropertyName = true;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName = !(chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName;
        }

        private void SwitchByPropertyWrongName(object sender, RoutedEventArgs e)
        {
            // We have a binding on PropertyWithWrongName and will use this wrong name 
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseOtherPropertyName = false;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseCorrectPropertyName = false;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName = !(chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName;
        }

        private void SwitchWronglyByPropertyOtherName(object sender, RoutedEventArgs e)
        {
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseOtherPropertyName = true;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).UseCorrectPropertyName = false;
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName = !(chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithName;
        }

        private void SwitchCorrectByPropertyOtherName(object sender, RoutedEventArgs e)
        {
            (chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName = !(chkWithDataContextPropertyWithName.DataContext as NotifyPropertyChangedDataClass).PropertyWithOtherName;
        }

        private void DisableTextBlockClickHandler(object sender, RoutedEventArgs e)
        {
            //tblNonRoutedEventTrigger.IsEnabled = !tblNonRoutedEventTrigger.IsEnabled;
        }
    }
}
