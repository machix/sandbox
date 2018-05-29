using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for SearchableComboBox.xaml
    /// </summary>
    public partial class SearchableComboBox : UserControl
    {
        public static readonly RoutedEvent SelectionChangedEvent = EventManager.RegisterRoutedEvent("SelectionChanged", 
            RoutingStrategy.Bubble, typeof(SelectionChangedEventHandler), typeof(SearchableComboBox));

        /// <summary>
        /// Occurs when the selected item in the drop-down portion of the
        /// <see cref="T:System.Windows.Controls.AutoCompleteBox" /> has
        /// changed.
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged
        {
            add => AddHandler(SelectionChangedEvent, value);
            remove => RemoveHandler(SelectionChangedEvent, value);
        }

        #region FilterMode

        /// <summary>
        /// FilterMode Dependency Property
        /// </summary>
        public static readonly DependencyProperty FilterModeProperty =
            DependencyProperty.Register("FilterMode", typeof(AutoCompleteFilterMode), typeof(SearchableComboBox),
                new PropertyMetadata(AutoCompleteFilterMode.StartsWith, OnFilterModeChanged));

        /// <summary>
        /// Gets or sets the FilterMode property. This dependency property 
        /// indicates the filtering mode.
        /// </summary>
        public AutoCompleteFilterMode FilterMode
        {
            get => (AutoCompleteFilterMode)GetValue(FilterModeProperty);
            set => SetValue(FilterModeProperty, value);
        }

        /// <summary>
        /// Handles changes to the FilterMode property.
        /// </summary>
        /// <param name="d">SearchableComboBox</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnFilterModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = (SearchableComboBox)d;
            var newFilterMode = comboBox.FilterMode;
            comboBox.OnFilterModeChanged(newFilterMode);
        }

        /// <summary>
        /// Provides the class instance an opportunity to handle changes to the FilterMode property.
        /// </summary>
        /// <param name="newFilterMode">New Value</param>
        private void OnFilterModeChanged(AutoCompleteFilterMode newFilterMode)
        {
            AutoBox.FilterMode = newFilterMode;
        }

        #endregion

        #region ItemsSource

        /// <summary>
        /// ItemsSource Dependency Property
        /// </summary>
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(SearchableComboBox),
                new PropertyMetadata(null, OnItemsSourceChanged));

        /// <summary>
        /// Gets or sets the ItemsSource property. This dependency property 
        /// indicates the ItemsSource.
        /// </summary>
        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /// <summary>
        /// Handles changes to the ItemsSource property.
        /// </summary>
        /// <param name="d">SearchableComboBox</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = (SearchableComboBox)d;
            var newItemsSource = comboBox.ItemsSource;
            comboBox.OnItemsSourceChanged(newItemsSource);
        }

        /// <summary>
        /// Provides the class instance an opportunity to handle changes to the ItemsSource property.
        /// </summary>
        /// <param name="newItemsSource">New Value</param>
        private void OnItemsSourceChanged(IEnumerable newItemsSource)
        {
            AutoBox.ItemsSource = newItemsSource;
        }

        #endregion


        #region SelectedItem

        /// <summary>
        /// SelectedItem Dependency Property
        /// </summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(SearchableComboBox),
                new PropertyMetadata());

        /// <summary>
        /// Gets or sets the SelectedItem property. This dependency property 
        /// indicates the selected item.
        /// </summary>
        public object SelectedItem
        {
            get => (object)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        #endregion

        public SearchableComboBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Toggle the drop down for the control, part of the custom template.
        /// </summary>
        /// <param name="sender">The source object.</param>
        /// <param name="e">The event arguments.</param>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Wired up in markup.")]
        private void DropDownToggle_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            AutoCompleteBox acb = null;
            while (fe != null && acb == null)
            {
                fe = VisualTreeHelper.GetParent(fe) as FrameworkElement;
                acb = fe as AutoCompleteBox;
            }
            if (acb != null)
            {
                if (string.IsNullOrEmpty(acb.SearchText))
                {
                    acb.Text = string.Empty;
                }
                acb.IsDropDownOpen = !acb.IsDropDownOpen;
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RaiseEvent(e);
        }
    }
}
