using Microsoft.EntityFrameworkCore;

namespace TodoApi.Domain
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}