using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SairanTicketsAPI.Models;

namespace SairanTicketsAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetUsers()
        {
            
            return Ok();
        }

        
    }
}
