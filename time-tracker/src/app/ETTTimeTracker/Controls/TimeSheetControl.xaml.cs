using System;
using System.Linq;
using System.Windows;

using ETTTimeTracker.Common;
using ETTTimeTracker.Models;
using ETTTimeTracker.ViewModels;
using ETTTimeTracker.Views;

namespace ETTTimeTracker.Controls
{
    using ETTTimeTracker.Connectors.Common;

    /// <summary>
    /// Interaction logic for TimeSheetControl.xaml
    /// </summary>
    public partial class TimeSheetControl
    {
        private ETTViewModel viewModel;

        private WorkflowConnector connector;

        public TimeSheetControl()
        {
            this.InitializeComponent();
            this.dateDisplay.SelectedDate = DateTime.Now;
        }

        internal void Initialize(ETTViewModel vm, WorkflowConnector workflowConnector)
        {
            this.connector = workflowConnector;
            this.viewModel = vm;
            this.TaskList.Initialize(this.viewModel);
        }

        public void UpdateProjects()
        {
            this.connector.Timesheet.UpdateProjects();
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
                this.viewModel.Tasks.Add(task);

                MessageBox.Show("Project added successfully!");
            }
        }

        private void OnFilterPopupClose(object sender, EventArgs e)
        {
            this.FiltersPopup.IsOpen = false;
        }

        private void OnShowFilters(object sender, RoutedEventArgs e)
        {
            this.FiltersPopup.IsOpen = true;
        }

        private void OnPrevDate(object sender, RoutedEventArgs e)
        {
            this.dateDisplay.SelectedDate -= TimeSpan.FromDays(1);
        }

        private void OnNextDate(object sender, RoutedEventArgs e)
        {
            this.dateDisplay.SelectedDate += TimeSpan.FromDays(1);
        }
    }
}
