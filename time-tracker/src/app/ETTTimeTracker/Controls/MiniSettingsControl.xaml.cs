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
    /// Interaction logic for MiniSettingsControl.xaml
    /// </summary>
    public partial class MiniSettingsControl : UserControl
    {
        public event SettingsEventHandler Close;

        public MiniSettingsControl()
        {
            InitializeComponent();
        }

        public void Initialize(SettingsViewModel settingsViewModel)
        {
            DataContext = settingsViewModel;
        }

        private void OnClearCache(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Local Cache cleared.", "ETT Time Tracker");
        }

        private void OnDiscardChanges(object sender, RoutedEventArgs e)
        {
            Close?.Invoke(this, new SettingsEventArgs(false));
        }

        private void OnSaveChanges(object sender, RoutedEventArgs e)
        {
            Close?.Invoke(this, new SettingsEventArgs());
            MessageBox.Show("Settings changed.", "ETT Time Tracker");
        }
    }
}
