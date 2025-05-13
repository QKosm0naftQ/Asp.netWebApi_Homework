using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPizushi.Data;
using WebApiPizushi.Models.Category;

namespace WebApiPizushi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController 
        (AppDbPizushiContext appDbPizushiContext ,
        IMapper mapper): Controller
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var model = await mapper.ProjectTo<CategoryItemModel>(appDbPizushiContext.Categories)
                .ToListAsync();
            return Ok(model);
        }
    }
}
