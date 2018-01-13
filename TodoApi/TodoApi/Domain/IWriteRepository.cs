namespace TodoApi.Domain
{
    public interface IWriteRepository<in T>
        where T : EntityBase
    {
        void Add(T entity);
    }

    public class WriteRepository<T> : IWriteRepository<T>
        where T : EntityBase
    {
        private readonly TodoDbContext _todoDbContext;

        public WriteRepository(TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }

        public void Add(T entity)
        {
            _todoDbContext.Set<T>().Add(entity);
        }
    }
}