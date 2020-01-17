using Microsoft.AspNetCore.Mvc;
using Palamedes.API.Models;
using Palamedes.API.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Palamedes.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerCrudBase<Category, CategoryRepository>
    {

        public CategoriesController(CategoryRepository CategoryRepository) : base(CategoryRepository)
        {

        }

    }
}
