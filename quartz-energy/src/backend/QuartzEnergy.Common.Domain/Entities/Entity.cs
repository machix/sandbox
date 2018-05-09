﻿namespace QuartzEnergy.Common.Domain.Entities
{
    using QuartzEnergy.Common.Domain.Interfaces;
    public abstract class Entity<TId> : IIdEntity<TId>
    {
        public virtual TId Id { get; set; }

        public virtual bool IsNew()
        {
            return this.Id.Equals(default(TId));
        }
    }
}
