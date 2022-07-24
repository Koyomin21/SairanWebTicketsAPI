using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SairanTicketsAPI.Services;

namespace SairanTicketsAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            
            return Ok(await _userService.GetUserAsync(2));
        }

        
    }
}
