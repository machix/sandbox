namespace Ett.TimeTracker.Dal.Infrastructure
{
    using Ett.Common.Dal.Infrastructure;

    public class TimeTrackerSessionFactory : ISessionFactory
    {
        private readonly string defaultConnectionString;

        public TimeTrackerSessionFactory(string defaultConnectionString)
        {
            this.defaultConnectionString = defaultConnectionString;
        }

        public TimeTrackerSessionFactory()
        {
        }

        public IDbContext GetSession()
        {
            if (!string.IsNullOrEmpty(this.defaultConnectionString))
            {
                return new TimeTrackerSqlServerDbContext(this.defaultConnectionString);
            }

            return new TimeTrackerSqlServerDbContext();
        }

        public IDbContext GetSession(string connectionString)
        {
            return new TimeTrackerSqlServerDbContext(connectionString);
        }

        public IDbContext GetSessionWithDisabledLazyLoading()
        {
            var session = new TimeTrackerSqlServerDbContext();
            session.Configuration.LazyLoadingEnabled = false;
            return session;
        }

        public IDbContext GetSessionWithDisabledLazyLoading(string connectionString)
        {
            var session = new TimeTrackerSqlServerDbContext(connectionString);
            session.Configuration.LazyLoadingEnabled = false;
            return session;
        }
    }
}