using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using ETTTimeTracker.Common;

namespace ETTTimeTracker.ViewModels
{
    public class SettingsViewModel : Observable
    {
        #region LoginName

        private string _loginName = string.Empty;

        /// <summary>
        /// Gets or sets the LoginName property. This observable property 
        /// indicates the login name.
        /// </summary>
        public string LoginName
        {
            get => _loginName;
            set => Set(ref _loginName, value);
        }

        #endregion

        #region CostCenterId

        private string _costCenterId = string.Empty;

        /// <summary>
        /// Gets or sets the CostCenterId property. This observable property 
        /// indicates the cost center Id.
        /// </summary>
        public string CostCenterId
        {
            get => _costCenterId;
            set => Set(ref _costCenterId, value);
        }

        #endregion

        #region TimeZone

        private string _timeZone = string.Empty;

        /// <summary>
        /// Gets or sets the TimeZone property. This observable property 
        /// indicates the time zone in string format.
        /// </summary>
        public string TimeZone
        {
            get => _timeZone;
            set => Set(ref _timeZone, value);
        }

        #endregion

        #region EmailUpdates

        private bool _emailUpdates = false;

        /// <summary>
        /// Gets or sets the EmailUpdates property. This observable property 
        /// indicates whether the email on weekly time entry updates is enabled.
        /// </summary>
        public bool EmailUpdates
        {
            get => _emailUpdates;
            set => Set(ref _emailUpdates, value);
        }

        #endregion

        #region EmailReports

        private bool _emailReports = false;

        /// <summary>
        /// Gets or sets the EmailReports property. This observable property 
        /// indicates whether Email on weekly reports is enabled.
        /// </summary>
        public bool EmailReports
        {
            get => _emailReports;
            set => Set(ref _emailReports, value);
        }

        #endregion

        #region FirstTimeLoginReminder

        private bool _firstTimeLoginReminder = false;

        /// <summary>
        /// Gets or sets the FirstTimeLoginReminder property. This observable property 
        /// indicates whether Logging reminder should be shown upon first login.
        /// </summary>
        public bool FirstTimeLoginReminder
        {
            get => _firstTimeLoginReminder;
            set => Set(ref _firstTimeLoginReminder, value);
        }

        #endregion

        #region MaxWorkTimeExceededReminder

        private bool _maxWorkTimeExceededReminder = false;

        /// <summary>
        /// Gets or sets the MaxWorkTimeExceededReminder property. This observable property 
        /// indicates whether the reminder when maximum working time exeeded should be shown.
        /// </summary>
        public bool MaxWorkTimeExceededReminder
        {
            get => _maxWorkTimeExceededReminder;
            set => Set(ref _maxWorkTimeExceededReminder, value);
        }

        #endregion

        #region IdleDetectionEnabled

        private bool _idleDetectionEnabled = false;

        /// <summary>
        /// Gets or sets the IdleDetectionEnabled property. This observable property 
        /// indicates whether Idle detection is enabled.
        /// </summary>
        public bool IdleDetectionEnabled
        {
            get => _idleDetectionEnabled;
            set => Set(ref _idleDetectionEnabled, value);
        }

        #endregion

        #region IdleDetectionDuration

        private TimeSpan _idleDetectionDuration = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the IdleDetectionDuration property. This observable property 
        /// indicates the idle detection duration.
        /// </summary>
        public TimeSpan IdleDetectionDuration
        {
            get => _idleDetectionDuration;
            set => Set(ref _idleDetectionDuration, value);
        }

        #endregion

        #region ReminderTimeEnabled

        private bool _reminderTimeEnabled = false;

        /// <summary>
        /// Gets or sets the ReminderTimeEnabled property. This observable property 
        /// indicates whether Reminder time is enabled.
        /// </summary>
        public bool ReminderTimeEnabled
        {
            get => _reminderTimeEnabled;
            set => Set(ref _reminderTimeEnabled, value);
        }

        #endregion

        #region ReminderTimeDuration

        private TimeSpan _reminderTimeDuration = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the ReminderTimeDuration property. This observable property 
        /// indicates the Reminder Time duration.
        /// </summary>
        public TimeSpan ReminderTimeDuration
        {
            get => _reminderTimeDuration;
            set => Set(ref _reminderTimeDuration, value);
        }

        #endregion

        #region ReminderOnMonday

        private bool _reminderOnMonday = false;

        /// <summary>
        /// Gets or sets the ReminderOnMonday property. This observable property 
        /// indicates whether Reminder is set for Monday.
        /// </summary>
        public bool ReminderOnMonday
        {
            get => _reminderOnMonday;
            set => Set(ref _reminderOnMonday, value);
        }

        #endregion

        #region ReminderOnTuesday

        private bool _reminderOnTuesday = false;

        /// <summary>
        /// Gets or sets the ReminderOnTuesday property. This observable property 
        /// indicates whether Reminder is set for Tuesday.
        /// </summary>
        public bool ReminderOnTuesday
        {
            get => _reminderOnTuesday;
            set => Set(ref _reminderOnTuesday, value);
        }

        #endregion

        #region ReminderOnWednesday

        private bool _reminderOnWednesday = false;

        /// <summary>
        /// Gets or sets the ReminderOnWednesday property. This observable property 
        /// indicates whether Reminder is set for Wednesday.
        /// </summary>
        public bool ReminderOnWednesday
        {
            get => _reminderOnWednesday;
            set => Set(ref _reminderOnWednesday, value);
        }

        #endregion

        #region ReminderOnThursday

        private bool _reminderOnThursday = false;

        /// <summary>
        /// Gets or sets the ReminderOnThursday property. This observable property 
        /// indicates whether Reminder is set for Thursday.
        /// </summary>
        public bool ReminderOnThursday
        {
            get => _reminderOnThursday;
            set => Set(ref _reminderOnThursday, value);
        }

        #endregion

        #region ReminderOnFriday

        private bool _reminderOnFriday = false;

        /// <summary>
        /// Gets or sets the ReminderOnFriday property. This observable property 
        /// indicates whether Reminder is set for Friday.
        /// </summary>
        public bool ReminderOnFriday
        {
            get => _reminderOnFriday;
            set => Set(ref _reminderOnFriday, value);
        }

        #endregion

        #region ReminderOnSaturday

        private bool _reminderOnSaturday = false;

        /// <summary>
        /// Gets or sets the ReminderOnSaturday property. This observable property 
        /// indicates whether Reminder is set for Saturday.
        /// </summary>
        public bool ReminderOnSaturday
        {
            get => _reminderOnSaturday;
            set => Set(ref _reminderOnSaturday, value);
        }

        #endregion

        #region ReminderOnSunday

        private bool _reminderOnSunday = false;

        /// <summary>
        /// Gets or sets the ReminderOnSunday property. This observable property 
        /// indicates whether Reminder is set for Sunday.
        /// </summary>
        public bool ReminderOnSunday
        {
            get => _reminderOnSunday;
            set => Set(ref _reminderOnSunday, value);
        }

        #endregion

        #region MaxWorkingHours

        private TimeSpan _maxWorkingHours = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the MaxWorkingHours property. This observable property 
        /// indicates the Maximum Working Hours.
        /// </summary>
        public TimeSpan MaxWorkingHours
        {
            get => _maxWorkingHours;
            set => Set(ref _maxWorkingHours, value);
        }

        #endregion
    }
}
