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

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for FilterControl.xaml
    /// </summary>
    public partial class FilterControl : UserControl
    {
        public event EventHandler Close;

        public FilterControl()
        {
            InitializeComponent();
        }

        private void OnClearFilters(object sender, RoutedEventArgs e)
        {
            Close?.Invoke(this, null);
        }

        private void OnApplyFilters(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Filters Successfully applied.", "ETT Time Tracker");
            Close?.Invoke(this, null);
        }
    }
}
