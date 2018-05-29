using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ETTTimeTracker.Common;

namespace ETTTimeTracker.Models
{
    public class JobTask : Observable
    {
        private Timer _taskTimer;
        private static readonly TimeSpan OneSecond = TimeSpan.FromSeconds(1);

        public bool ShouldDelete { get; set; }

        #region Name

        private string _name = string.Empty;

        /// <summary>
        /// Gets or sets the Name property. This observable property 
        /// indicates the time reporting name of the task entry.
        /// </summary>
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        #endregion
        
        #region Comments

        private string _comments = string.Empty;

        /// <summary>
        /// Gets or sets the Comments property. This observable property 
        /// indicates the comments regarding this task entry.
        /// </summary>
        public string Comments
        {
            get => _comments;
            set => Set(ref _comments, value);
        }

        #endregion

        #region AFE

        private string _aFE = string.Empty;

        /// <summary>
        /// Gets or sets the AFE property. This observable property 
        /// indicates the AFE value.
        /// </summary>
        public string AFE
        {
            get => _aFE;
            set => Set(ref _aFE, value);
        }

        #endregion

        #region CostCenter

        private string _costCenter = string.Empty;

        /// <summary>
        /// Gets or sets the CostCenter property. This observable property 
        /// indicates the Cost Center.
        /// </summary>
        public string CostCenter
        {
            get => _costCenter;
            set => Set(ref _costCenter, value);
        }

        #endregion

        #region TaskDate

        private DateTime _taskDate;

        /// <summary>
        /// Gets or sets the TaskDate property. This observable property 
        /// indicates the task date.
        /// </summary>
        public DateTime TaskDate
        {
            get => _taskDate;
            set => Set(ref _taskDate, value);
        }

        #endregion

        #region Notes

        private string _notes = string.Empty;

        /// <summary>
        /// Gets or sets the Notes property. This observable property 
        /// indicates the notes associated with this task.
        /// </summary>
        public string Notes
        {
            get => _notes;
            set => Set(ref _notes, value);
        }

        #endregion

        #region AutoLoggedTime

        private TimeSpan _autoLoggedTime = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the AutoLoggedTime property. This observable property 
        /// indicates the logged time calculated from the timer.
        /// </summary>
        public TimeSpan AutoLoggedTime
        {
            get => _autoLoggedTime;
            set
            {
                Set(ref _autoLoggedTime, value);
                AutoLoggedTimeString = $"{_autoLoggedTime.Hours:00}:{_autoLoggedTime.Minutes:00}:{_autoLoggedTime.Seconds:00}";
            }
        }

        #endregion

        #region AutoLoggedTimeString

        private string _autoLoggedTimeString = string.Empty;

        /// <summary>
        /// Gets or sets the AutoLoggedTimeString property. This observable property 
        /// indicates the AutoLogged in string format.
        /// </summary>
        public string AutoLoggedTimeString
        {
            get => _autoLoggedTimeString;
            set => Set(ref _autoLoggedTimeString, value);
        }

        #endregion

        #region ManualLoggedTime

        private TimeSpan _manualLoggedTime = TimeSpan.Zero;

        /// <summary>
        /// Gets the ManualLoggedTime property. This observable property 
        /// indicates the logged time calculated from the manually entered time.
        /// </summary>
        public TimeSpan ManualLoggedTime
        {
            get => _manualLoggedTime;
            private set => Set(ref _manualLoggedTime, value);
        }

        #endregion

        #region ManualStartTime

        private TimeSpan _manualStartTime = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the ManualStartTime property. This observable property 
        /// indicates the start time for the manually entered logged time.
        /// </summary>
        public TimeSpan ManualStartTime
        {
            get => _manualStartTime;
            set
            {
                Set(ref _manualStartTime, value);
                ManualLoggedTime = _manualEndTime.Subtract(_manualStartTime);
            }
        }

        #endregion

        #region ManualEndTime

        private TimeSpan _manualEndTime = TimeSpan.Zero;

        /// <summary>
        /// Gets or sets the ManualEndTime property. This observable property 
        /// indicates the start time for the manually entered logged time.
        /// </summary>
        public TimeSpan ManualEndTime
        {
            get => _manualEndTime;
            set
            {
                Set(ref _manualEndTime, value);
                ManualLoggedTime = _manualEndTime.Subtract(_manualStartTime);
            }
        }

        #endregion

        #region IsTimerActive

        private bool _isTimerActive = false;

        /// <summary>
        /// Gets or sets the IsTimerActive property. This observable property 
        /// indicates whether the timer has been started for this Job entry.
        /// </summary>
        public bool IsTimerActive
        {
            get => _isTimerActive;
            set => Set(ref _isTimerActive, value);
        }

        #endregion

        public JobTask()
        {
            _taskTimer = new Timer(1000);
            _taskTimer.Elapsed += OnTimerElapsed;
            TaskDate = DateTime.Now;
            AutoLoggedTime = new TimeSpan(0, 0, 0);
            ManualStartTime = new TimeSpan(0, 0, 0);
            ManualEndTime = new TimeSpan(0, 0, 0);
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            AutoLoggedTime += OneSecond;
        }

        public void StartTimer()
        {
            if (_isTimerActive)
                return;

            IsTimerActive = true;
            if (!_taskTimer.Enabled)
                _taskTimer.Start();
        }

        public void PauseTimer()
        {
            if (!_isTimerActive)
                return;

            IsTimerActive = false;
            if (_taskTimer.Enabled)
                _taskTimer.Stop();
        }

        public JobTaskBackup CreateBackup()
        {
            return new JobTaskBackup()
            {
                Name = Name,
                Comments = Comments,
                CostCenter = CostCenter,
                AFE = AFE,
                ManualStartTime = ManualStartTime,
                ManualEndTime = ManualEndTime,
            };
        }

        public void RestoreFrom(JobTaskBackup task)
        {
            Name = task.Name;
            Comments = task.Comments;
            CostCenter = task.CostCenter;
            AFE = task.AFE;
            ManualStartTime = task.ManualStartTime;
            ManualEndTime = task.ManualEndTime;
        }

        public void DeleteTask()
        {
            if (_taskTimer == null)
                return;

            _taskTimer.Elapsed -= OnTimerElapsed;
            _taskTimer.Dispose();
            _taskTimer = null;
        }
    }
}
