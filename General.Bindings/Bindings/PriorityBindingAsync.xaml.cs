using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for PriorityBindingAsync.xaml
    /// </summary>
    public partial class PriorityBindingAsync : Window
    {
        public PriorityBindingAsync()
        {
            Stage3Dumb = "unset";
            Stage2Dumb = "unset";

            InitializeComponent();

        }

        public string Stage3
        {
            get
            {
                Thread.Sleep(10000);
                return "Stage3: after 10 seconds";
            }
        }

        public string Stage2
        {
            get
            {
                Thread.Sleep(5000);
                return "Stage2: after 5 seconds";
            }
        }

        public string Stage1
        {
            get
            {
                return "Stage1: immediately";
            }
        }

        public string Stage3Dumb
        {
            get;
            set;
        }

        public string Stage2Dumb
        {
            get;
            set;
        }

        public string Stage1Dumb
        {
            get
            {
                return "Stage1Dumb: immediately";
            }
        }

        private void Button_ClickStage2Dumb(object sender, RoutedEventArgs e)
        {
            Stage2Dumb = "Stage2Dumb: set";
        }

        private void Button_ClickStage3Dumb(object sender, RoutedEventArgs e)
        {
            Stage3Dumb = "Stage3Dumb: set";
        }
    }
}
