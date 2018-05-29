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
    /// Interaction logic for ReportControl.xaml
    /// </summary>
    public partial class ReportControl : UserControl
    {
        private Random _random = new Random();

        public ReportControl()
        {
            InitializeComponent();
            var values = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < 12; i++)
            {
                values.Add(new KeyValuePair<string, int>($"{i * 2}", 20 + _random.Next(300)));
            }

            LineChart1.DataContext = values;
        }

        private void OnPrintReport(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Printing Report.", "ETT Time Tracker");
        }

        private void OnSaveReport(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reports saved successfully.", "ETT Time Tracker");

        }

        private void OnShowFilters(object sender, RoutedEventArgs e)
        {
            FiltersPopup.IsOpen = true;
        }

        private void OnFilterPopupClose(object sender, EventArgs e)
        {
            FiltersPopup.IsOpen = false;
        }
    }
}
