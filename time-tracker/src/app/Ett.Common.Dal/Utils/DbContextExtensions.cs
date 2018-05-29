namespace Ett.Common.Dal.Utils
{
    using System.Data.Entity;
    using System.Data.Entity.Core.Mapping;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    internal static class DbContextExtensions
    {
        public static string GetDatabaseTableName<TEntity>(this DbContext context)
        {
            var type = typeof(TEntity);
            var metadata = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;

            // Get the part of the model that contains info about the actual CLR types
            var objectItemCollection = (ObjectItemCollection)metadata.GetItemCollection(DataSpace.OSpace);

            // Get the entity type from the model that maps to the CLR type
            var entityType = metadata
                .GetItems<EntityType>(DataSpace.OSpace)
                .Single(e => objectItemCollection.GetClrType(e) == type);

            // Get the entity set that uses this entity type
            var entitySet = metadata
                .GetItems<EntityContainer>(DataSpace.CSpace)
                .Single()
                .EntitySets
                .Single(s => s.ElementType.Name == entityType.Name);

            // Find the mapping between conceptual and storage model for this entity set
            var mapping = metadata.GetItems<EntityContainerMapping>(DataSpace.CSSpace)
                .Single()
                .EntitySetMappings
                .Single(s => s.EntitySet == entitySet);

            // Find the storage entity sets (tables) that the entity is mapped
            var tables = mapping
                .EntityTypeMappings.Single()
                .Fragments;

            // Return the table name from the storage entity set
            return tables.Select(f => (string)f.StoreEntitySet.MetadataProperties["Table"].Value ?? f.StoreEntitySet.Name)
                .First();
        }
    }
}