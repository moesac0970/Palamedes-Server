using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
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
