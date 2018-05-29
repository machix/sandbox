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
using ETTTimeTracker.ViewModels;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for DashboardControl.xaml
    /// </summary>
    public partial class DashboardControl : UserControl
    {
        private ETTViewModel _viewModel;

        private DateTime _currentDate;
        private Random _random = new Random();

        #region CurrentDateString

        /// <summary>
        /// CurrentDateString Dependency Property
        /// </summary>
        public static readonly DependencyProperty CurrentDateStringProperty =
            DependencyProperty.Register("CurrentDateString", typeof(string), typeof(DashboardControl),
                new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the CurrentDateString property. This dependency property 
        /// indicates the current date string.
        /// </summary>
        public string CurrentDateString
        {
            get => (string)GetValue(CurrentDateStringProperty);
            set => SetValue(CurrentDateStringProperty, value);
        }

        #endregion


        public DashboardControl()
        {
            InitializeComponent();
            _currentDate = DateTime.Today;
            CurrentDateString = _currentDate.ToString("MM/dd/yyyy");
        }

        public void Initialize(ETTViewModel viewModel)
        {
            _viewModel = viewModel;
            TaskList.Initialize(_viewModel);

            var values = new List<KeyValuePair<string, int>>();
            
            for (int i = 0; i < 24; i++)
            {
                values.Add(new KeyValuePair<string, int>($"{i:00}:00", 20 + _random.Next(300)));
            }

            ColumnChart1.DataContext = values;
        }

        private void OnShowFilters(object sender, RoutedEventArgs e)
        {
            FiltersPopup.IsOpen = true;
        }

        private void OnFilterPopupClose(object sender, EventArgs e)
        {
            FiltersPopup.IsOpen = false;
        }

        private void OnPrevDate(object sender, RoutedEventArgs e)
        {
            _currentDate -= TimeSpan.FromDays(1);
            CurrentDateString = _currentDate.ToString("MM/dd/yyyy");
        }

        private void OnNextDate(object sender, RoutedEventArgs e)
        {
            _currentDate += TimeSpan.FromDays(1);
            CurrentDateString = _currentDate.ToString("MM/dd/yyyy");
        }
    }
}
