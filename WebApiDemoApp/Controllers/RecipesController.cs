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
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Recipe 1", "Recipe 2", "Recipe 3" };

            if (!recipes.Any())
            {
                return NotFound();
            }

            return Ok(recipes);
        }

        [HttpPut]
        public ActionResult UpdateRecipes(int index, string recipe)
        {
            string[] recipes = { "Recipe 1", "Recipe 2", "Recipe 3" };

            if (!recipes.Any())
            {
                return NotFound();
            }

            recipes[index] = recipe;

            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool error = false;

            if (error)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
