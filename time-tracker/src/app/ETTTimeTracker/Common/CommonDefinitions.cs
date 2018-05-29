using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ETTTimeTracker.Common
{
    /// <summary>
    /// Defines the various modes of the CustomWindow.
    /// </summary>
    public enum WindowMode
    {
        // Maximized
        Maximized,
        // Widget sized
        Widget,
        // Mini sized
        Mini
    }

    /// <summary>
    /// Defines the various modes of the TimerWidget
    /// </summary>
    public enum TimerWidgetMode
    {
        Maximized,
        Widget,
        Mini
    }

    public delegate void SettingsEventHandler(UIElement sender, SettingsEventArgs args);

    public static class Constants
    {
        public const string AM = "AM";
        public const string PM = "PM";
    }
}
