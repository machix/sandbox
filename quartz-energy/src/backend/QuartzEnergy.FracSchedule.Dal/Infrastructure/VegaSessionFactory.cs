namespace QuartzEnergy.FracSchedule.Dal.Infrastructure
{
    using QuartzEnergy.Common.Dal.Infrastructure;

    public class VegaSessionFactory : IVegaSessionFactory
    {
        private readonly string connectionString;

        public VegaSessionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbContext GetSession()
        {
            return new VegaSqlServerDbContext(this.connectionString);
        }

        public IDbContext GetSession(string conString)
        {
            return new VegaSqlServerDbContext(conString);
        }

        public IDbContext GetSessionWithDisabledLazyLoading()
        {
            var session = new VegaSqlServerDbContext(this.connectionString);
            return session;
        }

        public IDbContext GetSessionWithDisabledLazyLoading(string conString)
        {
            var session = new VegaSqlServerDbContext(conString);
            return session;
        }
    }
}
