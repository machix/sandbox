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
using ETTTimeTracker.Controls;
using ETTTimeTracker.ViewModels;

namespace ETTTimeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomWindow
    {
        private ETTViewModel _viewModel;
        private SettingsViewModel _settingsViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ETTViewModel();

            TimerWidgetControl.Initialize(_viewModel);
            Dashboard.Initialize(_viewModel);
            Timesheet.Initialize(_viewModel);

            _settingsViewModel = new SettingsViewModel();
            _viewModel.UpdateSettingsViewModel(_settingsViewModel);
            Settings.Initialize(_settingsViewModel);
            MiniSettings.Initialize(_settingsViewModel);
            TaskWidget.Initialize(_viewModel);

            DataContext = _viewModel;
        }

        protected override void OnMinimize(object sender, RoutedEventArgs e)
        {
            base.OnMinimize(sender, e);
            if (WindowFrameMode == WindowMode.Mini)
            {
                TimerWidgetControl.Mode = TimerWidgetMode.Mini;
                TaskWidget.Visibility = Visibility.Collapsed;
                Grid.SetRow(TimerWidgetControl, 1);
                Grid.SetColumn(TimerWidgetControl, 0);
                Grid.SetColumnSpan(TimerWidgetControl, 2);
                TimerWidgetControl.Margin = new Thickness();
            }
        }

        protected override void OnWidget(object sender, RoutedEventArgs e)
        {
            base.OnWidget(sender, e);
            UpdateWidgetLayout();
        }

        protected override void OnClose(object sender, RoutedEventArgs e)
        {
            if (WindowFrameMode == WindowMode.Widget)
            {
                TaskWidget.Visibility = Visibility.Collapsed;
            }
            ETTTab.Visibility = Visibility.Visible;
            Grid.SetRow(TimerWidgetControl, 0);
            Grid.SetColumn(TimerWidgetControl, 1);
            Grid.SetColumnSpan(TimerWidgetControl, 1);
            TimerWidgetControl.Mode = TimerWidgetMode.Maximized;
            TimerWidgetControl.Margin = new Thickness(0, 2, 100, -2);
            base.OnClose(sender, e);
        }

        private void OnSwitchToWidget(object sender, EventArgs e)
        {
            SystemCommands.RestoreWindow(this);
            WindowFrameMode = WindowMode.Widget;
            UpdateWidgetLayout();
        }

        private void UpdateWidgetLayout()
        {
            TimerWidgetControl.Mode = TimerWidgetMode.Widget;
            ETTTab.Visibility = Visibility.Collapsed;
            TaskWidget.Visibility = Visibility.Visible;
            Grid.SetRow(TimerWidgetControl, 1);
            Grid.SetColumn(TimerWidgetControl, 0);
            Grid.SetColumnSpan(TimerWidgetControl, 2);
            TimerWidgetControl.Margin = new Thickness(0, 0, 0, 0);
        }

        protected override void OnMiniSettings(object sender, RoutedEventArgs e)
        {
            MiniSettingsPopup.IsOpen = !MiniSettingsPopup.IsOpen;
        }

        private void OnMiniSettingsClose(UIElement sender, SettingsEventArgs args)
        {
            if (args.SaveSettings)
            {
                _viewModel.SaveSettings(_settingsViewModel);
            }
            else
            {
                _viewModel.UpdateSettingsViewModel(_settingsViewModel);
            }
            // Close the popup
            MiniSettingsPopup.IsOpen = false;
        }

        private void OnUpdateSettings(UIElement sender, SettingsEventArgs args)
        {
            if (args.SaveSettings)
            {
                _viewModel.SaveSettings(_settingsViewModel);
            }
            else
            {
                _viewModel.UpdateSettingsViewModel(_settingsViewModel);
            }
        }

        private void OnTabItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DashboardPath.Fill = Brushes.White;
            DashboardText.Foreground = Brushes.White;
            TimesheetPath.Fill = Brushes.White;
            TimesheetText.Foreground = Brushes.White;
            ReportsPath.Fill = Brushes.White;
            ReportsText.Foreground = Brushes.White;
            SettingsPath.Fill = Brushes.White;
            SettingsText.Foreground = Brushes.White;

            switch (ETTTab.SelectedIndex)
            {
                case 0:
                    DashboardPath.Fill = Brushes.Black;
                    DashboardText.Foreground = Brushes.Black;
                    break;

                case 1:
                    TimesheetPath.Fill = Brushes.Black;
                    TimesheetText.Foreground = Brushes.Black;
                    break;

                case 2:
                    ReportsPath.Fill = Brushes.Black;
                    ReportsText.Foreground = Brushes.Black;
                    break;

                case 3:
                    SettingsPath.Fill = Brushes.Black;
                    SettingsText.Foreground = Brushes.Black;
                    break;
            }
        }

        private void OnShowNotifications(object sender, RoutedEventArgs e)
        {
            NotificationsPopup.IsOpen = true;
        }
    }
}
