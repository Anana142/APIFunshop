using APIFunshop.DataBaseFolder;
using APIFunshop.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFunshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            return UserLogic.GetAllUsers(); 
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (user == null)
                return BadRequest();

            UserLogic.AddUser(user);    

            return Ok();    


        }
    }
}
