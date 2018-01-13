using System;

namespace TodoApi.Domain
{
    public class Todo : EntityBase
    {
        public string Name { get; }

        public Todo(string name)
        {
            Id = Guid.NewGuid();
            CreatedDateTime = DateTime.Now;
            LastUpdatedDateTime = DateTime.Now;
            Name = name;
        }
    }
}