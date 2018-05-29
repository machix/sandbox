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

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Interaction logic for TimeSpanControl.xaml
    /// </summary>
    public partial class TimeSpanControl : UserControl
    {
        public enum TimeSpanMode
        {
            Format12Hr,
            Format24Hr
        }

        private enum SelectionType
        {
            None,
            Hour,
            Minute,
            AmPm
        }

        private SelectionType _selection;

        #region Mode

        /// <summary>
        /// Mode Dependency Property
        /// </summary>
        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(TimeSpanMode), typeof(TimeSpanControl),
                new PropertyMetadata(TimeSpanMode.Format24Hr, OnModeChanged));

        /// <summary>
        /// Gets or sets the Mode property. This dependency property 
        /// indicates the time format.
        /// </summary>
        public TimeSpanMode Mode
        {
            get => (TimeSpanMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty, value);
        }

        /// <summary>
        /// Handles changes to the Mode property.
        /// </summary>
        /// <param name="d">TimeSpanControl</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TimeSpanControl)d;
            var newMode = control.Mode;
            control.OnModeChanged(newMode);
        }

        /// <summary>
        /// Provides the class instance an opportunity to handle changes to the Mode property.
        /// </summary>
        /// <param name="newMode">New Value</param>
        private void OnModeChanged(TimeSpanMode newMode)
        {
            switch (newMode)
            {
                case TimeSpanMode.Format12Hr:
                    MinWidth = 88;
                    Width = 88;
                    AmPmGrid.Visibility = Visibility.Visible;
                    Hours = 12;
                    Minutes = 0;
                    AmPm = "AM";
                    break;
                case TimeSpanMode.Format24Hr:
                    MinWidth = 64;
                    Width = 64;
                    AmPmGrid.Visibility = Visibility.Collapsed;
                    Value = new TimeSpan(0, 0, 0);
                    Hours = 0;
                    Minutes = 0;
                    break;
            }

            MinHeight = 30;
            Height = 30;
        }

        #endregion

        #region Hours

        /// <summary>
        /// Hours Dependency Property
        /// </summary>
        public static readonly DependencyProperty HoursProperty =
            DependencyProperty.Register("Hours", typeof(int), typeof(TimeSpanControl),
                new FrameworkPropertyMetadata(0, OnHoursChanged, CoerceHours));

        /// <summary>
        /// Gets or sets the Hours property. This dependency property 
        /// indicates the hours.
        /// </summary>
        public int Hours
        {
            get => (int)GetValue(HoursProperty);
            set => SetValue(HoursProperty, value);
        }

        /// <summary>
        /// Handles changes to the Hours property.
        /// </summary>
        private static void OnHoursChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TimeSpanControl)d;
            var oldHours = (int)e.OldValue;
            var newHours = control.Hours;
            control.OnHoursChanged(oldHours, newHours);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the Hours property.
        /// </summary>
        protected void OnHoursChanged(int oldHours, int newHours)
        {
            UpdateValue();
        }

        /// <summary>
        /// Coerces the Hours value.
        /// </summary>
        private static object CoerceHours(DependencyObject d, object value)
        {
            var control = (TimeSpanControl)d;
            var desiredHours = (int)value;

            switch (control.Mode)
            {
                case TimeSpanMode.Format12Hr:
                    if (desiredHours < 1)
                    {
                        desiredHours = 12;
                    }
                    else if (desiredHours > 12)
                    {
                        desiredHours = 1;
                    }
                    break;
                case TimeSpanMode.Format24Hr:
                    if (desiredHours < 0)
                    {
                        desiredHours = 23;
                    }
                    else if (desiredHours > 23)
                    {
                        desiredHours = 0;
                    }
                    break;
            }

            return desiredHours;
        }

        #endregion

        #region Minutes

        /// <summary>
        /// Minutes Dependency Property
        /// </summary>
        public static readonly DependencyProperty MinutesProperty =
            DependencyProperty.Register("Minutes", typeof(int), typeof(TimeSpanControl),
                new FrameworkPropertyMetadata(0, OnMinutesChanged, CoerceMinutes));

        /// <summary>
        /// Gets or sets the Minutes property. This dependency property 
        /// indicates the minutes.
        /// </summary>
        public int Minutes
        {
            get => (int)GetValue(MinutesProperty);
            set => SetValue(MinutesProperty, value);
        }

        /// <summary>
        /// Handles changes to the Minutes property.
        /// </summary>
        private static void OnMinutesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TimeSpanControl)d;
            var oldMinutes = (int)e.OldValue;
            var newMinutes = control.Minutes;
            control.OnMinutesChanged(oldMinutes, newMinutes);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the Minutes property.
        /// </summary>
        protected void OnMinutesChanged(int oldMinutes, int newMinutes)
        {
            UpdateValue();
        }

        /// <summary>
        /// Coerces the Minutes value.
        /// </summary>
        private static object CoerceMinutes(DependencyObject d, object value)
        {
            var control = (TimeSpanControl)d;
            var desiredMinutes = (int)value;

            if (desiredMinutes < 0)
            {
                desiredMinutes = 59;
            }
            else if (desiredMinutes > 59)
            {
                desiredMinutes = 0;
            }

            return desiredMinutes;
        }

        #endregion

        #region AmPm

        /// <summary>
        /// AmPm Dependency Property
        /// </summary>
        public static readonly DependencyProperty AmPmProperty =
            DependencyProperty.Register("AmPm", typeof(string), typeof(TimeSpanControl),
                new FrameworkPropertyMetadata(Constants.AM, OnAmPmChanged, CoerceAmPm));

        /// <summary>
        /// Gets or sets the AmPm property. This dependency property 
        /// indicates whether the time is AM or PM.
        /// </summary>
        public string AmPm
        {
            get => (string)GetValue(AmPmProperty);
            set => SetValue(AmPmProperty, value);
        }

        /// <summary>
        /// Handles changes to the AmPm property.
        /// </summary>
        private static void OnAmPmChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TimeSpanControl)d;
            var oldAmPm = (string)e.OldValue;
            var newAmPm = control.AmPm;
            control.OnAmPmChanged(oldAmPm, newAmPm);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the AmPm property.
        /// </summary>
        protected void OnAmPmChanged(string oldAmPm, string newAmPm)
        {
        }

        /// <summary>
        /// Coerces the AmPm value.
        /// </summary>
        private static object CoerceAmPm(DependencyObject d, object value)
        {
            var control = (TimeSpanControl)d;
            var desiredAmPm = ((string)value).ToUpper();

            var result = Constants.AM;
            switch (desiredAmPm)
            {
                case Constants.AM:
                    result = Constants.AM;
                    break;
                case Constants.PM:
                    result = Constants.PM;
                    break;
            }

            return result;
        }

        #endregion

        #region Value

        /// <summary>
        /// Value Dependency Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(TimeSpan), typeof(TimeSpanControl),
                new PropertyMetadata(TimeSpan.Zero, OnValueChanged));

        /// <summary>
        /// Gets or sets the Value property. This dependency property 
        /// indicates the value.
        /// </summary>
        public TimeSpan Value
        {
            get => (TimeSpan)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        /// Handles changes to the Value property.
        /// </summary>
        /// <param name="d">TimeSpanControl</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TimeSpanControl)d;
            var newValue = control.Value;
            control.OnValueChanged(newValue);
        }

        /// <summary>
        /// Provides the class instance an opportunity to handle changes to the Value property.
        /// </summary>
        /// <param name="newValue">New Value</param>
        private void OnValueChanged(TimeSpan newValue)
        {
            switch (Mode)
            {
                case TimeSpanMode.Format12Hr:
                    var hours = newValue.Hours;
                    if (hours == 0)
                    {
                        Hours = 12;
                        AmPm = Constants.AM;
                    }
                    else if (hours == 12)
                    {
                        Hours = hours;
                        AmPm = Constants.PM;
                    }
                    else if (hours > 12)
                    {
                        Hours = hours - 12;
                        AmPm = Constants.PM;
                    }
                    else
                    {
                        Hours = hours;
                        AmPm = Constants.AM;
                    }
                    break;
                case TimeSpanMode.Format24Hr:
                    Hours = newValue.Hours;
                    break;
            }

            Minutes = newValue.Minutes;

        }

        #endregion

        public TimeSpanControl()
        {
            InitializeComponent();
            _selection = SelectionType.Minute;
            MinHeight = 30;
            Height = 30;
            Value = new TimeSpan(0,0,0);
            this.LostFocus += TimeSpanControl_LostFocus;
        }

        private void TimeSpanControl_LostFocus(object sender, RoutedEventArgs e)
        {
            ResetFocus();
        }

        private void OnDecreaseValue(object sender, RoutedEventArgs e)
        {
            switch (_selection)
            {
                case SelectionType.Hour:
                    Hours--;
                    ResetFocus();
                    HourFocus.Opacity = 1;
                    HourText.Foreground = Brushes.White;
                    break;
                case SelectionType.Minute:
                    Minutes--;
                    ResetFocus();
                    MinuteFocus.Opacity = 1;
                    MinuteText.Foreground = Brushes.White;
                    break;
                case SelectionType.AmPm:
                    SwitchAmPm();
                    ResetFocus();
                    AmPmFocus.Opacity = 1;
                    AmPmText.Foreground = Brushes.White;
                    break;
                case SelectionType.None:
                default:
                    break;
            }
        }

        private void OnIncreaseValue(object sender, RoutedEventArgs e)
        {
            switch (_selection)
            {
                case SelectionType.Hour:
                    Hours++;
                    ResetFocus();
                    HourFocus.Opacity = 1;
                    HourText.Foreground = Brushes.White;
                    break;
                case SelectionType.Minute:
                    Minutes++;
                    ResetFocus();
                    MinuteFocus.Opacity = 1;
                    MinuteText.Foreground = Brushes.White;
                    break;
                case SelectionType.AmPm:
                    SwitchAmPm();
                    ResetFocus();
                    AmPmFocus.Opacity = 1;
                    AmPmText.Foreground = Brushes.White;
                    break;
                case SelectionType.None:
                default:
                    break;
            }
        }

        private void OnGotFocus(object sender, RoutedEventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "HourText":
                    _selection = SelectionType.Hour;
                    ResetFocus();
                    HourFocus.Opacity = 1;
                    HourText.Foreground = Brushes.White;
                    break;
                case "MinuteText":
                    _selection = SelectionType.Minute;
                    ResetFocus();
                    MinuteFocus.Opacity = 1;
                    MinuteText.Foreground = Brushes.White;
                    break;
                case "AmPmText":
                    _selection = SelectionType.AmPm;
                    ResetFocus();
                    AmPmFocus.Opacity = 1;
                    AmPmText.Foreground = Brushes.White;
                    break;
            }
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "HourText":
                    _selection = SelectionType.Hour;
                    ResetFocus();
                    HourFocus.Opacity = 1;
                    HourText.Foreground = Brushes.White;
                    break;
                case "MinuteText":
                    _selection = SelectionType.Minute;
                    ResetFocus();
                    MinuteFocus.Opacity = 1;
                    MinuteText.Foreground = Brushes.White;
                    break;
                case "AmPmText":
                    _selection = SelectionType.AmPm;
                    ResetFocus();
                    AmPmFocus.Opacity = 1;
                    AmPmText.Foreground = Brushes.White;
                    break;
            }
        }

        private void OnLostFocus(object sender, RoutedEventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "HourText":
                case "MinuteText":
                case "AmPmText":
                    //ResetFocus();
                    //_selection = SelectionType.None;
                    break;
            }
        }

        private void UpdateValue()
        {
            var hours = Hours;

            if (Mode == TimeSpanMode.Format12Hr)
            {
                if ((hours == 12) && (AmPm == Constants.AM))
                {
                    hours = 0;
                }
                else if ((hours < 12) && (AmPm == Constants.PM))
                {
                    hours += 12;
                }
            }

            Value = TimeSpan.FromMinutes(hours * 60 + Minutes);
        }

        private void ResetFocus()
        {
            HourFocus.Opacity = 0;
            HourText.Foreground = Brushes.Black;
            MinuteFocus.Opacity = 0;
            MinuteText.Foreground = Brushes.Black;
            AmPmFocus.Opacity = 0;
            AmPmText.Foreground = Brushes.Black;
        }

        private void SwitchAmPm()
        {
            AmPm = AmPm == Constants.AM ? Constants.PM : Constants.AM;
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs args)
        {
            switch (((TextBox)sender).Name)
            {
                case "HourText":
                    switch (args.Key)
                    {
                        case Key.Up:
                            HourText.Focus();
                            Hours++;
                            break;
                        case Key.Down:
                            HourText.Focus();
                            Hours--;
                            break;
                        case Key.Left:
                            break;
                        case Key.Right:
                            MinuteText.Focus();
                            break;
                    }
                    break;

                case "MinuteText":
                    switch (args.Key)
                    {
                        case Key.Up:
                            MinuteText.Focus();
                            Minutes++;
                            break;
                        case Key.Down:
                            MinuteText.Focus();
                            Minutes--;
                            break;
                        case Key.Left:
                            HourText.Focus();
                            break;
                        case Key.Right:
                            AmPmText.Focus();
                            break;
                    }
                    break;

                case "AmPmText":
                    switch (args.Key)
                    {
                        case Key.Up:
                        case Key.Down:
                            AmPmText.Focus();
                            SwitchAmPm();
                            break;
                        case Key.Left:
                            MinuteText.Focus();
                            break;
                        case Key.Right:
                            break;
                    }
                    break;
            }
        }
    }
}
