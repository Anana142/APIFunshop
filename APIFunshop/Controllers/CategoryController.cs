using APIFunshop.DTO;
using APIFunshop.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFunshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<DTOCategory>> GetAllCategories()
        {
            return Ok(CategoryLogic.GetAllCategories());
        }

        [HttpGet("{id}")]
        public ActionResult<DTOCategory> GetCategory(int id)
        {
            if (id != 0)
                return Ok(CategoryLogic.GetCategory(id));
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult AddCategory(DTOCategory category)
        {
            if (category == null)
                return BadRequest();

            CategoryLogic.AddCategory(category);

            return Ok();
        }

        [HttpDelete("{id}")]

        public ActionResult DeleteCategory(int id)
        {
            if (id == 0)
                return BadRequest();

            CategoryLogic.DeleteCategory(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult PutCategory(DTOCategory category)
        {
            if (category == null)
                return BadRequest();

            CategoryLogic.UpdateCategory(category);

            return Ok();
        }
    }
}
