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
using System.Windows.Shapes;
using ETTTimeTracker.Common;
using ETTTimeTracker.Controls;
using ETTTimeTracker.Models;

namespace ETTTimeTracker.Views
{
    /// <summary>
    /// Interaction logic for TaskDetailsDialog.xaml
    /// </summary>
    public partial class TaskDetailsDialog : CustomDialog
    {
        private JobTask _currentTask;
        private Random _random = new Random();

        public TaskDetailsDialog()
        {
            InitializeComponent();
            NamesCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.Name).ToList();
            SearchableCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.AFE).ToList();
        }

        public void Initialize(JobTask task)
        {
            _currentTask = task;
            DataContext = _currentTask;
            Title = $"Project \"{task.Name}\" details";

            var values = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < 12; i++)
            {
                values.Add(new KeyValuePair<string, int>($"{i * 2}", 20 + _random.Next(300)));
            }

            ColumnChart1.DataContext = values;
        }

        private void OnSaveChanges(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancelChanges(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void OnDeleteTask(object sender, RoutedEventArgs e)
        {
            _currentTask.ShouldDelete = true;
            DialogResult = false;
        }

        private void OnStartTimer(object sender, RoutedEventArgs e)
        {
            _currentTask.StartTimer();
        }

        private void OnPauseTimer(object sender, RoutedEventArgs e)
        {
            _currentTask.PauseTimer();
        }

        private void OnShowTimeline(object sender, RoutedEventArgs e)
        {
            TimelinePopup.IsOpen = true;
        }

        private void OnHideTimeline(object sender, RoutedEventArgs e)
        {
            TimelinePopup.IsOpen = false;
        }

        private void OnCopyEntries(object sender, RoutedEventArgs e)
        {
            var dlg = new CopyEntriesDialog()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            dlg.ShowDialog();
        }
    }
}
