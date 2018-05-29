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

namespace ETTTimeTracker.Views
{
    /// <summary>
    /// Interaction logic for CopyEntriesDialog.xaml
    /// </summary>
    public partial class CopyEntriesDialog : CustomDialog
    {
        public CopyEntriesDialog()
        {
            InitializeComponent();

            CopyList.ItemsSource = JobHelper.CopyEntries;
        }

        private void OnCopyEntries(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
