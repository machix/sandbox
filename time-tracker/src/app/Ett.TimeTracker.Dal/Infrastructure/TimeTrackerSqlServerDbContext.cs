namespace Ett.TimeTracker.Dal.Infrastructure
{
    using System.Data.SqlClient;

    public class TimeTrackerSqlServerDbContext : TimeTrackerDbContext
    {
        public TimeTrackerSqlServerDbContext()
        {
            System.Data.Entity.Database.SetInitializer<TimeTrackerSqlServerDbContext>(null);
        }

        public TimeTrackerSqlServerDbContext(string connectionString)
            : base(new SqlConnection(connectionString))
        {
        }
    }
}