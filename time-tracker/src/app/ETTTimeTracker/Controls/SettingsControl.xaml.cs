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
using ETTTimeTracker.ViewModels;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public event SettingsEventHandler UpdateSettings;

        public SettingsControl()
        {
            InitializeComponent();
        }

        public void Initialize(SettingsViewModel viewModel)
        {
            this.DataContext = viewModel;
        }

        private void OnEditCostCenter(object sender, RoutedEventArgs e)
        {
            CostCenterText.Visibility = Visibility.Collapsed;
            EditButton.Visibility = Visibility.Collapsed;
            CostCenterTextBox.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void OnSaveCostCenter(object sender, RoutedEventArgs e)
        {
            CostCenterTextBox.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Collapsed;
            CostCenterText.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Visible;
        }

        private void OnDiscardChanges(object sender, RoutedEventArgs e)
        {
            UpdateSettings?.Invoke(this, new SettingsEventArgs(false));
            MessageBox.Show("Changes discarded.", "ETT Time Tracker");
        }

        private void OnSaveChanges(object sender, RoutedEventArgs e)
        {
            UpdateSettings?.Invoke(this, new SettingsEventArgs());
            MessageBox.Show("Changes saved successfully.", "ETT Time Tracker");
        }
    }
}
