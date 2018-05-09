namespace QuartzEnergy.Common.Services.Specifications
{
    using System.Linq;

    using QuartzEnergy.Common.Domain.Entities;
    using QuartzEnergy.Common.Domain.Interfaces;

    public static class EntitySpecifications
    {
        public static IQueryable<T> GetById<T, TId>(this IQueryable<T> query, TId id) where T : Entity<TId>
        {
            if (!id.Equals(default(TId)))
            {
                query = query.Where(x => x.Id.Equals(id));
            }

            return query;
        }

        public static IQueryable<T> GetByName<T>(this IQueryable<T> query, string name)
            where T : INamedEntity
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var nm = name.Trim().ToLower();
                query = query.Where(e => e.Name.Trim().ToLower().Contains(nm));
            }

            return query;
        }
    }
}
