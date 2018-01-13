using System;

namespace TodoApi.Domain
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedDateTime { get; protected set; }
        public DateTime LastUpdatedDateTime { get; protected set; }
    }
}