using ETTTimeTracker.Common;
using ETTTimeTracker.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TaskDetailsMiniControl.xaml
    /// </summary>
    public partial class TaskDetailsMiniControl : UserControl
    {
        public event EventHandler Close;
        private JobTask _task;
        private JobTaskBackup _backup;

        public TaskDetailsMiniControl()
        {
            InitializeComponent();
            NamesCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.Name).ToList();
            SearchableCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.AFE).ToList();
        }

        public void SetTaskDetails(JobTask task)
        {
            _backup = task.CreateBackup();
            _task = task;
            DataContext = _task;
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Close?.Invoke(this, null);
        }

        private void OnSaveChanges(object sender, RoutedEventArgs e)
        {
            Close?.Invoke(this, null);
            MessageBox.Show("Changes saved.", "ETT Time Tracker");
        }

        private void OnCancelChanges(object sender, RoutedEventArgs e)
        {
            _task.RestoreFrom(_backup);
            Close?.Invoke(this, null);
        }
    }
}
