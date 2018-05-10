namespace QuartzEnergy.FracSchedule.Services.FracSchedule.Utils
{
    using System;

    using QuartzEnergy.FracSchedule.Services.FracSchedule.Models.Schedules.Enums;

    internal static class ScheduleUtils
    {
        internal static int GetStartInDays(
            this DateTime fracStartDate)
        {
            var today = DateTime.Today;
            return fracStartDate > today ? (fracStartDate - today).Days : 0;
        }

        internal static ScheduleStatus GetScheduleStatus(
            this DateTime fracStartDate)
        {
            var startInDays = fracStartDate.GetStartInDays();

            if (startInDays > 60)
            {
                return ScheduleStatus.Next60PlusDays;
            }

            if (startInDays > 30)
            {
                return ScheduleStatus.Next3160Days;
            }

            if (startInDays > 7)
            {
                return ScheduleStatus.Next830Days;
            }

            if (startInDays > 0)
            {
                return ScheduleStatus.Next7Days;
            }

            return ScheduleStatus.Operating;
        }
    }
}