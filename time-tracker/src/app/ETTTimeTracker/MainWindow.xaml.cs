using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using ETTTimeTracker.Common;
using ETTTimeTracker.ViewModels;

namespace ETTTimeTracker
{
    using AutoMapper;

    using Ett.Common.IoC.Ninject.IoC;
    using Ett.TimeTracker.Workflow.Common;

    using ETTTimeTracker.Connectors.Common;
    using ETTTimeTracker.Infrastructure;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly ETTViewModel viewModel;
        private readonly SettingsViewModel settingsViewModel;

        public MainWindow()
        {
            this.InitializeComponent();
            this.viewModel = new ETTViewModel();
            this.settingsViewModel = new SettingsViewModel();

            // Connect to workflow
            var workflow = new Workflow(new TimeTrackerClientProfile());

            var connector = new WorkflowConnector(
                this.viewModel, 
                this.settingsViewModel,
                workflow,
                ManualDependencyResolver.Get<IMapper>());

            this.TimerWidgetControl.Initialize(this.viewModel);
            this.Dashboard.Initialize(this.viewModel);
            this.Timesheet.Initialize(this.viewModel, connector);

            this.viewModel.UpdateSettingsViewModel(this.settingsViewModel);
            this.Settings.Initialize(this.settingsViewModel);
            this.MiniSettings.Initialize(this.settingsViewModel);
            this.TaskWidget.Initialize(this.viewModel);

            this.DataContext = this.viewModel;
        }

        protected override void OnMinimize(object sender, RoutedEventArgs e)
        {
            base.OnMinimize(sender, e);
            if (this.WindowFrameMode == WindowMode.Mini)
            {
                this.TimerWidgetControl.Mode = TimerWidgetMode.Mini;
                this.TaskWidget.Visibility = Visibility.Collapsed;
                Grid.SetRow(this.TimerWidgetControl, 1);
                Grid.SetColumn(this.TimerWidgetControl, 0);
                Grid.SetColumnSpan(this.TimerWidgetControl, 2);
                this.TimerWidgetControl.Margin = new Thickness();
            }
        }

        protected override void OnWidget(object sender, RoutedEventArgs e)
        {
            base.OnWidget(sender, e);
            this.UpdateWidgetLayout();
        }

        protected override void OnClose(object sender, RoutedEventArgs e)
        {
            if (this.WindowFrameMode == WindowMode.Widget)
            {
                this.TaskWidget.Visibility = Visibility.Collapsed;
            }
            this.ETTTab.Visibility = Visibility.Visible;
            Grid.SetRow(this.TimerWidgetControl, 0);
            Grid.SetColumn(this.TimerWidgetControl, 1);
            Grid.SetColumnSpan(this.TimerWidgetControl, 1);
            this.TimerWidgetControl.Mode = TimerWidgetMode.Maximized;
            this.TimerWidgetControl.Margin = new Thickness(0, 2, 100, -2);
            base.OnClose(sender, e);
        }

        private void OnSwitchToWidget(object sender, EventArgs e)
        {
            SystemCommands.RestoreWindow(this);
            this.WindowFrameMode = WindowMode.Widget;
            this.UpdateWidgetLayout();
        }

        private void UpdateWidgetLayout()
        {
            this.TimerWidgetControl.Mode = TimerWidgetMode.Widget;
            this.ETTTab.Visibility = Visibility.Collapsed;
            this.TaskWidget.Visibility = Visibility.Visible;
            Grid.SetRow(this.TimerWidgetControl, 1);
            Grid.SetColumn(this.TimerWidgetControl, 0);
            Grid.SetColumnSpan(this.TimerWidgetControl, 2);
            this.TimerWidgetControl.Margin = new Thickness(0, 0, 0, 0);
        }

        protected override void OnMiniSettings(object sender, RoutedEventArgs e)
        {
            this.MiniSettingsPopup.IsOpen = !this.MiniSettingsPopup.IsOpen;
        }

        private void OnMiniSettingsClose(UIElement sender, SettingsEventArgs args)
        {
            if (args.SaveSettings)
            {
                this.viewModel.SaveSettings(this.settingsViewModel);
            }
            else
            {
                this.viewModel.UpdateSettingsViewModel(this.settingsViewModel);
            }
            // Close the popup
            this.MiniSettingsPopup.IsOpen = false;
        }

        private void OnUpdateSettings(UIElement sender, SettingsEventArgs args)
        {
            if (args.SaveSettings)
            {
                this.viewModel.SaveSettings(this.settingsViewModel);
            }
            else
            {
                this.viewModel.UpdateSettingsViewModel(this.settingsViewModel);
            }
        }

        private void OnTabItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DashboardPath.Fill = Brushes.White;
            this.DashboardText.Foreground = Brushes.White;
            this.TimesheetPath.Fill = Brushes.White;
            this.TimesheetText.Foreground = Brushes.White;
            this.ReportsPath.Fill = Brushes.White;
            this.ReportsText.Foreground = Brushes.White;
            this.SettingsPath.Fill = Brushes.White;
            this.SettingsText.Foreground = Brushes.White;

            switch (this.ETTTab.SelectedIndex)
            {
                case 0:
                    this.DashboardPath.Fill = Brushes.Black;
                    this.DashboardText.Foreground = Brushes.Black;
                    break;

                case 1:
                    this.TimesheetPath.Fill = Brushes.Black;
                    this.TimesheetText.Foreground = Brushes.Black;
                    this.Timesheet.UpdateProjects();
                    break;

                case 2:
                    this.ReportsPath.Fill = Brushes.Black;
                    this.ReportsText.Foreground = Brushes.Black;
                    break;

                case 3:
                    this.SettingsPath.Fill = Brushes.Black;
                    this.SettingsText.Foreground = Brushes.Black;
                    break;
            }
        }

        private void OnShowNotifications(object sender, RoutedEventArgs e)
        {
            this.NotificationsPopup.IsOpen = true;
        }
    }
}
