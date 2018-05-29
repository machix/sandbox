namespace Ett.Common.Dal.Infrastructure.Concrete
{
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Threading.Tasks;

    using EntityFramework.BulkInsert.Extensions;

    using Ett.Common.Dal.Infrastructure;
    using Ett.Common.Dal.Utils;

    public abstract class DatabaseContext : DbContext, IDbContext
    {
        protected DatabaseContext()
        {
        }

        protected DatabaseContext(DbConnection connection)
            : base(connection, true)
        {
        }

        public virtual int Commit()
        {
            return this.SaveChanges();
        }


        public string GetTableName<T>()
        {
            return this.GetDatabaseTableName<T>();
        }

        public void ExecuteCommand(string command, params object[] parameters)
        {
            this.Database.ExecuteSqlCommand(command, parameters);
        }

        public void BulkAdd<T>(IEnumerable<T> entities)
        {
            this.BulkInsert(entities);
        }

        public virtual async Task<int> CommitAsync()
        {
            return await this.SaveChangesAsync();
        }
    }
}