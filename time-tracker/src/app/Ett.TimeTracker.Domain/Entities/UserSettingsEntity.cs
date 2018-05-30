namespace Ett.TimeTracker.Domain.Entities
{
    using Ett.Common.Domain.Entities;

    public class UserSettingsEntity : IntIdEntity
    {
        public int UserId { get; set; }

        public string CostCenterId { get; set; }

        public string DateFormat { get; set; }

        public bool Is12HourFormat { get; set; }

        public byte? MaximumWorkingHours { get; set; }

        public bool LoggingReminder { get; set; }

        public bool MaxWorkingTimeReminder { get; set; }

        public bool IdleReminder { get; set; }

        public short? IdleTime { get; set; }

        public short? ReminderTime { get; set; }

        public bool MonReminder { get; set; }

        public bool TuesReminder { get; set; }

        public bool WedReminder { get; set; }

        public bool ThursReminder { get; set; }

        public bool FriReminder { get; set; }

        public bool SatReminder { get; set; }

        public bool SunReminder { get; set; }

        public bool EmailTimeEntryUpdates { get; set; }

        public bool EmailWeeklyReports { get; set; }

        public virtual UserEntity User { get; set; }
    }
}