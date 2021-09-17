using Microsoft.AspNetCore.Mvc;
using RecipeModels;
using System.Collections.Generic;

namespace RecipeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public IList<Recipe> Get()
        {
            return new List<Recipe> { new Recipe("Teste") };
        }
    }
}
