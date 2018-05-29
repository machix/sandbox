﻿using System;
using ETTTimeTracker.Common;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ETTTimeTracker.Controls
{
    /// <summary>
    /// Class which provides the implementation of a custom window
    /// </summary>
    [TemplatePart(Name = "PART_Minimize", Type = typeof(Button))]
    [TemplatePart(Name = "PART_Settings", Type = typeof(Button))]
    [TemplatePart(Name = "PART_Widget", Type = typeof(Button))]
    [TemplatePart(Name = "PART_Close", Type = typeof(Button))]
    [TemplatePart(Name = "PART_Title", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_TitleBar", Type = typeof(Border))]
    public class CustomWindow : Window
    {
        #region Fields

        private Button _minimizeButton;
        private Button _settingsButton;
        private Button _widgetButton;
        private Button _closeButton;
        private Border _titleBar;
        private TextBlock _title;

        #endregion

        #region Properties

        public Button SettingsButton => _settingsButton;

        #endregion

        #region Dependency Properties

        #region WindowFrameMode

        /// <summary>
        /// WindowFrameMode Dependency Property
        /// </summary>
        public static readonly DependencyProperty WindowFrameModeProperty =
            DependencyProperty.Register("WindowFrameMode", typeof(WindowMode), typeof(CustomWindow),
                new FrameworkPropertyMetadata(WindowMode.Maximized, OnWindowFrameModeChanged));

        /// <summary>
        /// Gets or sets the WindowFrameMode property. This dependency property 
        /// indicates the mode of the window frame.
        /// </summary>
        public WindowMode WindowFrameMode
        {
            get { return (WindowMode)GetValue(WindowFrameModeProperty); }
            set { SetValue(WindowFrameModeProperty, value); }
        }

        /// <summary>
        /// Handles changes to the WindowFrameMode property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnWindowFrameModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            WindowMode oldWindowFrameMode = (WindowMode)e.OldValue;
            WindowMode newWindowFrameMode = win.WindowFrameMode;
            win.OnWindowFrameModeChanged(oldWindowFrameMode, newWindowFrameMode);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the WindowFrameMode property.
        /// </summary>
        /// <param name="oldWindowFrameMode">Old Value</param>
        /// <param name="newWindowFrameMode">New Value</param>
        protected void OnWindowFrameModeChanged(WindowMode oldWindowFrameMode, WindowMode newWindowFrameMode)
        {
            UpdateWindowFrame(newWindowFrameMode);
        }

        #endregion

        #region SystemBorderBrush

        /// <summary>
        /// SystemBorderBrush Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemBorderBrushProperty =
            DependencyProperty.Register("SystemBorderBrush", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemBorderBrushChanged));

        /// <summary>
        /// Gets or sets the SystemBorderBrush property. This dependency property 
        /// indicates the color of the border of the system buttons.
        /// </summary>
        public Brush SystemBorderBrush
        {
            get { return (Brush)GetValue(SystemBorderBrushProperty); }
            set { SetValue(SystemBorderBrushProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemBorderBrush property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemBorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemBorderBrush = (Brush)e.OldValue;
            Brush newSystemBorderBrush = win.SystemBorderBrush;
            win.OnSystemBorderBrushChanged(oldSystemBorderBrush, newSystemBorderBrush);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemBorderBrush property.
        /// </summary>
        /// <param name="oldSystemBorderBrush">Old Value</param>
        /// <param name="newSystemBorderBrush">New Value</param>
        void OnSystemBorderBrushChanged(Brush oldSystemBorderBrush, Brush newSystemBorderBrush)
        {

        }

        #endregion

        #region SystemBorderThickness

        /// <summary>
        /// SystemBorderThickness Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemBorderThicknessProperty =
            DependencyProperty.Register("SystemBorderThickness", typeof(Thickness), typeof(CustomWindow),
                new PropertyMetadata(new Thickness(0.5), OnSystemBorderThicknessChanged));

        /// <summary>
        /// Gets or sets the SystemBorderThickness property. This dependency property 
        /// indicates the thickness of the border of the System buttons.
        /// </summary>
        public Thickness SystemBorderThickness
        {
            get { return (Thickness)GetValue(SystemBorderThicknessProperty); }
            set { SetValue(SystemBorderThicknessProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemBorderThickness property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Thickness oldSystemBorderThickness = (Thickness)e.OldValue;
            Thickness newSystemBorderThickness = win.SystemBorderThickness;
            win.OnSystemBorderThicknessChanged(oldSystemBorderThickness, newSystemBorderThickness);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemBorderThickness property.
        /// </summary>
        /// <param name="oldSystemBorderThickness">Old Value</param>
        /// <param name="newSystemBorderThickness">New Value</param>
        void OnSystemBorderThicknessChanged(Thickness oldSystemBorderThickness, Thickness newSystemBorderThickness)
        {

        }

        #endregion

        #region SystemForeground

        /// <summary>
        /// SystemForeground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemForegroundProperty =
            DependencyProperty.Register("SystemForeground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemForegroundChanged));

        /// <summary>
        /// Gets or sets the SystemForeground property. This dependency property 
        /// indicates the foreground of the content of the system buttons.
        /// </summary>
        public Brush SystemForeground
        {
            get { return (Brush)GetValue(SystemForegroundProperty); }
            set { SetValue(SystemForegroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemForeground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemForeground = (Brush)e.OldValue;
            Brush newSystemForeground = win.SystemForeground;
            win.OnSystemForegroundChanged(oldSystemForeground, newSystemForeground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemForeground property.
        /// </summary>
        /// <param name="oldSystemForeground">Old Value</param>
        /// <param name="newSystemForeground">New Value</param>
        void OnSystemForegroundChanged(Brush oldSystemForeground, Brush newSystemForeground)
        {

        }

        #endregion

        #region SystemBackground

        /// <summary>
        /// SystemBackground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemBackgroundProperty =
            DependencyProperty.Register("SystemBackground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemBackgroundChanged));

        /// <summary>
        /// Gets or sets the SystemBackground property. This dependency property 
        /// indicates the background of the content of the system buttons.
        /// </summary>
        public Brush SystemBackground
        {
            get { return (Brush)GetValue(SystemBackgroundProperty); }
            set { SetValue(SystemBackgroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemBackground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemBackground = (Brush)e.OldValue;
            Brush newSystemBackground = win.SystemBackground;
            win.OnSystemBackgroundChanged(oldSystemBackground, newSystemBackground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemBackground property.
        /// </summary>
        /// <param name="oldSystemBackground">Old Value</param>
        /// <param name="newSystemBackground">New Value</param>
        void OnSystemBackgroundChanged(Brush oldSystemBackground, Brush newSystemBackground)
        {

        }

        #endregion

        #region SystemMouseOverBorderBrush

        /// <summary>
        /// SystemMouseOverBorderBrush Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemMouseOverBorderBrushProperty =
            DependencyProperty.Register("SystemMouseOverBorderBrush", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemMouseOverBorderBrushChanged));

        /// <summary>
        /// Gets or sets the SystemMouseOverBorderBrush property. This dependency property 
        /// indicates the color of the border of the system buttons.
        /// </summary>
        public Brush SystemMouseOverBorderBrush
        {
            get { return (Brush)GetValue(SystemMouseOverBorderBrushProperty); }
            set { SetValue(SystemMouseOverBorderBrushProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemMouseOverBorderBrush property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemMouseOverBorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemMouseOverBorderBrush = (Brush)e.OldValue;
            Brush newSystemMouseOverBorderBrush = win.SystemMouseOverBorderBrush;
            win.OnSystemMouseOverBorderBrushChanged(oldSystemMouseOverBorderBrush, newSystemMouseOverBorderBrush);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemMouseOverBorderBrush property.
        /// </summary>
        /// <param name="oldSystemMouseOverBorderBrush">Old Value</param>
        /// <param name="newSystemMouseOverBorderBrush">New Value</param>
        void OnSystemMouseOverBorderBrushChanged(Brush oldSystemMouseOverBorderBrush, Brush newSystemMouseOverBorderBrush)
        {

        }

        #endregion

        #region SystemMouseOverForeground

        /// <summary>
        /// SystemMouseOverForeground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemMouseOverForegroundProperty =
            DependencyProperty.Register("SystemMouseOverForeground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemMouseOverForegroundChanged));

        /// <summary>
        /// Gets or sets the SystemMouseOverForeground property. This dependency property 
        /// indicates the foreground of the content of the system buttons.
        /// </summary>
        public Brush SystemMouseOverForeground
        {
            get { return (Brush)GetValue(SystemMouseOverForegroundProperty); }
            set { SetValue(SystemMouseOverForegroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemMouseOverForeground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemMouseOverForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemMouseOverForeground = (Brush)e.OldValue;
            Brush newSystemMouseOverForeground = win.SystemMouseOverForeground;
            win.OnSystemMouseOverForegroundChanged(oldSystemMouseOverForeground, newSystemMouseOverForeground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemMouseOverForeground property.
        /// </summary>
        /// <param name="oldSystemMouseOverForeground">Old Value</param>
        /// <param name="newSystemMouseOverForeground">New Value</param>
        void OnSystemMouseOverForegroundChanged(Brush oldSystemMouseOverForeground, Brush newSystemMouseOverForeground)
        {

        }

        #endregion

        #region SystemMouseOverBackground

        /// <summary>
        /// SystemMouseOverBackground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemMouseOverBackgroundProperty =
            DependencyProperty.Register("SystemMouseOverBackground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemMouseOverBackgroundChanged));

        /// <summary>
        /// Gets or sets the SystemMouseOverBackground property. This dependency property 
        /// indicates the background of the content of the system buttons.
        /// </summary>
        public Brush SystemMouseOverBackground
        {
            get { return (Brush)GetValue(SystemMouseOverBackgroundProperty); }
            set { SetValue(SystemMouseOverBackgroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemMouseOverBackground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemMouseOverBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemMouseOverBackground = (Brush)e.OldValue;
            Brush newSystemMouseOverBackground = win.SystemMouseOverBackground;
            win.OnSystemMouseOverBackgroundChanged(oldSystemMouseOverBackground, newSystemMouseOverBackground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemMouseOverBackground property.
        /// </summary>
        /// <param name="oldSystemMouseOverBackground">Old Value</param>
        /// <param name="newSystemMouseOverBackground">New Value</param>
        void OnSystemMouseOverBackgroundChanged(Brush oldSystemMouseOverBackground, Brush newSystemMouseOverBackground)
        {

        }

        #endregion

        #region SystemPressedBorderBrush

        /// <summary>
        /// SystemPressedBorderBrush Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemPressedBorderBrushProperty =
            DependencyProperty.Register("SystemPressedBorderBrush", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemPressedBorderBrushChanged));

        /// <summary>
        /// Gets or sets the SystemPressedBorderBrush property. This dependency property 
        /// indicates the color of the border of the system buttons.
        /// </summary>
        public Brush SystemPressedBorderBrush
        {
            get { return (Brush)GetValue(SystemPressedBorderBrushProperty); }
            set { SetValue(SystemPressedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemPressedBorderBrush property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemPressedBorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemPressedBorderBrush = (Brush)e.OldValue;
            Brush newSystemPressedBorderBrush = win.SystemPressedBorderBrush;
            win.OnSystemPressedBorderBrushChanged(oldSystemPressedBorderBrush, newSystemPressedBorderBrush);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemPressedBorderBrush property.
        /// </summary>
        /// <param name="oldSystemPressedBorderBrush">Old Value</param>
        /// <param name="newSystemPressedBorderBrush">New Value</param>
        void OnSystemPressedBorderBrushChanged(Brush oldSystemPressedBorderBrush, Brush newSystemPressedBorderBrush)
        {

        }

        #endregion

        #region SystemPressedBorderThickness

        /// <summary>
        /// SystemPressedBorderThickness Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemPressedBorderThicknessProperty =
            DependencyProperty.Register("SystemPressedBorderThickness", typeof(Thickness), typeof(CustomWindow),
                new PropertyMetadata(new Thickness(0.5), OnSystemPressedBorderThicknessChanged));

        /// <summary>
        /// Gets or sets the SystemPressedBorderThickness property. This dependency property 
        /// indicates the thickness of the border of the System buttons.
        /// </summary>
        public Thickness SystemPressedBorderThickness
        {
            get { return (Thickness)GetValue(SystemPressedBorderThicknessProperty); }
            set { SetValue(SystemPressedBorderThicknessProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemPressedBorderThickness property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemPressedBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Thickness oldSystemPressedBorderThickness = (Thickness)e.OldValue;
            Thickness newSystemPressedBorderThickness = win.SystemPressedBorderThickness;
            win.OnSystemPressedBorderThicknessChanged(oldSystemPressedBorderThickness, newSystemPressedBorderThickness);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemPressedBorderThickness property.
        /// </summary>
        /// <param name="oldSystemPressedBorderThickness">Old Value</param>
        /// <param name="newSystemPressedBorderThickness">New Value</param>
        void OnSystemPressedBorderThicknessChanged(Thickness oldSystemPressedBorderThickness, Thickness newSystemPressedBorderThickness)
        {

        }

        #endregion

        #region SystemPressedForeground

        /// <summary>
        /// SystemPressedForeground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemPressedForegroundProperty =
            DependencyProperty.Register("SystemPressedForeground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemPressedForegroundChanged));

        /// <summary>
        /// Gets or sets the SystemPressedForeground property. This dependency property 
        /// indicates the foreground of the content of the system buttons.
        /// </summary>
        public Brush SystemPressedForeground
        {
            get { return (Brush)GetValue(SystemPressedForegroundProperty); }
            set { SetValue(SystemPressedForegroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemPressedForeground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemPressedForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemPressedForeground = (Brush)e.OldValue;
            Brush newSystemPressedForeground = win.SystemPressedForeground;
            win.OnSystemPressedForegroundChanged(oldSystemPressedForeground, newSystemPressedForeground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemPressedForeground property.
        /// </summary>
        /// <param name="oldSystemPressedForeground">Old Value</param>
        /// <param name="newSystemPressedForeground">New Value</param>
        void OnSystemPressedForegroundChanged(Brush oldSystemPressedForeground, Brush newSystemPressedForeground)
        {

        }

        #endregion

        #region SystemPressedBackground

        /// <summary>
        /// SystemPressedBackground Dependency Property
        /// </summary>
        public static readonly DependencyProperty SystemPressedBackgroundProperty =
            DependencyProperty.Register("SystemPressedBackground", typeof(Brush), typeof(CustomWindow),
                new PropertyMetadata(Brushes.White, OnSystemPressedBackgroundChanged));

        /// <summary>
        /// Gets or sets the SystemPressedBackground property. This dependency property 
        /// indicates the background of the content of the system buttons.
        /// </summary>
        public Brush SystemPressedBackground
        {
            get { return (Brush)GetValue(SystemPressedBackgroundProperty); }
            set { SetValue(SystemPressedBackgroundProperty, value); }
        }

        /// <summary>
        /// Handles changes to the SystemPressedBackground property.
        /// </summary>
        /// <param name="d">CustomWindow</param>
        /// <param name="e">DependencyProperty changed event arguments</param>
        private static void OnSystemPressedBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomWindow win = (CustomWindow)d;
            Brush oldSystemPressedBackground = (Brush)e.OldValue;
            Brush newSystemPressedBackground = win.SystemPressedBackground;
            win.OnSystemPressedBackgroundChanged(oldSystemPressedBackground, newSystemPressedBackground);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the SystemPressedBackground property.
        /// </summary>
        /// <param name="oldSystemPressedBackground">Old Value</param>
        /// <param name="newSystemPressedBackground">New Value</param>
        void OnSystemPressedBackgroundChanged(Brush oldSystemPressedBackground, Brush newSystemPressedBackground)
        {

        }

        #endregion

        #endregion

        #region Construction / Initialization

        /// <summary>
        /// Static ctor
        /// </summary>
        static CustomWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomWindow), new FrameworkPropertyMetadata(typeof(CustomWindow)));
        }

        public CustomWindow()
        {
            
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Override which is called when the template is applied
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // Detach previously attached event handlers, if any
            Unsubscribe();

            // Get all the controls in the template
            GetTemplateParts();
        }

        /// <summary>
        /// Handles the closing event
        /// </summary>
        /// <param name="e">CancelEventArgs</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (_minimizeButton != null)
                _minimizeButton.Click -= OnMinimize;

            if (_settingsButton != null)
                _settingsButton.Click -= OnMiniSettings;

            if (_widgetButton != null)
                _widgetButton.Click -= OnWidget;

            if (_closeButton != null)
                _closeButton.Click -= OnClose;

            if (_titleBar != null)
                _titleBar.MouseLeftButtonDown -= OnTitleBarMouseDown;

            base.OnClosing(e);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Detach previously attached event handlers, if any
        /// </summary>
        private void Unsubscribe()
        {
            // PART_Minimize
            if (_minimizeButton != null)
            {
                _minimizeButton.Click -= OnMinimize;
            }

            // PART_Settings
            if (_settingsButton != null)
            {
                _settingsButton.Click -= OnMiniSettings;
            }

            // PART_Widget
            if (_widgetButton != null)
            {
                _widgetButton.Click -= OnWidget;
            }

            // PART_Close
            if (_closeButton != null)
            {
                _closeButton.Click -= OnClose;
            }

            // PART_TitleBar
            if (_titleBar != null)
            {
                _titleBar.MouseLeftButtonDown -= OnTitleBarMouseDown;
            }
        }

        /// <summary>
        /// Gets the required controls in the template
        /// </summary>
        protected void GetTemplateParts()
        {
            // PART_Minimize
            _minimizeButton = GetChildControl<Button>("PART_Minimize");
            if (_minimizeButton != null)
            {
                _minimizeButton.Click += OnMinimize;
            }

            // PART_Settings
            _settingsButton = GetChildControl<Button>("PART_Settings");
            if (_settingsButton != null)
            {
                _settingsButton.Click += OnMiniSettings;
            }

            // PART_Widget
            _widgetButton = GetChildControl<Button>("PART_Widget");
            if (_widgetButton != null)
            {
                _widgetButton.Click += OnWidget;
            }

            // PART_Close
            _closeButton = GetChildControl<Button>("PART_Close");
            if (_closeButton != null)
            {
                _closeButton.Click += OnClose;
            }

            // PART_TitleBar
            _titleBar = GetChildControl<Border>("PART_TitleBar");
            if (_titleBar != null)
            {
                _titleBar.MouseLeftButtonDown += OnTitleBarMouseDown;
            }

            // PART_Title
            _title = GetChildControl<TextBlock>("PART_Title");

            // Update the system control buttons in the window frame
            UpdateWindowFrame(WindowFrameMode);
        }

        /// <summary>
        /// Update the system control buttons in the window frame
        /// </summary>
        /// <param name="winMode">Window mode</param>
        private void UpdateWindowFrame(WindowMode winMode)
        {
            switch (winMode)
            {
                case WindowMode.Maximized:
                    SystemCommands.MaximizeWindow(this);
                    //WindowState = WindowState.Maximized;
                    MinWidth = 1280;
                    MinHeight = 960;
                    if (_title != null)
                    {
                        _title.HorizontalAlignment = HorizontalAlignment.Center;
                        _title.Margin = new Thickness();
                    }
                    break;
                case WindowMode.Widget:
                    MinWidth = 960;
                    MinHeight = 600;
                    Width = 960;
                    Height = 600;
                    if (_title != null)
                    {
                        _title.HorizontalAlignment = HorizontalAlignment.Left;
                        _title.Margin = new Thickness(5, 0, 5, 0);
                    }
                    break;
                case WindowMode.Mini:
                    MinWidth = 500;
                    MinHeight = 80;
                    Width = 500;
                    Height = 80;
                    if (_title != null)
                    {
                        _title.HorizontalAlignment = HorizontalAlignment.Left;
                        _title.Margin = new Thickness(5, 0, 5, 0);
                    }
                    break;
            }
        }

        /// <summary>
        /// Generic method to get a control from the template
        /// </summary>
        /// <typeparam name="T">Type of the control</typeparam>
        /// <param name="ctrlName">Name of the control in the template</param>
        /// <returns>Control</returns>
        protected T GetChildControl<T>(string ctrlName) where T : DependencyObject
        {
            var ctrl = GetTemplateChild(ctrlName) as T;
            return ctrl;
        }

        #endregion

        //#region DLLImports

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 msg, IntPtr wParam, IntPtr lParam);

        //#endregion

        #region Event Handlers

        /// <summary>
        /// Handles the MouseDown event on the title bar.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">MouseButtonEventArgs</param>
        void OnTitleBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// <summary>
        /// Overridable event handler for the event raised when Minimize button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">RoutedEventArgs</param>
        protected virtual void OnMinimize(object sender, RoutedEventArgs e)
        {
            switch (WindowFrameMode)
            {
                case WindowMode.Maximized:
                    SystemCommands.MinimizeWindow(this);
                    break;
                case WindowMode.Widget:
                    WindowFrameMode = WindowMode.Mini;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Overridable event handler for the event raised when Settings button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">RoutedEventArgs</param>

        protected virtual void OnMiniSettings(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Overridable event handler for the event raised when Restore button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">RoutedEventArgs</param>
        protected virtual void OnWidget(object sender, RoutedEventArgs e)
        {
            WindowFrameMode = WindowMode.Widget;
        }

        /// <summary>
        /// Overridable event handler for the event raised when Close button is clicked
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">RoutedEventArgs</param>
        protected virtual void OnClose(object sender, RoutedEventArgs e)
        {
            if (WindowFrameMode == WindowMode.Maximized)
            {
                // Unsubscribe to the events
                Unsubscribe();
                // Close the window
                SystemCommands.CloseWindow(this);
            }
            else
            {
                WindowFrameMode = WindowMode.Maximized;
            }
        }

        #endregion
    }
}
