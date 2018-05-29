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
using ETTTimeTracker.Models;
using ETTTimeTracker.ViewModels;
using ETTTimeTracker.Views;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TaskListControl.xaml
    /// </summary>
    public partial class TaskListControl : UserControl
    {
        private ETTViewModel _viewModel;

        public TaskListControl()
        {
            InitializeComponent();
        }

        public void Initialize(ETTViewModel viewModel)
        {
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void OnTimerStart(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (sender is CheckBox checkbox)
            {
                if (checkbox.Tag is JobTask jobTask)
                {
                    _viewModel?.SetActiveTask(jobTask);
                    jobTask.StartTimer();
                }
            }
        }

        private void OnTimerPause(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (sender is CheckBox checkbox)
            {
                if (checkbox.Tag is JobTask jobTask)
                {
                    jobTask.PauseTimer();
                }
            }
        }

        private void OnShowTaskDetails(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Tag is JobTask task)
                {
                    var backup = task.CreateBackup();

                    var dlg = new TaskDetailsDialog()
                    {
                        Owner = Application.Current.MainWindow,
                        WindowStartupLocation = WindowStartupLocation.CenterOwner
                    };
                    dlg.Initialize(task);

                    var result = dlg.ShowDialog();
                    // User has canceled changes made to the task
                    if (result == false)
                    {
                        if (task.ShouldDelete)
                        {
                            _viewModel.Tasks.Remove(task);
                        }
                        else
                        {
                            task.RestoreFrom(backup);
                        }
                    }
                }
            }

            
        }
    }
}
