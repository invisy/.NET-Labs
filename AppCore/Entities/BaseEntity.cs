using System;

namespace OurAirlines.AppCore.Entities
{
    public class BaseEntity<TEntity>
    {
        public virtual TEntity Id { get; protected set; }
    }
}