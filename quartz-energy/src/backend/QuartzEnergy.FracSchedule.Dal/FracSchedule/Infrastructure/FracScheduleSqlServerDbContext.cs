namespace QuartzEnergy.FracSchedule.Dal.FracSchedule.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    public class FracScheduleSqlServerDbContext : FracScheduleDbContext
    {
        public FracScheduleSqlServerDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public FracScheduleSqlServerDbContext(DbContextOptions options)
            : base(options)
        {            
        }
    }
}
