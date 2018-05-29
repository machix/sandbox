using ETTTimeTracker.Common;
using ETTTimeTracker.Models;
using ETTTimeTracker.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;
using System.Windows.Controls;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TimerWidget.xaml
    /// </summary>
    public partial class TimerWidget : UserControl
    {
        public event EventHandler SwitchToWidget;
        private ETTViewModel _viewModel;

        private ObservableCollection<JobTitle> _jobs = new ObservableCollection<JobTitle>();

        #region Dependency Properties

        #region Mode

        /// <summary>
        /// Mode Dependency Property
        /// </summary>
        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(TimerWidgetMode), typeof(TimerWidget),
                new PropertyMetadata(TimerWidgetMode.Maximized, OnModeChanged));

        /// <summary>
        /// Gets or sets the Mode property. This dependency property 
        /// indicates the Timer Widget mode.
        /// </summary>
        public TimerWidgetMode Mode
        {
            get => (TimerWidgetMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty, value);
        }

        /// <summary>
        /// Handles changes to the Mode property.
        /// </summary>
        /// <param name="d">TimerWidget</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var widget = (TimerWidget)d;
            var newMode = widget.Mode;
            widget.OnModeChanged(newMode);
        }

        /// <summary>
        /// Provides the class instance an opportunity to handle changes to the Mode property.
        /// </summary>
        /// <param name="newMode">New Value</param>
        private void OnModeChanged(TimerWidgetMode newMode)
        {
            switch (newMode)
            {
                case TimerWidgetMode.Maximized:
                    FolderButton.Visibility = Visibility.Visible;
                    NotesButton.Visibility = Visibility.Visible;
                    SelectionPanel.Visibility = Visibility.Visible;
                    SwitchToWidgetButton.Visibility = Visibility.Visible;
                    break;
                case TimerWidgetMode.Widget:
                    FolderButton.Visibility = Visibility.Collapsed;
                    NotesButton.Visibility = Visibility.Collapsed;
                    SelectionPanel.Visibility = Visibility.Visible;
                    SwitchToWidgetButton.Visibility = Visibility.Collapsed;
                    break;
                case TimerWidgetMode.Mini:
                    FolderButton.Visibility = Visibility.Collapsed;
                    NotesButton.Visibility = Visibility.Collapsed;
                    SelectionPanel.Visibility = Visibility.Collapsed;
                    SwitchToWidgetButton.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #endregion

        static TimerWidget()
        {
            // Override default style
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(TimerWidget), new FrameworkPropertyMetadata(typeof(TimerWidget)));
        }

        public TimerWidget()
        {
            InitializeComponent();
        }

        public void Initialize(ETTViewModel viewModel)
        {
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void OnStartTimer(object sender, RoutedEventArgs e)
        {
            _viewModel.ActivateTask();
        }

        private void OnPauseTimer(object sender, RoutedEventArgs e)
        {
            _viewModel.ActiveTask?.PauseTimer();
        }

        private void OnAutoTimerChecked(object sender, RoutedEventArgs e)
        {
            ManualPanel.Visibility = Visibility.Collapsed;
            TimerPanel.Visibility = Visibility.Visible;
        }

        private void OnManualTimerChecked(object sender, RoutedEventArgs e)
        {
            TimerPanel.Visibility = Visibility.Collapsed;
            ManualPanel.Visibility = Visibility.Visible;
        }

        private void OnManualTimeEntered(object sender, RoutedEventArgs e)
        {
            _viewModel.ActivateTask(false);
            MessageBox.Show("Manual Time Entry Saved.", "ETT Time Tracker");
            AutoTimerButton.IsChecked = true;
        }

        private void OnSwitchToWidget(object sender, RoutedEventArgs e)
        {
            SwitchToWidget?.Invoke(this, null);
        }

        private void OnFolderClick(object sender, RoutedEventArgs e)
        {
            if (!CostCenterPopup.IsOpen)
            {
                CostCenterPopup.IsOpen = true;
            }
        }

        private void OnJoblistSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CostCenterPopup.IsOpen = false;
            _viewModel.ActiveTask.Name = _viewModel.SelectedJobTitle.Name;
            _viewModel.ActiveTask.AFE = _viewModel.SelectedJobTitle.CostCenter;
        }

        private void OnSaveNotes(object sender, RoutedEventArgs e)
        {
            NotesPopup.IsOpen = false;
            _viewModel.ActiveTask.Notes = NotesText.Text;
        }

        private void OnCancelNotes(object sender, RoutedEventArgs e)
        {
            NotesPopup.IsOpen = false;
        }

        private void OnShowNotes(object sender, RoutedEventArgs e)
        {
            NotesPopup.IsOpen = true;
        }
    }
}
