using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETTTimeTracker.Common;
using ETTTimeTracker.Models;

namespace ETTTimeTracker.ViewModels
{
    public class ETTViewModel : Observable
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

        #region SelectedJobTitle

        private JobTitle _selectedJobTitle = null;

        /// <summary>
        /// Gets or sets the SelectedJob property. This observable property 
        /// indicates the selected Job.
        /// </summary>
        public JobTitle SelectedJobTitle
        {
            get => _selectedJobTitle;
            set => Set(ref _selectedJobTitle, value);
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

        #region ActiveTask

        private JobTask _activeTask = null;

        /// <summary>
        /// Gets or sets the ActiveTask property. This observable property 
        /// indicates the currently active task.
        /// </summary>
        public JobTask ActiveTask
        {
            get => _activeTask;
            set => Set(ref _activeTask, value);
        }

        #endregion

        #region Tasks

        private ObservableCollection<JobTask> _tasks = null;

        /// <summary>
        /// Gets or sets the Tasks property. This observable property 
        /// indicates the list of job tasks.
        /// </summary>
        public ObservableCollection<JobTask> Tasks
        {
            get => _tasks;
            set => Set(ref _tasks, value);
        }

        #endregion

        public ETTViewModel()
        {
            GenerateSampleData();
        }

        private void GenerateSampleData()
        {
            LoginName = "John Doe";
            CostCenterId = "Cost Center ID 0001234";
            ActiveTask = new JobTask();

            Tasks = new ObservableCollection<JobTask>
            {
                new JobTask()
                {
                    Name = "Regular",
                    AFE = "AFE001234",
                    CostCenter = "AFE0001234",
                    TaskDate = DateTime.Now.Subtract(TimeSpan.FromDays(6)),
                    Comments = @"Project Regular Notes:
Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
Sed a urna tristique, aliquet felis ut, rhoncus turpis. 
Aenean elit purus, lacinia a elit in, tincidunt ornare lacus. 
Integer aliquet feugiat dolor nec semper. Donec dignissim 
tellus pretium fringilla euismod. Nunc eget imperdiet dui. 
Maecenas mattis interdum volutpat. Vestibulum ante ipsum 
primis in faucibus orci luctus et ultrices posuere cubilia Curae"
                },
                new JobTask()
                {
                    Name = "Jury Duty",
                    AFE = "AFE001237",
                    CostCenter = "CostCenter CC001237",
                    TaskDate = DateTime.Now.Subtract(TimeSpan.FromDays(6)),
                    Comments = @"Jury Duty Notes:
Fusce lacinia blandit odio, nec fermentum neque gravida in. 
Sed accumsan, metus nec viverra euismod, lorem purus tristique 
lacus, eu condimentum lectus odio consectetur arcu. Nulla non 
orci ut tellus iaculis feugiat. Pellentesque fringilla volutpat 
aliquet. Nunc metus arcu, molestie sed mollis nec, ornare eget
lorem. Morbi dignissim, ex et iaculis sollicitudin, dui arcu 
faucibus metus, nec tempus mauris purus non ante. 
Aliquam vitae odio est."
                },
                new JobTask()
                {
                    Name = "Military Training",
                    AFE = "AFE001244",
                    CostCenter = "CostCenter CC001244",
                    TaskDate = DateTime.Now.Subtract(TimeSpan.FromDays(6)),
                    Comments = @"Military Training Notes:
Sed ultrices luctus tempor. Quisque condimentum justo cursus, 
auctor ligula vitae, feugiat diam. Proin eu vulputate enim, 
quis dictum dui. Etiam id fringilla turpis. Donec tristique 
pretium ligula at vestibulum. Vestibulum erat tortor, egestas
ut erat vel, sodales ornare tellus. Mauris id nulla convallis,
scelerisque orci vel, venenatis turpis. Quisque blandit 
consectetur tristique. Lorem ipsum dolor sit amet, consectetur
adipiscing elit. Nulla vel fermentum lacus. Aliquam vel enim 
maximus, fringilla nulla ut, maximus ante. "
                },
                new JobTask()
                {
                    Name = "LWOP",
                    AFE = "AFE001242",
                    CostCenter = "CostCenter CC001242",
                    TaskDate = DateTime.Now.Subtract(TimeSpan.FromDays(6)),
                    Comments = @"LWOP Notes:
Praesent viverra magna eu semper tempus. Quisque quis suscipit
ex. Nullam facilisis sem nec pulvinar eleifend. Lorem ipsum 
dolor sit amet, consectetur adipiscing elit. Nulla facilisi. 
Duis interdum vehicula lorem, accumsan faucibus arcu posuere id.
Vestibulum justo felis, interdum sed felis vel, efficitur 
molestie mauris. Fusce imperdiet augue vitae nisi pretium, 
ac pretium mi vehicula. Ut vel arcu hendrerit, aliquet ex in,
aliquam magna."
                }
            };
        }

        public void UpdateSettingsViewModel(SettingsViewModel svm)
        {
            svm.LoginName = LoginName;
            svm.CostCenterId = CostCenterId;
            svm.TimeZone = TimeZone;
            svm.EmailUpdates = EmailUpdates;
            svm.EmailReports = EmailReports;
            svm.FirstTimeLoginReminder = FirstTimeLoginReminder;
            svm.MaxWorkTimeExceededReminder = MaxWorkTimeExceededReminder;
            svm.IdleDetectionEnabled = IdleDetectionEnabled;
            svm.IdleDetectionDuration = IdleDetectionDuration;
            svm.ReminderTimeEnabled = ReminderTimeEnabled;
            svm.ReminderTimeDuration = ReminderTimeDuration;
            svm.ReminderOnMonday = ReminderOnMonday;
            svm.ReminderOnTuesday = ReminderOnTuesday;
            svm.ReminderOnWednesday = ReminderOnWednesday;
            svm.ReminderOnThursday = ReminderOnThursday;
            svm.ReminderOnFriday = ReminderOnFriday;
            svm.ReminderOnSaturday = ReminderOnSaturday;
            svm.ReminderOnSunday = ReminderOnSunday;
            svm.MaxWorkingHours = MaxWorkingHours;
        }

        public void SaveSettings(SettingsViewModel svm)
        {
            //LoginName = svm.LoginName;
            CostCenterId = svm.CostCenterId;
            //TimeZone = svm.TimeZone;
            EmailUpdates = svm.EmailUpdates;
            EmailReports = svm.EmailReports;
            FirstTimeLoginReminder = svm.FirstTimeLoginReminder;
            MaxWorkTimeExceededReminder = svm.MaxWorkTimeExceededReminder;
            IdleDetectionEnabled = svm.IdleDetectionEnabled;
            IdleDetectionDuration = svm.IdleDetectionDuration;
            ReminderTimeEnabled = svm.ReminderTimeEnabled;
            ReminderTimeDuration = svm.ReminderTimeDuration;
            ReminderOnMonday = svm.ReminderOnMonday;
            ReminderOnTuesday = svm.ReminderOnTuesday;
            ReminderOnWednesday = svm.ReminderOnWednesday;
            ReminderOnThursday = svm.ReminderOnThursday;
            ReminderOnFriday = svm.ReminderOnFriday;
            ReminderOnSaturday = svm.ReminderOnSaturday;
            ReminderOnSunday = svm.ReminderOnSunday;
            MaxWorkingHours = svm.MaxWorkingHours;
        }

        public void SetActiveTask(JobTask jobTask)
        {
            if (_activeTask == jobTask)
            {
                return;
            }

            if (_activeTask.IsTimerActive)
            {
                _activeTask?.PauseTimer();
            }

            ActiveTask = jobTask;
        }

        public void ActivateTask(bool startTimer = true)
        {
            // Check if the active task has been added to the tasks list
            if (!_tasks.Contains(_activeTask))
            {
                // If the default task Name and AFE has not been selected 
                // set it to Regular

                if (String.IsNullOrWhiteSpace(_activeTask.Name))
                {
                    _activeTask.Name = "Regular";
                    _activeTask.AFE = "AFE001234";
                    _activeTask.CostCenter = "AFE0001234";
                    _activeTask.TaskDate = DateTime.Now;
                    _activeTask.Comments = @"Project Regular Notes:
Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
Sed a urna tristique, aliquet felis ut, rhoncus turpis. 
Aenean elit purus, lacinia a elit in, tincidunt ornare lacus. 
Integer aliquet feugiat dolor nec semper. Donec dignissim 
tellus pretium fringilla euismod. Nunc eget imperdiet dui. 
Maecenas mattis interdum volutpat. Vestibulum ante ipsum 
primis in faucibus orci luctus et ultrices posuere cubilia Curae";
                }
                Tasks.Add(ActiveTask);
            }

            if (startTimer)
            {
                ActiveTask.StartTimer();
            }
        }
    }
}
