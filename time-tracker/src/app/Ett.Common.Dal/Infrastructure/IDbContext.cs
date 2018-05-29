namespace Ett.Common.Dal.Infrastructure
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Threading.Tasks;

    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int Commit();

        void Dispose();

        string GetTableName<T>();

        void ExecuteCommand(string command, params object[] parameters);

        void BulkAdd<T>(IEnumerable<T> entities);

        Task<int> CommitAsync();
    }
}