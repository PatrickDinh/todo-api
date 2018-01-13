using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        [HttpGet]
        public TodoModel[] Get()
        {
            
        }
    }
}