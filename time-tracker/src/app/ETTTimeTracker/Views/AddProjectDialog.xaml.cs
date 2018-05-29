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
    /// Interaction logic for AddProjectDialog.xaml
    /// </summary>
    public partial class AddProjectDialog : CustomDialog
    {
        public AddProjectDialog()
        {
            InitializeComponent();
            NamesCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.Name).ToList();
            SearchableCombo.ItemsSource = JobHelper.JobTitles.Select(a => a.AFE).ToList();

            Loaded += OnDialogLoaded;
        }

        private void OnDialogLoaded(object sender, RoutedEventArgs e)
        {
            NamesCombo.SelectedIndex = 0;
            SearchableCombo.SelectedIndex = 0;
        }

        public void Initialize(JobTask task)
        {
            DataContext = task;
        }


        private void OnAdd(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
