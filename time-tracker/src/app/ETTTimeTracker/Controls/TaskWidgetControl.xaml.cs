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

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TaskWidgetControl.xaml
    /// </summary>
    public partial class TaskWidgetControl : UserControl
    {
        private ETTViewModel _viewModel;

        public TaskWidgetControl()
        {
            InitializeComponent();
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

        public void Initialize(ETTViewModel viewModel)
        {
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void OnShowTaskDetails(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Tag is JobTask task)
                {
                    _viewModel.SetActiveTask(task);
                    MiniTaskDetails.SetTaskDetails(_viewModel.ActiveTask);
                    MiniTaskDetailsPopup.IsOpen = true;
                }
            }
        }

        private void OnMiniTaskDetailsClose(object sender, EventArgs e)
        {
            MiniTaskDetailsPopup.IsOpen = false;
        }
    }
}
