namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.Infrastructure
{
    using QuartzEnergy.Common.Dal.Infrastructure;

    public class FracScheduleSessionFactory : ISessionFactory
    {
        private readonly string connectionString;

        public FracScheduleSessionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbContext GetSession()
        {
            return new FracScheduleSqlServerDbContext(this.connectionString);
        }

        public IDbContext GetSession(string conString)
        {
            return new FracScheduleSqlServerDbContext(conString);
        }

        public IDbContext GetSessionWithDisabledLazyLoading()
        {
            var session = new FracScheduleSqlServerDbContext(this.connectionString);
            return session;
        }

        public IDbContext GetSessionWithDisabledLazyLoading(string conString)
        {
            var session = new FracScheduleSqlServerDbContext(conString);
            return session;
        }
    }
}
