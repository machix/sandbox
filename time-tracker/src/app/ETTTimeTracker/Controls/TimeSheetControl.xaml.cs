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
using ETTTimeTracker.Common;
using ETTTimeTracker.Models;
using ETTTimeTracker.ViewModels;
using ETTTimeTracker.Views;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TimeSheetControl.xaml
    /// </summary>
    public partial class TimeSheetControl : UserControl
    {
        private ETTViewModel _viewModel;

        public TimeSheetControl()
        {
            InitializeComponent();
            dateDisplay.SelectedDate = DateTime.Now;
        }

        public void Initialize(ETTViewModel viewModel)
        {
            _viewModel = viewModel;
            TaskList.Initialize(_viewModel);
        }

        private void OnAddNewProject(object sender, RoutedEventArgs e)
        {
            var dialog = new AddProjectDialog
            {
                Width = 500,
                Height = 400,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = Application.Current.MainWindow
            };
            var task = new JobTask();
            dialog.Initialize(task);

            var result = dialog.ShowDialog();
            if (result == true)
            {
                // Set the Cost Center based on the selected AFE
                var job = JobHelper.JobTitles.FirstOrDefault(x => x.AFE == task.AFE);
                if (job != null)
                {
                    task.CostCenter = job.CostCenter;
                }
                _viewModel.Tasks.Add(task);

                MessageBox.Show("Project added successfully!");
            }
        }

        private void OnFilterPopupClose(object sender, EventArgs e)
        {
            FiltersPopup.IsOpen = false;
        }

        private void OnShowFilters(object sender, RoutedEventArgs e)
        {
            FiltersPopup.IsOpen = true;
        }

        private void OnPrevDate(object sender, RoutedEventArgs e)
        {
            dateDisplay.SelectedDate -= TimeSpan.FromDays(1);
        }

        private void OnNextDate(object sender, RoutedEventArgs e)
        {
            dateDisplay.SelectedDate += TimeSpan.FromDays(1);
        }
    }
}
