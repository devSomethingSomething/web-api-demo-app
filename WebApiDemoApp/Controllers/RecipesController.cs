using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes()
        {
            string[] dishes = { "Dish 1", "Dish 2", "Dish 3" };

            return dishes;
        }
    }
}
