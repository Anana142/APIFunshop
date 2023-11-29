using APIFunshop.DataBaseFolder;
using APIFunshop.DTO;
using APIFunshop.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFunshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<DTOProduct>> GetAllProducts()
        {
            return Ok(ProductLogic.GetAllProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<DTOProduct> GetProduct(int id) 
        { 
            if (id != 0)
                return Ok(ProductLogic.GetProduct(id));
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult AddProduct(DTOProduct product) 
        { 
            if(product == null)
                return BadRequest();

            if (product.IdCategory == 0 || DB.GetDB().Categories.First().Id == product.IdCategory == null)
                return BadRequest();    

            ProductLogic.AddProduct(product);

            return Ok();   
        }

        [HttpDelete("{id}")]

        public ActionResult DeleteProduct(int id)
        { 
            if (id == 0)
                return BadRequest();

            ProductLogic.DeleteProduct(id);
            return Ok();
        }

        [HttpPut]
        public  ActionResult PutProduct(DTOProduct product)
        {
            if (product == null)
                return BadRequest();

            if (product.IdCategory == 0 || DB.GetDB().Categories.First().Id == product.IdCategory == null)
                return BadRequest();

            ProductLogic.UpdateProduct(product);

            return Ok();
        }
    }
}
