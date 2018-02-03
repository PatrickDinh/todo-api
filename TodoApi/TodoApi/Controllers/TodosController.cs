using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Domain;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private readonly IReadRepository<Todo> _todoReadRepository;

        public TodosController(IReadRepository<Todo> todoReadRepository)
        {
            _todoReadRepository = todoReadRepository;
        }

        [HttpGet]
        public TodoModel[] Get()
        {
            var allTodos = _todoReadRepository.Get();
            return allTodos.Select(td => new TodoModel())
                .ToArray();
        }
    }
}