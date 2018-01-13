using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Domain
{
    public interface IReadRepository<out T>
        where T : EntityBase
    {
        T[] Get();
    }

    public class ReadRepository<T> : IReadRepository<T>
        where T : EntityBase
    {
        private readonly TodoDbContext _todoDbContext;

        public ReadRepository(TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }

        public T[] Get()
        {
            return _todoDbContext.Set<T>()
                .AsNoTracking()
                .ToArray();
        }
    }
}