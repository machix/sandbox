using System;
using System.Windows;

namespace ETTTimeTracker.Controls
{
    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.ViewModels;

    /// <summary>
    /// Interaction logic for FilterControl.xaml
    /// </summary>
    public partial class FilterControl
    {
        private ETTViewModel viewModel;

        private WorkflowConnector connector;

        public event EventHandler Close;

        public FilterControl()
        {
            this.InitializeComponent();
        }

        internal void Initialize(ETTViewModel vm, WorkflowConnector workflowConnector)
        {
            this.connector = workflowConnector;
            this.viewModel = vm;
        }

        private void OnClearFilters(object sender, RoutedEventArgs e)
        {
            this.connector.Timesheet.ClearRequest();
            this.Close?.Invoke(this, null);
        }

        private void OnApplyFilters(object sender, RoutedEventArgs e)
        {
            this.connector.Timesheet.ApplyRequest();
            MessageBox.Show("Filters Successfully applied.", "ETT Time Tracker");
            this.Close?.Invoke(this, null);
        }
    }
}
